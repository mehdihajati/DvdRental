using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping;

public class CityMap : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.ToTable("city");
        builder.HasKey(x => x.City_id);
        builder.Property(x => x.City_name)
        .HasMaxLength(50)
            .IsRequired();
        builder.Property(x => x.Last_update).HasColumnType("timestamp")
            .HasDefaultValueSql("NOW()");
        
    }
}
