using MyBook.Application.Results.Dtos;

namespace MyBook.Api.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int BookId { get; set; }

        public static implicit operator SubjectDto(Subject subject)
        {

            return new SubjectDto() { Description = subject.Description , BookId = subject .BookId};
 ;
        }
    }
}
