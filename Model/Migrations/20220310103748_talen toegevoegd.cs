using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class talentoegevoegd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Talen",
                columns: table => new
                {
                    ISOTaalCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    NaamNL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NaamTaal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talen", x => x.ISOTaalCode);
                });

            migrationBuilder.CreateTable(
                name: "LandTaal",
                columns: table => new
                {
                    TalenISOLandCode = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    TalenISOTaalCode = table.Column<string>(type: "nvarchar(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandTaal", x => new { x.TalenISOLandCode, x.TalenISOTaalCode });
                    table.ForeignKey(
                        name: "FK_LandTaal_Landen_TalenISOLandCode",
                        column: x => x.TalenISOLandCode,
                        principalTable: "Landen",
                        principalColumn: "ISOLandCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LandTaal_Talen_TalenISOTaalCode",
                        column: x => x.TalenISOTaalCode,
                        principalTable: "Talen",
                        principalColumn: "ISOTaalCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Talen",
                columns: new[] { "ISOTaalCode", "NaamNL", "NaamTaal" },
                values: new object[,]
                {
                    { "bg", "Bulgaars", "български" },
                    { "sk", "Slovaaks", "slovenčina" },
                    { "ro", "Roemeens", "română" },
                    { "pt", "Portugees", "português" },
                    { "pl", "Pools", "polski" },
                    { "nl", "Nederlands", "Nederlands" },
                    { "mt", "Maltees", "malti" },
                    { "lv", "Lets", "latviešu valoda" },
                    { "lt", "Litouws", "lietuvių kalba" },
                    { "it", "Italiaans", "italiano" },
                    { "sl", "Sloveens", "slovenščina" },
                    { "hu", "Hongaars", "magyar" },
                    { "fr", "Frans", "français" },
                    { "fi", "Fins", "suomi" },
                    { "et", "Ests", "eesti keel" },
                    { "es", "Spaans", "español" },
                    { "en", "Engels", "English" },
                    { "el", "Grieks", "ελληνικά" },
                    { "de", "Duits", "Deutsch" },
                    { "da", "Deens", "dansk" },
                    { "cs", "Tsjechisch", "čeština" },
                    { "ga", "Iers", "Gaeilge" },
                    { "sv", "Zweeds", "svenska" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LandTaal_TalenISOTaalCode",
                table: "LandTaal",
                column: "TalenISOTaalCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LandTaal");

            migrationBuilder.DropTable(
                name: "Talen");
        }
    }
}
