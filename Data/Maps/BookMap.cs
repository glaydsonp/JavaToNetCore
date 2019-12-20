using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using netcoremvc.Models;

namespace netcoremvc.Data.Maps
{   
    public class BookMap: IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder){
            builder.ToTable("Books");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Isbn).IsRequired().HasMaxLength(14).HasColumnType("varchar(14)");
            builder.Property(x => x.Title).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
            builder.Property(x => x.Price).IsRequired().HasColumnType("money");
            builder.HasOne(x => x.Publisher).WithMany(x => x.Books);
        }
    }
}