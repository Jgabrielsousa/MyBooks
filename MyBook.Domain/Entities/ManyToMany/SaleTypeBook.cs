using MyBook.Domain.Entities.Base;

namespace MyBook.Domain.Entities.ManyToMany
{
    public class SaleTypeBook : EntityBase<SaleTypeBook>
    {
        public SaleTypeEntity SaleType { get; set; }
        public int SaleTypeId { get; set; }

        public BookEntity Book { get; set; }
        public int BookId { get; set; }
    }
}
