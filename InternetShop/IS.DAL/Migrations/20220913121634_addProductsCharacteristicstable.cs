using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class addProductsCharacteristicstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "33caaa2d-7385-4168-a2bd-9a3daa0d8df2");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "77352779-5501-4fec-842d-52f9433e9329");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "77ab1fec-1372-4c02-85b6-0cd1aefcbe0c",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "c566bbbd-4c50-4f3a-b1df-03b3bf049979");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3baeb7d6-855d-4e31-8a20-f5b84089c47c", "c31876f1-195e-4c5d-aab2-eb1132bb3fb0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b46a643-fe29-432e-8baa-a8930b0489a3", "ba9e42f3-4d2a-41cc-94de-c5fa5dbaf944", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3baeb7d6-855d-4e31-8a20-f5b84089c47c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6b46a643-fe29-432e-8baa-a8930b0489a3");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "c566bbbd-4c50-4f3a-b1df-03b3bf049979",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "77ab1fec-1372-4c02-85b6-0cd1aefcbe0c");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "33caaa2d-7385-4168-a2bd-9a3daa0d8df2", "1d9e93b1-c6bd-4672-ade7-19d7c68cf73d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "77352779-5501-4fec-842d-52f9433e9329", "9123d6ef-5e5c-42a8-9735-472110f678f3", "User", "USER" });
        }
    }
}
