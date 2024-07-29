using Microsoft.EntityFrameworkCore;
using MyBook.Data.Context;
using MyBook.Data.Repository.Base;
using MyBook.Domain.Entities;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Data.Repository
{
    public class AuthorRepository : RepositoryBase<AuthorEntity>, IAuthorRepository
    {
        public AuthorRepository(MyBookDbContext context): base(context)
        {
                
        }

        
    }
}
