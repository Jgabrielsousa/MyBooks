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
        public int AuthorId { get; set; }

        public static implicit operator BookDto(Book author)
        {

            return new BookDto() {
                Title = author.Title,
                PublishingCompany = author.PublishingCompany,
                Edition = author.Edition,
                PublicationDate = author.PublicationDate,
                AuthorId = author.AuthorId,
            };
        }
    }
}
