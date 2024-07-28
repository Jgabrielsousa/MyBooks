using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.Book.Delete
{
    public class DeleteBookCommand : Command<DeleteBookCommand>
    {
        public int Id { get; set; }

        public DeleteBookCommand() 
        {
                
        }
        public DeleteBookCommand(int id)
        {
            Id = id;
        }
    }
}
