using MyBook.Domain.Entities.Base;

namespace MyBook.Domain.Entities
{
    public  class BookEntity : EntityBase<BookEntity>
    {
        public string Title { get; set; }
        public string PublishingCompany { get; set; }
        public int Edition { get; set; }
        public string PublicationDate { get; set; }
    }
}
