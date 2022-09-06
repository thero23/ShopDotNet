using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class DeleteGeneralSubCategoryNameIdFromSubCategoryName1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1cd09057-3bc2-47d1-9cf8-8053acb7eafe");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "232cd522-1a2a-42a7-9b27-5a02b2620f42");

            migrationBuilder.DropColumn(
                name: "GeneralSubCategoryNameId",
                table: "SubCategoryNameEntity");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "635a7bcb-f626-4097-95cf-c5e7186f9ee0",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "6b8d74cf-c536-4224-8a33-f55cb7eca55e");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6a382490-c77b-4576-8ec7-744ee44615a7", "1ade4644-8307-40a7-8729-4ce5b1dfe90b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d1951e1-a819-46e9-89c2-00d7f1929307", "3e7885c0-8620-4439-9c9a-4730b8f777bd", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "GeneralSubCategoryNameId",
                table: "SubCategoryNameEntity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "6b8d74cf-c536-4224-8a33-f55cb7eca55e",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "635a7bcb-f626-4097-95cf-c5e7186f9ee0");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1cd09057-3bc2-47d1-9cf8-8053acb7eafe", "d9844d52-2e17-4cb5-b4d5-c7699659a0a5", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "232cd522-1a2a-42a7-9b27-5a02b2620f42", "c2543797-4301-43fe-8735-83f16149a596", "User", "USER" });
        }
    }
}
