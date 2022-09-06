using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class deleteSomeFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "484c6c08-eccf-4ed6-a232-b7795b1941bd");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d61f66b6-6bf2-4f94-9523-9fbe562e6d68");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "SubcategoryId",
                table: "GeneralSubCategoryNameEntity");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "f0da29dd-8025-445c-955e-580b4f00df51",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "d007359b-e425-4bf4-87e0-e9081a5d21b2");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51cf8a91-3986-49b3-a40a-1ea1e8456b36", "4cd10194-f9f3-4555-a60b-e699a2c50518", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2ca6475-f731-406b-baa6-246c2f33e91e", "a21327f7-91b4-46e7-9c90-a0de79bd9586", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "51cf8a91-3986-49b3-a40a-1ea1e8456b36");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d2ca6475-f731-406b-baa6-246c2f33e91e");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "SubCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubcategoryId",
                table: "GeneralSubCategoryNameEntity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "d007359b-e425-4bf4-87e0-e9081a5d21b2",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "f0da29dd-8025-445c-955e-580b4f00df51");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "484c6c08-eccf-4ed6-a232-b7795b1941bd", "297e5285-2abf-463e-a35e-42bbd87d4a0a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d61f66b6-6bf2-4f94-9523-9fbe562e6d68", "2b1c4ab0-07c3-4716-9176-3725f98ecc1c", "User", "USER" });
        }
    }
}
