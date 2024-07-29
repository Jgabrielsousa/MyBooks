using MyBook.Domain.Entities.Base;
using System.Text.Json.Serialization;

namespace MyBook.Domain.Entities.ManyToMany
{
    public class SubjectBook : EntityBase<SubjectBook>
    {
        [JsonIgnore]
        public SubjectEntity Subject { get; set; }
        public int SubjectId { get; set; }
        [JsonIgnore]
        public BookEntity Book { get; set; }
        public int BookId { get; set; }
    }
}
