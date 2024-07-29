using MyBook.Data.Context;
using MyBook.Data.Repository.Base;
using MyBook.Domain.Entities.ManyToMany;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Data.Repository
{

    public class SaleTypeBookRepository : RepositoryBase<SaleTypeBook>, ISaleTypeBookRepository
    {
        public SaleTypeBookRepository(MyBookDbContext context) : base(context)
        {

        }
    }
}
