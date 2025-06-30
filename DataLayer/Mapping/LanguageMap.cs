using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping;

public class LanguageMap : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.HasKey(x => x.Language_id);
        builder.Property(x => x.Name).IsRequired(true).HasMaxLength(65);
        builder.Property(x => x.LastUpdate).HasColumnType("timestamp")
                .HasDefaultValueSql("NOW()");
        builder.HasMany(x => x.Films)
                .WithOne(x => x.Language)
                .HasForeignKey(x => x.Language_id);
    }
}
