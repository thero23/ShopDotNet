using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class addIdToProductsCharacteristics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                defaultValue: "d99e3edf-f105-444b-827b-02284e7bfee0",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "77ab1fec-1372-4c02-85b6-0cd1aefcbe0c");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "15840fd6-a405-4400-85a3-24404a33d5e0", "df0109b0-8c7c-43b7-b050-a5f0e3266d27", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fd765c1d-85b7-4618-9bb1-0fb2540851bf", "684dbaf3-7a10-4240-a5b8-781761d94e67", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "15840fd6-a405-4400-85a3-24404a33d5e0");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fd765c1d-85b7-4618-9bb1-0fb2540851bf");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "77ab1fec-1372-4c02-85b6-0cd1aefcbe0c",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "d99e3edf-f105-444b-827b-02284e7bfee0");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3baeb7d6-855d-4e31-8a20-f5b84089c47c", "c31876f1-195e-4c5d-aab2-eb1132bb3fb0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b46a643-fe29-432e-8baa-a8930b0489a3", "ba9e42f3-4d2a-41cc-94de-c5fa5dbaf944", "User", "USER" });
        }
    }
}
