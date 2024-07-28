using MyBook.Application.Results;
using MyBook.Application.Results.Dtos;
using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.Author.Create
{
    public class FindByIdAuthorHandler : Handler<FindByIdAuthorCommand, FindByIdAuthorHandler>
    {
        public FindByIdAuthorHandler()
        {

        }

        public override Task<Result> Handle(FindByIdAuthorCommand request, CancellationToken cancellationToken)
        {
            Result.Data = new AuthorDto(1, "Jhon Snow");

            return Task.FromResult(Result);
        }
    }
}
