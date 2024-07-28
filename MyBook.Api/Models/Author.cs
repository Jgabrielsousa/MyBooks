using MyBook.Application.Results.Dtos;

namespace MyBook.Api.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static implicit operator AuthorDto(Author autor)
        {

            return new AuthorDto(autor.Id, autor.Name);
        }
    }
}
