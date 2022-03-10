using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class veelveelassociatie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LandTaal_Landen_TalenISOLandCode",
                table: "LandTaal");

            migrationBuilder.RenameColumn(
                name: "TalenISOLandCode",
                table: "LandTaal",
                newName: "LandenISOLandCode");

            migrationBuilder.AddForeignKey(
                name: "FK_LandTaal_Landen_LandenISOLandCode",
                table: "LandTaal",
                column: "LandenISOLandCode",
                principalTable: "Landen",
                principalColumn: "ISOLandCode",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LandTaal_Landen_LandenISOLandCode",
                table: "LandTaal");

            migrationBuilder.RenameColumn(
                name: "LandenISOLandCode",
                table: "LandTaal",
                newName: "TalenISOLandCode");

            migrationBuilder.AddForeignKey(
                name: "FK_LandTaal_Landen_TalenISOLandCode",
                table: "LandTaal",
                column: "TalenISOLandCode",
                principalTable: "Landen",
                principalColumn: "ISOLandCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
