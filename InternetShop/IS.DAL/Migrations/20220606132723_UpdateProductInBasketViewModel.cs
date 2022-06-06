using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class UpdateProductInBasketViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "159b96c1-99f2-4962-a980-34e8fc52c66a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2b3c817a-38a3-42e4-b4c3-0c8490bad690");

            migrationBuilder.AddColumn<int>(
                name: "USerId",
                table: "ProductInBasket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84c0d8e5-21d8-4ff6-9270-1f464fbfd81a", "007bf51f-610d-4be3-9448-e75ca9da861d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a9f9d8fc-7d3e-4d27-8420-c20947dc6220", "86174735-f1a4-4728-ba4b-7f375552f97e", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "84c0d8e5-21d8-4ff6-9270-1f464fbfd81a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a9f9d8fc-7d3e-4d27-8420-c20947dc6220");

            migrationBuilder.DropColumn(
                name: "USerId",
                table: "ProductInBasket");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "159b96c1-99f2-4962-a980-34e8fc52c66a", "2ca783a5-6b2a-4562-932b-8ab6c97b5fa3", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b3c817a-38a3-42e4-b4c3-0c8490bad690", "8b143ea5-f314-44e1-9e0c-c9756f8f56dd", "User", "USER" });
        }
    }
}
