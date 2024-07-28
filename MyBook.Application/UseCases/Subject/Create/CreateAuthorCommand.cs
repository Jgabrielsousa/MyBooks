using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.Subject.Create
{
    public class CreateSubjectCommand : Command<CreateSubjectCommand>
    {
        public string Description { get; set; }
        public CreateSubjectCommand()
        {
                
        }

        public CreateSubjectCommand(string description)
        {
            Description = description;
        }
    }
}
