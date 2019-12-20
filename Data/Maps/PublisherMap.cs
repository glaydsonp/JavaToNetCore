using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using netcoremvc.Models;

namespace netcoremvc.Data.Maps
{   
    public class PublisherMap: IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder){
            builder.ToTable("Publishers");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(x => x.Url).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
        }
    }
}