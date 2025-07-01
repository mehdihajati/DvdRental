using System;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping;

public class StoreMap : IEntityTypeConfiguration<Store>
{
        public void Configure(EntityTypeBuilder<Store> builder)
        {
                builder.HasKey(x => x.Store_id);
                builder.Property(x => x.Last_update)
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("NOW()");
                builder.HasMany(x => x.Inventories)
                        .WithOne(x => x.Store)
                        .HasForeignKey(x => x.Store_id);
                builder.HasMany(x => x.Customers)
                        .WithOne(x => x.Store)
                    .HasForeignKey(x => x.Store_id);
                builder.HasMany(x => x.Staffs)
                        .WithOne(x => x.StoreManaged)
                    .HasForeignKey(x => x.Store_id);
    }
}
