using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class ReturnRateToProductSecondTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "53a85246-8c5e-461e-97e9-0927cda956e0", "f9197a06-d20b-4b99-9b49-8e424f5fac43", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e9bddf30-be9c-46dc-b342-267b09f99b4a", "08967afd-c4f7-45b8-a601-dc1772aecf5f", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "53a85246-8c5e-461e-97e9-0927cda956e0");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e9bddf30-be9c-46dc-b342-267b09f99b4a");

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
    }
}
