using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class DeleteRateFromProductSecondTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3dd48f32-6f89-4094-afcc-8f9cf068641d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "93ff40a3-4cfa-40e7-9d31-29c90fdee72f");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Products");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b195bce-eb6f-487b-be16-67a21ab7a0ae", "8eae2dff-f21d-4100-8117-af131e11495f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2efda50f-3625-4883-8f4c-e50c2d8854dc", "b2d84409-773a-4c87-a6a1-64d607300959", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2b195bce-eb6f-487b-be16-67a21ab7a0ae");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2efda50f-3625-4883-8f4c-e50c2d8854dc");

            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3dd48f32-6f89-4094-afcc-8f9cf068641d", "d9eb84c1-5f21-4808-88fe-a05c57e74449", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "93ff40a3-4cfa-40e7-9d31-29c90fdee72f", "1a8fa454-51ae-46b9-85b4-d586edc78e91", "User", "USER" });
        }
    }
}
