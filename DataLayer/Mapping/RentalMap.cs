using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping;

public class RentalMap : IEntityTypeConfiguration<Rental>
{
    public void Configure(EntityTypeBuilder<Rental> builder)
    {
        builder.HasKey(x => x.Rental_id);
        builder.Property(x => x.Rental_Date)
                .HasColumnType("timestamp")
                .HasDefaultValueSql("NOW()");
    }
}
