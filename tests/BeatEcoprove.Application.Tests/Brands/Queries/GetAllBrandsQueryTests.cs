using BeatEcoprove.Application.Brands.Queries;

namespace BeatEcoprove.Application.Tests.Brands.Queries;

public class GetAllBrandsQueryTests : BaseIntegrationTest
{
    public GetAllBrandsQueryTests
        (IntegrationWebApplicationFactory factory) : base(factory)
    {
    }

    [Fact]
    public async Task GetAllBrands_ShouldReturnBrands_WhenBrandsExists()
    {
        // Arrange
        var query = new GetAllBrandsQuery();

        // Act
        var brands = await _sender.Send(query);

        // Assert
        Assert.False(brands.IsError);
        Assert.NotEmpty(brands.Value);
    }
}