using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using netcoremvc.Models;

namespace netcoremvc.Data.Maps
{   
    public class AuthorMap: IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder){
            builder.ToTable("Authors");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Fname).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
            builder.Property(x => x.LName).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
        }
    }
}