using MyBook.Domain.Entities.Base;
using MyBook.Domain.Entities.ManyToMany;

namespace MyBook.Domain.Entities
{
    public class SaleTypeEntity :  EntityBase<SaleTypeEntity>
    {
        public string Description { get; set; }
        public float Value { get; set; }
        public virtual ICollection<SaleTypeBook> SaleTypeBook { get; set; }
    }
}
