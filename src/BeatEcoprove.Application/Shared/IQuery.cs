using MediatR;

namespace BeatEcoprove.Application.Shared;

public interface IQuery<out TResponse> : IRequest<TResponse> { }