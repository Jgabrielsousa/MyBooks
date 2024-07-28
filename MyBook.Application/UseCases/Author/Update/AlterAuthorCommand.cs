using MyBook.Application.Results.Dtos;
using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.Author.Create
{
    public class AlterAuthorCommand : Command<AlterAuthorCommand>
    {
        public int Id { get; set; }
        public AuthorDto Author { get; set; }


        public AlterAuthorCommand()
        {
        }
        public AlterAuthorCommand(int id, AuthorDto author)
        {
            Id = id;
            Author = author;
        }

    }
}
