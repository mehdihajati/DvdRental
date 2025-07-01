using System;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping;

public class StaffMap : IEntityTypeConfiguration<Staff>
{
    public void Configure(EntityTypeBuilder<Staff> builder)
    {
        builder.HasKey(x => x.Staff_id);
        builder.Property(x => x.First_name).HasMaxLength(60).IsRequired();
        builder.Property(x => x.Last_name).HasMaxLength(80).IsRequired(true);
        builder.Property(x => x.Email).HasMaxLength(30).IsRequired(true);
        builder.Property(x => x.UserName).HasMaxLength(30).IsRequired(true);
        builder.Property(x => x.Password).HasMaxLength(30).IsRequired(true);
        builder.Property(x => x.Picture).IsRequired(false);
        builder.HasMany(x => x.Rentals)
                .WithOne(x => x.Staff)
                .HasForeignKey(x => x.Staff_id);
        builder.HasMany(x => x.Payments)
                .WithOne(x => x.Staff)
                .HasForeignKey(x => x.Staff_id);
    }
}
