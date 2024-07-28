using MyBook.Domain.Entities.Base;

namespace MyBook.Domain.Entities
{
    public class SubjectEntity : EntityBase<SubjectEntity>
    {
     
        public int Description { get; set; }
    }
}
