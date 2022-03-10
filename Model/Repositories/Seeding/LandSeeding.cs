using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;

namespace Model.Repositories.Seeding
{
    class LandSeeding : IEntityTypeConfiguration<Land>
    {
        public void Configure(EntityTypeBuilder<Land> builder)
        {
            builder.HasData
                (
                    new Land { ISOLandCode = "AT", NISLandCode = "105", Naam = "Oostenrijk", AantalInwoners = 8754413, Oppervlakte = 83871.00f },
                    new Land { ISOLandCode = "BE", NISLandCode = "150", Naam = "België", AantalInwoners = 11500000, Oppervlakte = 30689.00f },
                    new Land { ISOLandCode = "CH", NISLandCode = "127", Naam = "Zwitserland", AantalInwoners = 8236303, Oppervlakte = 41285.00f },
                    new Land { ISOLandCode = "DE", NISLandCode = "103", Naam = "Duitsland", AantalInwoners = 80594017, Oppervlakte = 357022.00f },
                    new Land { ISOLandCode = "DK", NISLandCode = "108", Naam = "Denemarken", AantalInwoners = 5000000, Oppervlakte = 43000.00f },
                    new Land { ISOLandCode = "ES", NISLandCode = "109", Naam = "Spanje", AantalInwoners = 48000000, Oppervlakte = 506000.00f },
                    new Land { ISOLandCode = "FR", NISLandCode = "111", Naam = "Frankrijk", AantalInwoners = 62800000, Oppervlakte = 675000.00f },
                    new Land { ISOLandCode = "GB", NISLandCode = "112", Naam = "Verenigd Koninkrijk", AantalInwoners = 64800000, Oppervlakte = 242500.00f },
                    new Land { ISOLandCode = "IT", NISLandCode = "128", Naam = "Italië", AantalInwoners = 62100000, Oppervlakte = 300000.00f },
                    new Land { ISOLandCode = "LU", NISLandCode = "113", Naam = "Luxemburg", AantalInwoners = 600000, Oppervlakte = 2600.00f },
                    new Land { ISOLandCode = "NL", NISLandCode = "129", Naam = "Nederland", AantalInwoners = 17400000, Oppervlakte = 42000.00f },
                    new Land { ISOLandCode = "NO", NISLandCode = "121", Naam = "Noorwegen", AantalInwoners = 5400000, Oppervlakte = 385000.00f },
                    new Land { ISOLandCode = "PL", NISLandCode = "139", Naam = "Polen", AantalInwoners = 38500000, Oppervlakte = 312000.00f },
                    new Land { ISOLandCode = "PT", NISLandCode = "123", Naam = "Portugal", AantalInwoners = 108000000, Oppervlakte = 92000.00f },
                    new Land { ISOLandCode = "SE", NISLandCode = "126", Naam = "Zweden", AantalInwoners = 10000000, Oppervlakte = 450000.00f },
                    new Land { ISOLandCode = "US", NISLandCode = "402", Naam = "Verenigde Staten", AantalInwoners = 326600000, Oppervlakte = 9827000.00f }
                );
        }
    }
}
