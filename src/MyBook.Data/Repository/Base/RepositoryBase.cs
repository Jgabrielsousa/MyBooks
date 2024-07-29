using Microsoft.EntityFrameworkCore;
using MyBook.Data.Context;
using MyBook.Domain.Entities.Base;
using MyBook.Domain.Interfaces.Base;

namespace MyBook.Data.Repository.Base
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase<T>
    {

        protected readonly MyBookDbContext _contexto;
        protected DbSet<T> DbSet;

        public RepositoryBase(MyBookDbContext contexto)
        {
            _contexto = contexto;
            DbSet = this._contexto.Set<T>();
        }

        public virtual T Add(T entidade)
        {
            DbSet.Add(entidade);
            _contexto.SaveChanges();
            return entidade;
        }

        public virtual void Remove(T entidade)
        {
            DbSet.Remove(entidade);
            _contexto.SaveChanges();
        }

        public virtual T Find(int id) => DbSet.AsNoTracking().FirstOrDefault(x => x.Id == id);

        public virtual IEnumerable<T> GetAll() => DbSet.AsNoTracking().Select(c => c);

        public virtual void Update(T entidade)
        {
            DbSet.Update(entidade);
            _contexto.SaveChanges();
        }

        public virtual void Dispose()
        { }
    }
}
