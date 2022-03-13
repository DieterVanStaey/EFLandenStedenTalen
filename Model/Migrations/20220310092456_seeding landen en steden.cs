using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class seedinglandenensteden : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Landen",
                columns: new[] { "ISOLandCode", "AantalInwoners", "NISLandCode", "Naam", "Oppervlakte" },
                values: new object[,]
                {
                    { "AT", 8754413, "105", "Ostenrijk", 83871f },
                    { "BE", 11500000, "150", "België", 30689f },
                    { "CH", 8236303, "127", "Zwitserland", 41285f },
                    { "DE", 80594017, "103", "Duitsland", 357022f },
                    { "DK", 5000000, "108", "Denemarken", 43000f },
                    { "ES", 48000000, "109", "Spanje", 506000f },
                    { "FR", 62800000, "111", "Frankrijk", 675000f },
                    { "GB", 64800000, "112", "Verenigd Koninkrijk", 242500f },
                    { "IT", 62100000, "128", "Italië", 300000f },
                    { "LU", 600000, "113", "Luxemburg", 2600f },
                    { "NL", 17400000, "129", "Nederland", 42000f },
                    { "NO", 5400000, "121", "Noorwegen", 385000f },
                    { "PL", 38500000, "139", "Polen", 312000f },
                    { "PT", 108000000, "123", "Portugal", 92000f },
                    { "SE", 10000000, "126", "Zweden", 450000f },
                    { "US", 326600000, "402", "Verenigde Staten", 9827000f }
                });

            migrationBuilder.InsertData(
                table: "Steden",
                columns: new[] { "StadId", "ISOLandCode", "Naam" },
                values: new object[,]
                {
                    { 1, "BE", "Brussel" },
                    { 2, "BE", "Antwerpen" },
                    { 3, "BE", "Luik" },
                    { 7, "DE", "Berlijn" },
                    { 8, "DE", "Hamburg" },
                    { 9, "DE", "München" },
                    { 11, "FR", "Parijs" },
                    { 12, "FR", "Marseille" },
                    { 13, "FR", "Lyon" },
                    { 10, "LU", "Luxemburg" },
                    { 4, "NL", "Amsterdam" },
                    { 5, "NL", "Den Haag" },
                    { 6, "NL", "Rotterdam" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "AT");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "CH");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "DK");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "ES");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "GB");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "IT");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "NO");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "PL");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "PT");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "SE");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "US");

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Steden",
                keyColumn: "StadId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "BE");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "DE");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "FR");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "LU");

            migrationBuilder.DeleteData(
                table: "Landen",
                keyColumn: "ISOLandCode",
                keyValue: "NL");
        }
    }
}
