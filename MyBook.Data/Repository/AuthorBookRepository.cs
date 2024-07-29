using MyBook.Data.Context;
using MyBook.Data.Repository.Base;
using MyBook.Domain.Entities.ManyToMany;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Data.Repository
{

    public class AuthorBookRepository : RepositoryBase<AuthorBook>, IAuthorBookRepository
    {
        public AuthorBookRepository(MyBookDbContext context) : base(context)
        {

        }
    }
}
