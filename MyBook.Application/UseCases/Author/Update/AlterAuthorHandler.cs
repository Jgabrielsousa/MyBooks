using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.Author.Create
{
    public class AlterAuthorHandler : Handler<AlterAuthorCommand, AlterAuthorHandler>
    {
        public AlterAuthorHandler()
        {

        }

        public override Task<Result> Handle(AlterAuthorCommand request, CancellationToken cancellationToken)
        {
           

            return Task.FromResult(Result);
        }
    }
}
