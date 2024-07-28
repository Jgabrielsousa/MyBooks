using MyBook.Application.Results.Dtos;

namespace MyBook.Api.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public static implicit operator SubjectDto(Subject autor)
        {

            return new SubjectDto() { Description = autor.Description };
 ;
        }
    }
}
