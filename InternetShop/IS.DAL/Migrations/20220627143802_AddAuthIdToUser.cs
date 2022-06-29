using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class AddAuthIdToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "89e00057-5f98-478b-a372-22995a1f0a0e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d5fcb0ce-8590-4b1d-bd36-dd9f7b2e1911");

            migrationBuilder.AddColumn<string>(
                name: "Auth0Id",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6864ea20-ca85-4a07-ba64-b6fa142d79db", "d44e1c40-bf56-46ba-bc8b-9ffadfcb9a59", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a34c5ec6-c5ed-431d-9dda-0271c179722b", "048551b1-ed60-4237-99c2-b8df4e9f0d61", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6864ea20-ca85-4a07-ba64-b6fa142d79db");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a34c5ec6-c5ed-431d-9dda-0271c179722b");

            migrationBuilder.DropColumn(
                name: "Auth0Id",
                table: "Users");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89e00057-5f98-478b-a372-22995a1f0a0e", "80cceef5-d86c-4e4a-b9e0-1dfdf2284bfa", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5fcb0ce-8590-4b1d-bd36-dd9f7b2e1911", "27fbe523-09bf-4536-aff8-a16e9373afb6", "User", "USER" });
        }
    }
}
