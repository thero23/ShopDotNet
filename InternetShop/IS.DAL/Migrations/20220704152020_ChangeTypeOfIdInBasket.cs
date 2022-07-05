using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class ChangeTypeOfIdInBasket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1dc568df-25e2-448b-b6c6-40f62f864c46");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "39360c4d-6ce7-408d-ba9f-a160cac67efc");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "ProductsBaskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cf194247-95a2-4d2b-baca-fb024ef51841", "cbb7337c-ae13-4bf5-8ee3-d3e48711d13b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d13a16fc-891e-4660-a17b-4e9ed13b657e", "99e9b6dd-4d5c-44e7-a0a0-42b9fe1a4685", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cf194247-95a2-4d2b-baca-fb024ef51841");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d13a16fc-891e-4660-a17b-4e9ed13b657e");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "ProductsBaskets");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1dc568df-25e2-448b-b6c6-40f62f864c46", "f2be40a3-f631-4cbc-b590-cdd7a8da4939", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "39360c4d-6ce7-408d-ba9f-a160cac67efc", "b54b98a6-cce3-45eb-9a22-5489adbf53b2", "User", "USER" });
        }
    }
}
