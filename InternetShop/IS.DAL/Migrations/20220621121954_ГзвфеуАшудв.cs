using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class ГзвфеуАшудв : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "62b7aee3-24a9-485f-904c-e5e54ccbf9c6");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "888dc629-ba12-45a1-b425-09bd09e3944a");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "38153bf3-f7f3-426a-8a06-d7c00c32d49d", "28d86be3-5b8e-4699-96cf-080829f3a7f8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6a0b9f9a-0847-4807-9329-c551ac58d5a9", "a0f59ab7-a5d5-4a37-9dc4-ff79a006f6f8", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "38153bf3-f7f3-426a-8a06-d7c00c32d49d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6a0b9f9a-0847-4807-9329-c551ac58d5a9");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "62b7aee3-24a9-485f-904c-e5e54ccbf9c6", "fec060d9-ad9d-4df0-89e3-76cf2e124ba0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "888dc629-ba12-45a1-b425-09bd09e3944a", "f971d7a3-8c8a-46f2-aaa5-a8596377fe18", "User", "USER" });
        }
    }
}
