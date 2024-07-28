using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.Subject.FindById
{
    public class FindByIdSubjectCommand : Command<FindByIdSubjectCommand>
    {
        public int Id { get; set; }


        public FindByIdSubjectCommand()
        {
                
        }
        public FindByIdSubjectCommand(int id)
        {
            Id = id;
        }

    }
}
