using System;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping;

public class CountryMap : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.ToTable("Countries");
        builder.HasKey(x => x.Country_id);
        builder.Property(x => x.Country_Name).IsRequired().HasMaxLength(75);
        builder.Property(x => x.Last_update).HasColumnType("timestamp").HasDefaultValueSql("NOW()");
        builder.HasMany(x => x.Cities)
                .WithOne(x => x.Country)
                .HasForeignKey(x => x.Country_id);    

    }
}
