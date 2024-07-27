using MediatR;
using MyBook.Application.Results;

namespace MyBook.Application.UseCases.Base
{
    public abstract class Handler<C, H> : IRequestHandler<C, Result>
        where C : Command<C>, new()
        where H : Handler<C,H> 
    {
        public Result Result { get; set; }

        public string HandlerName => nameof(H);
        public string CommandName => nameof(C);

        protected Handler()
        {
            Result = new Result();
        }

        public abstract Task<Result> Handle(C request, CancellationToken cancellationToken);

    }
}
