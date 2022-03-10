using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;


namespace Model.Repositories.Configuration
{
    class LandTaalConfiguration : IEntityTypeConfiguration<LandTaal>
    {
        public void Configure(EntityTypeBuilder<LandTaal> builder)
        {
            builder.ToTable("LandTaal");
            builder.HasNoKey();
            builder.Property(c => c.LandCode).HasColumnName("LandCode");
            builder.Property(c => c.TaalCode).HasColumnName("TaalCode");
        }
    }
}
