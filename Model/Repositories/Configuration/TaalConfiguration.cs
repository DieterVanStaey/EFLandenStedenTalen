using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Model.Repositories.Configuration
{
    class TaalConfiguration : IEntityTypeConfiguration<Taal>
    {
        public void Configure(EntityTypeBuilder<Taal> builder)
        {
            builder.ToTable("Talen");
            builder.HasKey(c => c.ISOTaalCode);
            builder.Property(b => b.ISOTaalCode)
                .IsRequired()
                .HasMaxLength(2);
            builder.Property(b => b.NaamNL)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(b => b.NaamTaal)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .HasMany(p => p.Landen)
                .WithMany(p => p.Talen)
                .UsingEntity(j => j.HasData(
                    new { LandenISOLandCode = "BE", TalenISOTaalCode = "nl" },
                    new { LandenISOLandCode = "BE", TalenISOTaalCode = "fr" },
                    new { LandenISOLandCode = "BE", TalenISOTaalCode = "de" },
                    new { LandenISOLandCode = "DE", TalenISOTaalCode = "de" },
                    new { LandenISOLandCode = "FR", TalenISOTaalCode = "fr" }));
        }
    }
}