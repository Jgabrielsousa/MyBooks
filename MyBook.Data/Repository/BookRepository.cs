using Microsoft.EntityFrameworkCore;
using MyBook.Data.Context;
using MyBook.Data.Repository.Base;
using MyBook.Domain.Entities;
using MyBook.Domain.Interfaces.IRepository;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MyBook.Data.Repository
{
    public class BookRepository : RepositoryBase<BookEntity>, IBookRepository
    {
        public BookRepository(MyBookDbContext context): base(context)
        {
                
        }

        public override IEnumerable<BookEntity> GetAll()
        {
            return DbSet.AsNoTracking().Select(c => c)
            .Include(c => c.AuthorBook)
            //.ThenInclude(c => c.Author)
            .Include(c => c.SubjectBook)
            .ThenInclude(c => c.Subject)
            .Include(c=>c.SaleTypeBook)
            .ThenInclude(c=>c.SaleType)
                    .ToList();

   


       

        }
    }
}
