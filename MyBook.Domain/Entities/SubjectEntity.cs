using MyBook.Domain.Entities.Base;
using MyBook.Domain.Entities.ManyToMany;

namespace MyBook.Domain.Entities
{
    public class SubjectEntity : EntityBase<SubjectEntity>
    {
     
        public string Description { get; set; }

        public virtual ICollection<SubjectBook> SubjectBook { get; set; }
    }
}
