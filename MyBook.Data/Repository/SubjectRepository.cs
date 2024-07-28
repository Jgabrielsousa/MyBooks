using MyBook.Data.Context;
using MyBook.Data.Repository.Base;
using MyBook.Domain.Entities;
using MyBook.Domain.Interfaces.IRepository;

namespace MyBook.Data.Repository
{
    public class SubjectRepository : RepositoryBase<SubjectEntity>, ISubjectRepository
    {
        public SubjectRepository(MyBookDbContext context): base(context)
        {
                
        }
    }
}
