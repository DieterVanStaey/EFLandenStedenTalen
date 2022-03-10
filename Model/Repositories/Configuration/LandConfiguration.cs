using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Model.Repositories.Configuration
{
    class LandConfiguration : IEntityTypeConfiguration<Land>
    {
        public void Configure(EntityTypeBuilder<Land> builder)
        {
            builder.ToTable("Landen");
            builder.HasKey(c => c.ISOLandCode);
            builder.Property(b => b.ISOLandCode)
                .IsRequired()
                .HasMaxLength(2);

            builder.Property(b => b.NISLandCode)
                .HasMaxLength(3);

            builder.Property(b => b.Naam)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(b => b.AantalInwoners)
                .IsRequired();

            builder.Property(b => b.Oppervlakte)
                .HasColumnType("real")
                .IsRequired();
        }
    }
}
