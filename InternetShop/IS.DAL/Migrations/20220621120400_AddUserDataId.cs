using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class AddUserDataId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "18809de1-15ed-4208-9d88-5f4edb07b0b4");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "688e7e81-478a-47ea-86e9-430dbba5f8b4");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "62b7aee3-24a9-485f-904c-e5e54ccbf9c6", "fec060d9-ad9d-4df0-89e3-76cf2e124ba0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "888dc629-ba12-45a1-b425-09bd09e3944a", "f971d7a3-8c8a-46f2-aaa5-a8596377fe18", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "18809de1-15ed-4208-9d88-5f4edb07b0b4", "83724447-1096-4c04-9eba-d6d5f4239d83", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "688e7e81-478a-47ea-86e9-430dbba5f8b4", "6de5a7e8-938c-494e-92fc-39bb77216aed", "User", "USER" });
        }
    }
}
