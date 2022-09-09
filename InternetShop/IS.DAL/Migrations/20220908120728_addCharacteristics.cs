using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class addCharacteristics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "01721e5f-3a5f-454e-aa38-e227d8f01bcc");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "86b446ec-931f-4a05-8ba4-cd23689b63e5");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "964ce87d-e69b-4a7a-ada5-27f2005f42e4",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "04ebd5c4-8134-494c-b872-b2c9ee93d8b7");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "190286c1-20ab-4b7f-9506-2afbceb01c4f", "e5f81699-0373-45b5-885a-92642f73cb83", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d570cf4f-3b98-4e88-8054-b3c295e70ef1", "409d2e11-4a07-4c7e-aec0-83d1214983c9", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "190286c1-20ab-4b7f-9506-2afbceb01c4f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d570cf4f-3b98-4e88-8054-b3c295e70ef1");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "04ebd5c4-8134-494c-b872-b2c9ee93d8b7",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "964ce87d-e69b-4a7a-ada5-27f2005f42e4");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01721e5f-3a5f-454e-aa38-e227d8f01bcc", "5b187f5b-ef40-4e9c-96e8-f88d16a3d301", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "86b446ec-931f-4a05-8ba4-cd23689b63e5", "85aa51dd-d4e5-45ec-bb2d-7b2fec4ec68c", "User", "USER" });
        }
    }
}
