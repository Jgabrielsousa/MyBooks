using MyBook.Domain.Entities;
using MyBook.Domain.Interfaces.Base;

namespace MyBook.Domain.Interfaces.IRepository
{
    public  interface IBookRepository : IRepositoryBase<BookEntity>
    {

    }
}
