using System;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping;

public class AddressMap : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("addresses");
        builder.HasKey(x => x.Address_id);
        builder.Property(x => x.Address_1).HasMaxLength(50).IsRequired();
        builder.Property(x => x.Address_2).HasMaxLength(50);
        builder.Property(x => x.District).HasMaxLength(200).IsRequired();
        builder.Property(x => x.Postal_code).HasMaxLength(10);
        builder.Property(x => x.Phone).HasMaxLength(20).IsRequired();
        builder.Property(x => x.Last_update).HasColumnType("timestamp").HasDefaultValueSql("NOW()");
        builder.HasMany(x => x.Customer)
                .WithOne(x => x.Address)
                .HasForeignKey(x => x.Address_id);
        builder.HasMany(x => x.Staffs)
                .WithOne(x => x.Address)
                .HasForeignKey(x => x.Address_id);
    }
}
