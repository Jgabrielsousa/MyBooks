namespace MyBook.Api.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public int PublishingCompany { get; set; }
        public int Edition { get; set; }
        public string PublicationDate { get; set; }
    }
}
