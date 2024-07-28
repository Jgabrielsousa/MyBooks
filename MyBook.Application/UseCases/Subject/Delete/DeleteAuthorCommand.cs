using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.Subject.Delete
{
    public class DeleteSubjectCommand : Command<DeleteSubjectCommand>
    {
        public int Id { get; set; }

        public DeleteSubjectCommand() 
        {
                
        }
        public DeleteSubjectCommand(int id)
        {
            Id = id;
        }
    }
}
