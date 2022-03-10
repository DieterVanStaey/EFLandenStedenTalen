using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;


namespace Model.Repositories.Seeding
{
    class LandTaalSeeding : IEntityTypeConfiguration<LandTaal>
    {
        public void Configure(EntityTypeBuilder<LandTaal> builder)
        {
            builder.HasData
                (
                    new LandTaal { LandCode = "BE", TaalCode = "de"},
                    new LandTaal { LandCode = "DE", TaalCode = "de"},
                    new LandTaal { LandCode = "LU", TaalCode = "lu" },
                    new LandTaal { LandCode = "BE", TaalCode = "be" },
                    new LandTaal { LandCode = "FR", TaalCode = "fr" },
                    new LandTaal { LandCode = "LU", TaalCode = "fr" },
                    new LandTaal { LandCode = "BE", TaalCode = "nl" },
                    new LandTaal { LandCode = "NL", TaalCode = "nl" }
                );
        }
    }
}
