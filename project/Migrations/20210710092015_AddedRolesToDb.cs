using Microsoft.EntityFrameworkCore.Migrations;

namespace project.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "037f64f0-a188-445b-b457-922eaab86138", "1d61d3cc-a8b9-40d8-ae1f-1be9de5c0fdf", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "418a802a-f19b-46da-91d4-7393d709f8a2", "263c8493-de95-4365-a259-4dbd7c5cfc60", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "037f64f0-a188-445b-b457-922eaab86138");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "418a802a-f19b-46da-91d4-7393d709f8a2");
        }
    }
}
