using MyBook.Data.Context;
using MyBook.Data.Repository.Base;
using MyBook.Domain.Entities;
using MyBook.Domain.Entities.ManyToMany;
using MyBook.Domain.Interfaces.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook.Data.Repository
{
   

    public class SubjectBookRepository : RepositoryBase<SubjectBook>, ISubjectBookRepository
    {
        public SubjectBookRepository(MyBookDbContext context) : base(context)
        {

        }
    }
}
