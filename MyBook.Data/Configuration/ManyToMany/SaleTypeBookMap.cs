using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBook.Domain.Entities.ManyToMany;

namespace MyBook.Data.Configuration.ManyToMany
{
    public class SaleTypeBookMap : IEntityTypeConfiguration<SaleTypeBook>
    {
        public void Configure(EntityTypeBuilder<SaleTypeBook> builder)
        {
            builder.HasKey(c => new { c.Id, c.SaleTypeId, c.BookId });

            builder
            .HasOne(c => c.SaleType)
            .WithMany(s => s.SaleTypeBook)
            .HasForeignKey(f => f.SaleTypeId);

            builder
            .HasOne(c => c.Book)
            .WithMany(s => s.SaleTypeBook)
            .HasForeignKey(f => f.BookId);
        }
    }
}
