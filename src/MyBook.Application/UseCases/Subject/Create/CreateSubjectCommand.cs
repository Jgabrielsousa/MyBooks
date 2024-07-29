using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.Subject.Create
{
    public class CreateSubjectCommand : Command<CreateSubjectCommand>
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int BookId { get; set; }
        public CreateSubjectCommand()
        {
                
        }

        public CreateSubjectCommand(string description, int bookId)
        {
            Description = description;  
            BookId = bookId;
        }
    }
}
