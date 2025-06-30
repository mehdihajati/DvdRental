using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace DataLayer.Mapping;
public class FilmActorMap : IEntityTypeConfiguration<Film_actor>
{
    public void Configure(EntityTypeBuilder<Film_actor> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Last_update)
        .HasColumnType("timestamp")
        .HasDefaultValueSql("NOW()");
    }
}
