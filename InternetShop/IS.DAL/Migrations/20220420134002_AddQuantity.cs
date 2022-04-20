using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class AddQuantity : Migration
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
                values: new object[] { "c018670c-6e17-406f-9d56-af4b23e45e6e", "4aa5748b-452f-4e99-835c-c4566ee0dd64", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e9d058a7-4062-4c55-9063-985c4b30cd00", "ea304da8-cd9a-4a29-bae4-7369d2428e52", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c018670c-6e17-406f-9d56-af4b23e45e6e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e9d058a7-4062-4c55-9063-985c4b30cd00");

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
