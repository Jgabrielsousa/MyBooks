using Microsoft.EntityFrameworkCore;
using MyBook.Domain.Entities;
using MyBook.Domain.Entities.ManyToMany;
using System.Reflection;

namespace MyBook.Data.Context
{
    public class MyBookDbContext : DbContext
    {
        public MyBookDbContext(DbContextOptions opt):base(opt)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        
        public virtual DbSet<AuthorEntity> Authors { get; set; }
        public virtual DbSet<BookEntity> Books { get; set; }
        public virtual DbSet<SubjectEntity> Subjects { get; set; }
        public virtual DbSet<SaleTypeEntity> SalesType { get; set; }

        //many to many 
        public virtual DbSet<AuthorBook> AuthorBook { get; set; }
        public virtual DbSet<SaleTypeBook> SaleTypeBook { get; set; }
        public virtual DbSet<SubjectBook> SubjectBook { get; set; }
    }
}
