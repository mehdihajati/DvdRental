using System;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Mapping;

public class ActorMap : IEntityTypeConfiguration<Actor>
{
    public void Configure(EntityTypeBuilder<Actor> builder)
    {
        builder.ToTable("actors");
        builder.HasKey(x => x.Actor_id);
        builder.Property(x => x.First_name).HasMaxLength(70).IsRequired();
    }
}
