using MyBook.Application.Results;
using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.Author.Delete
{
    public  class DeleteAuthorHandler : Handler<DeleteAuthorCommand, DeleteAuthorHandler>
    {
        public DeleteAuthorHandler()
        {
                
        }

        public override Task<Result> Handle(DeleteAuthorCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result);
        }
    }
}
