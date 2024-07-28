using MyBook.Application.Results;
using MyBook.Application.Results.Dtos;
using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.Author.Create
{
    public class FindAuthorHandler : Handler<FindAuthorCommand, FindAuthorHandler>
    {
        public FindAuthorHandler()
        {

        }

        public override Task<Result> Handle(FindAuthorCommand request, CancellationToken cancellationToken)
        {
            var list = new List<AuthorDto>();

            list.Add(new AuthorDto(1, "Jhon Snow"));
            list.Add(new AuthorDto(2, "Jhon Snow2"));
            list.Add(new AuthorDto(3, "Jhon Snow3"));

            Result.Data = list;

            return Task.FromResult(Result);
        }
    }
}
