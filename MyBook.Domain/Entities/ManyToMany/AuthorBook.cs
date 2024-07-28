using MyBook.Domain.Entities.Base;

namespace MyBook.Domain.Entities.ManyToMany
{
    public  class AuthorBook : EntityBase<AuthorBook>
    {

        public AuthorEntity Author { get; set; }
        public int AuthorId { get; set; }

        public BookEntity Book { get; set; }
        public int BookId { get; set; }


   
    }
}
