using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping;

public class CategoryMap : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories_List");
        builder.HasKey(x => x.Category_id);
        builder.Property(x => x.Name)
        .IsRequired()
        .HasMaxLength(70);
        builder.Property(x => x.LastUpdate)
        .HasColumnType("timestamp")
        .HasDefaultValueSql("NOW()");
    }
}
