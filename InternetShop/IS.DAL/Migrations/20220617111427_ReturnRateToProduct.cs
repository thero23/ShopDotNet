using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class ReturnRateToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "40c49742-232b-4d53-842a-4ef0bd480ab0");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "44460941-87da-491c-aec0-8c393849292f");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "40c49742-232b-4d53-842a-4ef0bd480ab0", "5a9c9775-7955-460d-ba0f-5f3836b2f799", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44460941-87da-491c-aec0-8c393849292f", "94fad24f-6697-4914-aa8e-5b6e7a204699", "User", "USER" });
        }
    }
}
