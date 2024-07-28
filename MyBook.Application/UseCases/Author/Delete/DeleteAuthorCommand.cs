using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.Author.Delete
{
    public class DeleteAuthorCommand : Command<DeleteAuthorCommand>
    {
        public int Id { get; set; }

        public DeleteAuthorCommand() 
        {
                
        }
        public DeleteAuthorCommand(int id)
        {
            Id = id;
        }
    }
}
