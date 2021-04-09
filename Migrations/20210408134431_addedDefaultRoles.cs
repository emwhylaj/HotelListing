using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class addedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e1227bfe-a8c2-439e-bd44-69d4f9be6df6", "07def7e1-2de3-4134-82c2-9f85c8776451", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "825a80e0-f199-410a-b216-23824879821d", "52cfd5b3-f17d-43b7-9948-c3b6f3364af8", "Administration", "ADMINISTRATION" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "825a80e0-f199-410a-b216-23824879821d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1227bfe-a8c2-439e-bd44-69d4f9be6df6");
        }
    }
}
