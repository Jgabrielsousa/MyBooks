using MyBook.Application.Results.Dtos;

namespace MyBook.Api.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PublishingCompany { get; set; }
        public int Edition { get; set; }
        public string PublicationDate { get; set; }

        public static implicit operator BookDto(Book autor)
        {

            return new BookDto() {
                Title = autor.Title,
                PublishingCompany = autor.PublishingCompany,
                Edition = autor.Edition,
                PublicationDate = autor.PublicationDate
            };
        }
    }
}
