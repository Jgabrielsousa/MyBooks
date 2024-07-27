using Flunt.Notifications;
using MediatR;
using MyBook.Application.Results;

namespace MyBook.Application.UseCases.Base
{
    public abstract class Command<T> : IRequest<Result>
       where T : Command<T>
      , new()
    {
    }
}
