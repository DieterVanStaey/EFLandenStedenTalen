﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model.Repositories;

namespace Model.Migrations
{
    [DbContext(typeof(EFLandenStedenTalenContext))]
    [Migration("20220310103748_talen toegevoegd")]
    partial class talentoegevoegd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LandTaal", b =>
                {
                    b.Property<string>("TalenISOLandCode")
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("TalenISOTaalCode")
                        .HasColumnType("nvarchar(2)");

                    b.HasKey("TalenISOLandCode", "TalenISOTaalCode");

                    b.HasIndex("TalenISOTaalCode");

                    b.ToTable("LandTaal");
                });

            modelBuilder.Entity("Model.Entities.Land", b =>
                {
                    b.Property<string>("ISOLandCode")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<int>("AantalInwoners")
                        .HasColumnType("int");

                    b.Property<string>("NISLandCode")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("Oppervlakte")
                        .HasColumnType("real");

                    b.HasKey("ISOLandCode");

                    b.ToTable("Landen");

                    b.HasData(
                        new
                        {
                            ISOLandCode = "AT",
                            AantalInwoners = 8754413,
                            NISLandCode = "105",
                            Naam = "Oostenrijk",
                            Oppervlakte = 83871f
                        },
                        new
                        {
                            ISOLandCode = "BE",
                            AantalInwoners = 11500000,
                            NISLandCode = "150",
                            Naam = "België",
                            Oppervlakte = 30689f
                        },
                        new
                        {
                            ISOLandCode = "CH",
                            AantalInwoners = 8236303,
                            NISLandCode = "127",
                            Naam = "Zwitserland",
                            Oppervlakte = 41285f
                        },
                        new
                        {
                            ISOLandCode = "DE",
                            AantalInwoners = 80594017,
                            NISLandCode = "103",
                            Naam = "Duitsland",
                            Oppervlakte = 357022f
                        },
                        new
                        {
                            ISOLandCode = "DK",
                            AantalInwoners = 5000000,
                            NISLandCode = "108",
                            Naam = "Denemarken",
                            Oppervlakte = 43000f
                        },
                        new
                        {
                            ISOLandCode = "ES",
                            AantalInwoners = 48000000,
                            NISLandCode = "109",
                            Naam = "Spanje",
                            Oppervlakte = 506000f
                        },
                        new
                        {
                            ISOLandCode = "FR",
                            AantalInwoners = 62800000,
                            NISLandCode = "111",
                            Naam = "Frankrijk",
                            Oppervlakte = 675000f
                        },
                        new
                        {
                            ISOLandCode = "GB",
                            AantalInwoners = 64800000,
                            NISLandCode = "112",
                            Naam = "Verenigd Koninkrijk",
                            Oppervlakte = 242500f
                        },
                        new
                        {
                            ISOLandCode = "IT",
                            AantalInwoners = 62100000,
                            NISLandCode = "128",
                            Naam = "Italië",
                            Oppervlakte = 300000f
                        },
                        new
                        {
                            ISOLandCode = "LU",
                            AantalInwoners = 600000,
                            NISLandCode = "113",
                            Naam = "Luxemburg",
                            Oppervlakte = 2600f
                        },
                        new
                        {
                            ISOLandCode = "NL",
                            AantalInwoners = 17400000,
                            NISLandCode = "129",
                            Naam = "Nederland",
                            Oppervlakte = 42000f
                        },
                        new
                        {
                            ISOLandCode = "NO",
                            AantalInwoners = 5400000,
                            NISLandCode = "121",
                            Naam = "Noorwegen",
                            Oppervlakte = 385000f
                        },
                        new
                        {
                            ISOLandCode = "PL",
                            AantalInwoners = 38500000,
                            NISLandCode = "139",
                            Naam = "Polen",
                            Oppervlakte = 312000f
                        },
                        new
                        {
                            ISOLandCode = "PT",
                            AantalInwoners = 108000000,
                            NISLandCode = "123",
                            Naam = "Portugal",
                            Oppervlakte = 92000f
                        },
                        new
                        {
                            ISOLandCode = "SE",
                            AantalInwoners = 10000000,
                            NISLandCode = "126",
                            Naam = "Zweden",
                            Oppervlakte = 450000f
                        },
                        new
                        {
                            ISOLandCode = "US",
                            AantalInwoners = 326600000,
                            NISLandCode = "402",
                            Naam = "Verenigde Staten",
                            Oppervlakte = 9827000f
                        });
                });

            modelBuilder.Entity("Model.Entities.Stad", b =>
                {
                    b.Property<int>("StadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ISOLandCode")
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StadId");

                    b.HasIndex("ISOLandCode");

                    b.ToTable("Steden");

                    b.HasData(
                        new
                        {
                            StadId = 1,
                            ISOLandCode = "BE",
                            Naam = "Brussel"
                        },
                        new
                        {
                            StadId = 2,
                            ISOLandCode = "BE",
                            Naam = "Antwerpen"
                        },
                        new
                        {
                            StadId = 3,
                            ISOLandCode = "BE",
                            Naam = "Luik"
                        },
                        new
                        {
                            StadId = 4,
                            ISOLandCode = "NL",
                            Naam = "Amsterdam"
                        },
                        new
                        {
                            StadId = 5,
                            ISOLandCode = "NL",
                            Naam = "Den Haag"
                        },
                        new
                        {
                            StadId = 6,
                            ISOLandCode = "NL",
                            Naam = "Rotterdam"
                        },
                        new
                        {
                            StadId = 7,
                            ISOLandCode = "DE",
                            Naam = "Berlijn"
                        },
                        new
                        {
                            StadId = 8,
                            ISOLandCode = "DE",
                            Naam = "Hamburg"
                        },
                        new
                        {
                            StadId = 9,
                            ISOLandCode = "DE",
                            Naam = "München"
                        },
                        new
                        {
                            StadId = 10,
                            ISOLandCode = "LU",
                            Naam = "Luxemburg"
                        },
                        new
                        {
                            StadId = 11,
                            ISOLandCode = "FR",
                            Naam = "Parijs"
                        },
                        new
                        {
                            StadId = 12,
                            ISOLandCode = "FR",
                            Naam = "Marseille"
                        },
                        new
                        {
                            StadId = 13,
                            ISOLandCode = "FR",
                            Naam = "Lyon"
                        });
                });

            modelBuilder.Entity("Model.Entities.Taal", b =>
                {
                    b.Property<string>("ISOTaalCode")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("NaamNL")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NaamTaal")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ISOTaalCode");

                    b.ToTable("Talen");

                    b.HasData(
                        new
                        {
                            ISOTaalCode = "bg",
                            NaamNL = "Bulgaars",
                            NaamTaal = "български"
                        },
                        new
                        {
                            ISOTaalCode = "cs",
                            NaamNL = "Tsjechisch",
                            NaamTaal = "čeština"
                        },
                        new
                        {
                            ISOTaalCode = "da",
                            NaamNL = "Deens",
                            NaamTaal = "dansk"
                        },
                        new
                        {
                            ISOTaalCode = "de",
                            NaamNL = "Duits",
                            NaamTaal = "Deutsch"
                        },
                        new
                        {
                            ISOTaalCode = "el",
                            NaamNL = "Grieks",
                            NaamTaal = "ελληνικά"
                        },
                        new
                        {
                            ISOTaalCode = "en",
                            NaamNL = "Engels",
                            NaamTaal = "English"
                        },
                        new
                        {
                            ISOTaalCode = "es",
                            NaamNL = "Spaans",
                            NaamTaal = "español"
                        },
                        new
                        {
                            ISOTaalCode = "et",
                            NaamNL = "Ests",
                            NaamTaal = "eesti keel"
                        },
                        new
                        {
                            ISOTaalCode = "fi",
                            NaamNL = "Fins",
                            NaamTaal = "suomi"
                        },
                        new
                        {
                            ISOTaalCode = "fr",
                            NaamNL = "Frans",
                            NaamTaal = "français"
                        },
                        new
                        {
                            ISOTaalCode = "ga",
                            NaamNL = "Iers",
                            NaamTaal = "Gaeilge"
                        },
                        new
                        {
                            ISOTaalCode = "hu",
                            NaamNL = "Hongaars",
                            NaamTaal = "magyar"
                        },
                        new
                        {
                            ISOTaalCode = "it",
                            NaamNL = "Italiaans",
                            NaamTaal = "italiano"
                        },
                        new
                        {
                            ISOTaalCode = "lt",
                            NaamNL = "Litouws",
                            NaamTaal = "lietuvių kalba"
                        },
                        new
                        {
                            ISOTaalCode = "lv",
                            NaamNL = "Lets",
                            NaamTaal = "latviešu valoda"
                        },
                        new
                        {
                            ISOTaalCode = "mt",
                            NaamNL = "Maltees",
                            NaamTaal = "malti"
                        },
                        new
                        {
                            ISOTaalCode = "nl",
                            NaamNL = "Nederlands",
                            NaamTaal = "Nederlands"
                        },
                        new
                        {
                            ISOTaalCode = "pl",
                            NaamNL = "Pools",
                            NaamTaal = "polski"
                        },
                        new
                        {
                            ISOTaalCode = "pt",
                            NaamNL = "Portugees",
                            NaamTaal = "português"
                        },
                        new
                        {
                            ISOTaalCode = "ro",
                            NaamNL = "Roemeens",
                            NaamTaal = "română"
                        },
                        new
                        {
                            ISOTaalCode = "sk",
                            NaamNL = "Slovaaks",
                            NaamTaal = "slovenčina"
                        },
                        new
                        {
                            ISOTaalCode = "sl",
                            NaamNL = "Sloveens",
                            NaamTaal = "slovenščina"
                        },
                        new
                        {
                            ISOTaalCode = "sv",
                            NaamNL = "Zweeds",
                            NaamTaal = "svenska"
                        });
                });

            modelBuilder.Entity("LandTaal", b =>
                {
                    b.HasOne("Model.Entities.Land", null)
                        .WithMany()
                        .HasForeignKey("TalenISOLandCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Taal", null)
                        .WithMany()
                        .HasForeignKey("TalenISOTaalCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Entities.Stad", b =>
                {
                    b.HasOne("Model.Entities.Land", "Land")
                        .WithMany("Steden")
                        .HasForeignKey("ISOLandCode");

                    b.Navigation("Land");
                });

            modelBuilder.Entity("Model.Entities.Land", b =>
                {
                    b.Navigation("Steden");
                });
#pragma warning restore 612, 618
        }
    }
}
