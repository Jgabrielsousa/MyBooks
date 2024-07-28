﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBook.Domain.Entities.ManyToMany;

namespace MyBook.Data.Configuration.ManyToMany
{
    public class AuthorBookMap : IEntityTypeConfiguration<AuthorBook>
    {
        public void Configure(EntityTypeBuilder<AuthorBook> builder)
        {
            builder.HasKey(c => new { c.Id, c.AuthorId, c.BookId });

            builder
           .HasOne(c => c.Author)
           .WithMany(s => s.AuthorBook)
           .HasForeignKey(f => f.AuthorId);

            builder
            .HasOne(c => c.Book)
            .WithMany(s => s.AuthorBook)
            .HasForeignKey(f => f.BookId);
        }
    }
}
