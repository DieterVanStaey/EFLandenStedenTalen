// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model.Repositories;

namespace Model.Migrations
{
    [DbContext(typeof(EFLandenStedenTalenContext))]
    [Migration("20220310085312_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
