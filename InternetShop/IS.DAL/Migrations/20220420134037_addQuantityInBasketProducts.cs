using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class addQuantityInBasketProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4daad2fd-2d0c-4527-a1e9-7fb8fddd5499");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fe61a363-5c79-416c-b606-3c03adbac00e");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ProductsBaskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b7483119-c0c6-47de-92f3-53b1a62a2a58", "d718c724-1cd4-4661-874c-9f31a897e5d2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2cfa38a-d757-4e56-b040-6492fd11e432", "4b4985e2-2556-4aa3-9f1e-718814492931", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b7483119-c0c6-47de-92f3-53b1a62a2a58");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e2cfa38a-d757-4e56-b040-6492fd11e432");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ProductsBaskets");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4daad2fd-2d0c-4527-a1e9-7fb8fddd5499", "f6c895b1-2ce3-48c2-a4ed-5ad0054d414d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe61a363-5c79-416c-b606-3c03adbac00e", "ea8eab11-5f0d-4013-bd6b-9d9878dd4f37", "User", "USER" });
        }
    }
}
