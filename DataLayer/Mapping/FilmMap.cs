using System;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping;

public class FilmMap : IEntityTypeConfiguration<Film>
{
    public void Configure(EntityTypeBuilder<Film> builder)
    {
        
        builder.HasKey(x => x.Film_id);
        builder.Property(x => x.Title).HasMaxLength(90).IsRequired();
        builder.Property(x => x.Description).IsRequired().HasMaxLength(1500);
        builder.Property(x => x.Release_year).IsRequired().HasColumnName("int");
        builder.Property(x => x.Rental_duration).IsRequired().HasColumnType("int");
        builder.Property(x => x.Rental_Rate);
        builder.Property(x => x.Length).IsRequired().HasColumnType("int");
        builder.Property(x => x.Replacement_Cost).IsRequired();
        builder.Property(x => x.Rating).IsRequired();
        builder.Property(x => x.Special_features).IsRequired(false);
        builder.Property(x => x.FullText).IsRequired().HasMaxLength(6000);
        builder.HasOne(x => x.Language)
                .WithMany(x => x.Films)
                .HasForeignKey(x => x.Language_id);
    }
}
