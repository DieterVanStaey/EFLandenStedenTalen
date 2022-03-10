using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;


namespace Model.Repositories.Seeding
{
    class TaalSeeding : IEntityTypeConfiguration<Taal>
    {
        public void Configure(EntityTypeBuilder<Taal> builder)
        {
            builder.HasData
                (
                    new Taal { ISOTaalCode = "bg", NaamNL = "Bulgaars", NaamTaal = "български" },
                    new Taal { ISOTaalCode = "cs", NaamNL = "Tsjechisch", NaamTaal = "čeština" },
                    new Taal { ISOTaalCode = "da", NaamNL = "Deens", NaamTaal = "dansk" },
                    new Taal { ISOTaalCode = "de", NaamNL = "Duits", NaamTaal = "Deutsch" },
                    new Taal { ISOTaalCode = "el", NaamNL = "Grieks", NaamTaal = "ελληνικά" },
                    new Taal { ISOTaalCode = "en", NaamNL = "Engels", NaamTaal = "English" },
                    new Taal { ISOTaalCode = "es", NaamNL = "Spaans", NaamTaal = "español" },
                    new Taal { ISOTaalCode = "et", NaamNL = "Ests", NaamTaal = "eesti keel" },
                    new Taal { ISOTaalCode = "fi", NaamNL = "Fins", NaamTaal = "suomi" },
                    new Taal { ISOTaalCode = "fr", NaamNL = "Frans", NaamTaal = "français" },
                    new Taal { ISOTaalCode = "ga", NaamNL = "Iers", NaamTaal = "Gaeilge" },
                    new Taal { ISOTaalCode = "hu", NaamNL = "Hongaars", NaamTaal = "magyar" },
                    new Taal { ISOTaalCode = "it", NaamNL = "Italiaans", NaamTaal = "italiano" },
                    new Taal { ISOTaalCode = "lt", NaamNL = "Litouws", NaamTaal = "lietuvių kalba" },
                    new Taal { ISOTaalCode = "lv", NaamNL = "Lets", NaamTaal = "latviešu valoda" },
                    new Taal { ISOTaalCode = "mt", NaamNL = "Maltees", NaamTaal = "malti" },
                    new Taal { ISOTaalCode = "nl", NaamNL = "Nederlands", NaamTaal = "Nederlands" },
                    new Taal { ISOTaalCode = "pl", NaamNL = "Pools", NaamTaal = "polski" },
                    new Taal { ISOTaalCode = "pt", NaamNL = "Portugees", NaamTaal = "português" },
                    new Taal { ISOTaalCode = "ro", NaamNL = "Roemeens", NaamTaal = "română" },
                    new Taal { ISOTaalCode = "sk", NaamNL = "Slovaaks", NaamTaal = "slovenčina" },
                    new Taal { ISOTaalCode = "sl", NaamNL = "Sloveens", NaamTaal = "slovenščina" },
                    new Taal { ISOTaalCode = "sv", NaamNL = "Zweeds", NaamTaal = "svenska" }
                );
        }
    }
}
