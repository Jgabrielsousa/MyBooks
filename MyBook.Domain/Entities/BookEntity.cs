using MyBook.Domain.Entities.Base;
using MyBook.Domain.Entities.ManyToMany;

namespace MyBook.Domain.Entities
{
    public  class BookEntity : EntityBase<BookEntity>
    {
        public string Title { get; set; }
        public string PublishingCompany { get; set; }
        public int Edition { get; set; }
        public string PublicationDate { get; set; }

        public virtual ICollection<AuthorBook> AuthorBook { get; set; }
        public virtual ICollection<SubjectBook> SubjectBook { get; set; }
        public virtual ICollection<SaleTypeBook> SaleTypeBook { get; set; }


    }
}
