using MyBook.Application.Results.Dtos;
using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.Book.Update
{
    public class AlterBookCommand : Command<AlterBookCommand>
    {
        public int Id { get; set; }
        public BookDto Book { get; set; }


        public AlterBookCommand()
        {
        }
        public AlterBookCommand(int id, BookDto author)
        {
            Id = id;
            Book = author;
        }

    }
}
