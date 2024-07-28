using MyBook.Domain.Entities.Base;

namespace MyBook.Domain.Entities.ManyToMany
{
    public class SubjectBook : EntityBase<SubjectBook>
    {
        public SubjectEntity Subject { get; set; }
        public int SubjectId { get; set; }

        public BookEntity Book { get; set; }
        public int BookId { get; set; }
    }
}
