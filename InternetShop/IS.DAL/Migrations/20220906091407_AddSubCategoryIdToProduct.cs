using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class AddSubCategoryIdToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6a382490-c77b-4576-8ec7-744ee44615a7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9d1951e1-a819-46e9-89c2-00d7f1929307");

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "04ebd5c4-8134-494c-b872-b2c9ee93d8b7",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "635a7bcb-f626-4097-95cf-c5e7186f9ee0");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01721e5f-3a5f-454e-aa38-e227d8f01bcc", "5b187f5b-ef40-4e9c-96e8-f88d16a3d301", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "86b446ec-931f-4a05-8ba4-cd23689b63e5", "85aa51dd-d4e5-45ec-bb2d-7b2fec4ec68c", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "01721e5f-3a5f-454e-aa38-e227d8f01bcc");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "86b446ec-931f-4a05-8ba4-cd23689b63e5");

            migrationBuilder.DropColumn(
                name: "SubCategoryId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "635a7bcb-f626-4097-95cf-c5e7186f9ee0",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "04ebd5c4-8134-494c-b872-b2c9ee93d8b7");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6a382490-c77b-4576-8ec7-744ee44615a7", "1ade4644-8307-40a7-8729-4ce5b1dfe90b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d1951e1-a819-46e9-89c2-00d7f1929307", "3e7885c0-8620-4439-9c9a-4730b8f777bd", "User", "USER" });
        }
    }
}
