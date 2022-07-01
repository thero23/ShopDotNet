using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class AddVirtualField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "59f0fee4-2783-41da-bc50-236677c600c3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a9c03211-0d79-4897-bdb8-76e124e4af02");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e4de8db-0470-4453-8a2e-a18d7e8c75a8", "27033a88-bf0b-4a78-b11d-3b0f59962721", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5a185af-fc02-4ffc-94d0-7ec2d69e9c32", "93adc22d-c112-4356-a2ad-a3a834658533", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2e4de8db-0470-4453-8a2e-a18d7e8c75a8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d5a185af-fc02-4ffc-94d0-7ec2d69e9c32");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59f0fee4-2783-41da-bc50-236677c600c3", "6b23c6a8-0531-4d6f-b3c5-5a4967c9de85", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a9c03211-0d79-4897-bdb8-76e124e4af02", "dca1a159-e256-488e-96f1-09dadccfc5d1", "User", "USER" });
        }
    }
}
