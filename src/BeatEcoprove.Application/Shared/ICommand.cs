using MediatR;

namespace BeatEcoprove.Application.Shared;

public interface ICommand : IRequest { }

public interface ICommand<out TResponse> : IRequest<TResponse> { }