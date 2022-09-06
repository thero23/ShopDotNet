using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class DeleteGeneralSubCategoryNameIdFromSubCategoryName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "6b8d74cf-c536-4224-8a33-f55cb7eca55e",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "f0da29dd-8025-445c-955e-580b4f00df51");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1cd09057-3bc2-47d1-9cf8-8053acb7eafe", "d9844d52-2e17-4cb5-b4d5-c7699659a0a5", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "232cd522-1a2a-42a7-9b27-5a02b2620f42", "c2543797-4301-43fe-8735-83f16149a596", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "CategoryId",
                table: "SubCategories");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "f0da29dd-8025-445c-955e-580b4f00df51",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "6b8d74cf-c536-4224-8a33-f55cb7eca55e");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51cf8a91-3986-49b3-a40a-1ea1e8456b36", "4cd10194-f9f3-4555-a60b-e699a2c50518", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2ca6475-f731-406b-baa6-246c2f33e91e", "a21327f7-91b4-46e7-9c90-a0de79bd9586", "User", "USER" });
        }
    }
}
