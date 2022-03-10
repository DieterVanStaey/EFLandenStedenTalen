using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "LandenISOLandCode", "TalenISOTaalCode" },
                keyValues: new object[] { "BE", "de" });

            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "LandenISOLandCode", "TalenISOTaalCode" },
                keyValues: new object[] { "BE", "fr" });

            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "LandenISOLandCode", "TalenISOTaalCode" },
                keyValues: new object[] { "BE", "nl" });

            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "LandenISOLandCode", "TalenISOTaalCode" },
                keyValues: new object[] { "DE", "de" });

            migrationBuilder.DeleteData(
                table: "LandTaal",
                keyColumns: new[] { "LandenISOLandCode", "TalenISOTaalCode" },
                keyValues: new object[] { "FR", "fr" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LandTaal",
                columns: new[] { "LandenISOLandCode", "TalenISOTaalCode" },
                values: new object[,]
                {
                    { "BE", "nl" },
                    { "BE", "fr" },
                    { "BE", "de" },
                    { "DE", "de" },
                    { "FR", "fr" }
                });
        }
    }
}
