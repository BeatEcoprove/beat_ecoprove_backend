using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace BeatEcoprove.Infrastructure.Extensions;

public static class EFCoreExtensions
{
    public static void SetUpGlobalQueryFilters<T>(this ModelBuilder modelBuilder, Expression<Func<T, bool>> filter)
    {
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (entityType.ClrType.IsAssignableTo(typeof(T)))
            {
                var rootType = entityType.ClrType;
                while (rootType.BaseType != null && modelBuilder.Model.FindEntityType(rootType.BaseType) != null)
                {
                    rootType = rootType.BaseType;
                }

                var parameter = Expression.Parameter(rootType);
                var body = ReplacingExpressionVisitor.Replace(filter.Parameters.First(), parameter, filter.Body);
                var lambdaExpression = Expression.Lambda(body, parameter);

                modelBuilder.Entity(rootType).HasQueryFilter(lambdaExpression);
            }
        }
    }
}