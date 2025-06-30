using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping;

public class InventoryMap : IEntityTypeConfiguration<Inventory>
{
    public void Configure(EntityTypeBuilder<Inventory> builder)
    {
        builder.HasKey(x => x.Inventory_id);
        builder.Property(x => x.Last_update).HasColumnType("timestamp")
                .HasDefaultValueSql("NOW()");
    }
}
