using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class AddProductinOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "53a85246-8c5e-461e-97e9-0927cda956e0");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e9bddf30-be9c-46dc-b342-267b09f99b4a");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "898e80b9-607d-4d75-a677-9a8c53354518", "4adc4621-7ff5-4f2b-8e14-c17d631b21b4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba1f4d17-d0ca-45ea-97fa-4c113d197043", "36ff9aaf-ffae-4d27-876c-bb627867739d", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "898e80b9-607d-4d75-a677-9a8c53354518");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ba1f4d17-d0ca-45ea-97fa-4c113d197043");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "53a85246-8c5e-461e-97e9-0927cda956e0", "f9197a06-d20b-4b99-9b49-8e424f5fac43", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e9bddf30-be9c-46dc-b342-267b09f99b4a", "08967afd-c4f7-45b8-a601-dc1772aecf5f", "User", "USER" });
        }
    }
}
