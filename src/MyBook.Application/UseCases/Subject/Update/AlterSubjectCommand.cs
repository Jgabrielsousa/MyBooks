using MyBook.Application.Results.Dtos;
using MyBook.Application.UseCases.Base;

namespace MyBook.Application.UseCases.Subject.Update
{
    public class AlterSubjectCommand : Command<AlterSubjectCommand>
    {
        public int Id { get; set; }
        public SubjectDto Subject { get; set; }


        public AlterSubjectCommand()
        {
        }
        public AlterSubjectCommand(int id, SubjectDto author)
        {
            Id = id;
            Subject = author;
        }

    }
}
