using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBook.Data.Configuration.Base;
using MyBook.Domain.Entities.ManyToMany;

namespace MyBook.Data.Configuration.ManyToMany
{
    public class SubjectBookMap : BaseMap<SubjectBook>,  IEntityTypeConfiguration<SubjectBook>
    {
        public void Configure(EntityTypeBuilder<SubjectBook> builder)
        {
           // builder.HasKey(c => new { c.Id, c.SubjectId, c.BookId });

            builder
           .HasOne(c => c.Subject)
           .WithMany(s => s.SubjectBook)
           .HasForeignKey(f => f.SubjectId);

            builder
            .HasOne(c => c.Book)
            .WithMany(s => s.SubjectBook)
            .HasForeignKey(f => f.BookId);
        }
    }
}
