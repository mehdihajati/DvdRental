using System;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping;

public class PaymentMap : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.HasKey(x => x.Payment_id);
        builder.Property(x => x.Amount)
               
               .IsRequired();
        builder.Property(x => x.Payment_Date)
               .HasColumnType("timestamp")
               .HasDefaultValueSql("NOW()");
    }
}
