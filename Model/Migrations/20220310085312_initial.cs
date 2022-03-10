using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Landen",
                columns: table => new
                {
                    ISOLandCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    NISLandCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Naam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AantalInwoners = table.Column<int>(type: "int", nullable: false),
                    Oppervlakte = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landen", x => x.ISOLandCode);
                });

            migrationBuilder.CreateTable(
                name: "Steden",
                columns: table => new
                {
                    StadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ISOLandCode = table.Column<string>(type: "nvarchar(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steden", x => x.StadId);
                    table.ForeignKey(
                        name: "FK_Steden_Landen_ISOLandCode",
                        column: x => x.ISOLandCode,
                        principalTable: "Landen",
                        principalColumn: "ISOLandCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Steden_ISOLandCode",
                table: "Steden",
                column: "ISOLandCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Steden");

            migrationBuilder.DropTable(
                name: "Landen");
        }
    }
}
