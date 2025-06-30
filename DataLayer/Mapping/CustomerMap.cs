using System;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping;

public class CustomerMap : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("customer");
        builder.HasKey(x => x.Customer_id);
        builder.Property(x => x.First_name)
            .HasMaxLength(45)
            .IsRequired();
        builder.Property(x => x.Last_name)
            .HasMaxLength(45)
            .IsRequired();
        builder.Property(x => x.Email).HasMaxLength(60).IsRequired();
        builder.Property(x => x.Activebool)
            .HasDefaultValue(true);
        builder.Property(x => x.Create_date)
            .HasColumnType("timestamp").HasDefaultValueSql("NOW()");
        builder.Property(x => x.Last_update)
            .HasColumnType("timestamp")
            .HasDefaultValueSql("NOW()");
    }
}
