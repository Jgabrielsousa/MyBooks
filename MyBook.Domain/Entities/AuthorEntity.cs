using MyBook.Domain.Entities.Base;
using MyBook.Domain.Entities.ManyToMany;

namespace MyBook.Domain.Entities
{
    public  class AuthorEntity : EntityBase<AuthorEntity>
    {
        public string Name { get; set; }

        public virtual ICollection<AuthorBook> AuthorBook { get; set; }
    }
}
