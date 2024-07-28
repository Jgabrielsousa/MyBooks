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

            for (int i = 0; i < 10; i++)
            {
                var autor = new AuthorDto(1, "Jhon Snow" + i);
                var books = new List<BookDto>();

                books.Add(new BookDto()
                {
                    Id = i,
                    Edition = 10,
                    PublicationDate = "2010",
                    PublishingCompany = "Saraiva",
                    Title = "Nome Livro",
                    Subjects = new List<SubjectDto>() 
                    { 
                            new SubjectDto() 
                            { 
                                Description = "Assunto" + i, 
                                Id = i 
                            } 
                    }
                });

                autor.Books = books;

                list.Add(autor);

            }

            Result.Data = list;

            return Task.FromResult(Result);
        }
    }
}
