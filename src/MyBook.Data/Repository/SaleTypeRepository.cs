using MyBook.Data.Context;
using MyBook.Data.Repository.Base;
using MyBook.Domain.Entities;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Data.Repository
{
    public class SaleTypeRepository : RepositoryBase<SaleTypeEntity>, ISaleTypeRepository
    {
        public SaleTypeRepository(MyBookDbContext context): base(context)
        {
                
        }
    }
}
