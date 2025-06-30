using System;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping;

public class FilmCategoryMap : IEntityTypeConfiguration<Film_category>
{
    public void Configure(EntityTypeBuilder<Film_category> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.LastUpdate).HasColumnType("timestamp")
                .HasDefaultValueSql("NOW()");
    }
}