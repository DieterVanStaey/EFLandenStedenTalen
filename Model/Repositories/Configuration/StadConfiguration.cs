using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Model.Repositories.Configuration
{
    class StadConfiguration : IEntityTypeConfiguration<Stad>
    {
        public void Configure(EntityTypeBuilder<Stad> builder)
        {
            builder.ToTable("Steden");
            builder.HasKey(c => c.StadId);
            builder.Property(b => b.StadId)
                .ValueGeneratedOnAdd();

            builder.Property(b => b.Naam)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(b => b.Land)
                .WithMany(c => c.Steden)
                .HasForeignKey(b => b.ISOLandCode);
        }
    }
}
