using MyBook.Data.Context;
using MyBook.Data.Repository.Base;
using MyBook.Domain.Entities;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Data.Repository
{
    public class BookRepository : RepositoryBase<BookEntity>, IBookRepository
    {
        public BookRepository(MyBookDbContext context): base(context)
        {
                
        }
    }
}
