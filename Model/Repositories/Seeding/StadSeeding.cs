using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Model.Repositories.Seeding
{
    class StadSeeding : IEntityTypeConfiguration<Stad>
    {
        public void Configure(EntityTypeBuilder<Stad> builder)
        {
            builder.HasData
                (
                    new Stad { StadId = 1, Naam = "Brussel", ISOLandCode = "BE"},
                    new Stad { StadId = 2, Naam = "Antwerpen", ISOLandCode = "BE" },
                    new Stad { StadId = 3, Naam = "Luik", ISOLandCode = "BE" },
                    new Stad { StadId = 4, Naam = "Amsterdam", ISOLandCode = "NL" },
                    new Stad { StadId = 5, Naam = "Den Haag", ISOLandCode = "NL" },
                    new Stad { StadId = 6, Naam = "Rotterdam", ISOLandCode = "NL" },
                    new Stad { StadId = 7, Naam = "Berlijn", ISOLandCode = "DE" },
                    new Stad { StadId = 8, Naam = "Hamburg", ISOLandCode = "DE" },
                    new Stad { StadId = 9, Naam = "München", ISOLandCode = "DE" },
                    new Stad { StadId = 10, Naam = "Luxemburg", ISOLandCode = "LU" },
                    new Stad { StadId = 11, Naam = "Parijs", ISOLandCode = "FR" },
                    new Stad { StadId = 12, Naam = "Marseille", ISOLandCode = "FR" },
                    new Stad { StadId = 13, Naam = "Lyon", ISOLandCode = "FR" }
                );
        }
    }
}