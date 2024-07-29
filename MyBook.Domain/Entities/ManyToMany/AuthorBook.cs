using MyBook.Domain.Entities.Base;
using System.Text.Json.Serialization;

namespace MyBook.Domain.Entities.ManyToMany
{
    public  class AuthorBook : EntityBase<AuthorBook>
    {
        [JsonIgnore]
        public AuthorEntity Author { get; set; }
        public int AuthorId { get; set; }
        [JsonIgnore]
        public BookEntity Book { get; set; }
        public int BookId { get; set; }


   
    }
}
