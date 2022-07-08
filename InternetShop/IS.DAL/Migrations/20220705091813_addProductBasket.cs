using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class addProductBasket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2961255e-f38a-4c9e-9cb3-8066e0826797");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "75bbf983-1e62-4dac-8c18-ffe43735a03a");

            migrationBuilder.CreateTable(
                name: "ProductsBaskets",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    BasketId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsBaskets", x => new { x.BasketId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductsBaskets_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "54e0d9f3-7603-4aa3-aefa-2131ef43decd", "1384e22d-aaaa-417e-bf57-d2ff1115fca0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "889ea732-ed7c-40e0-ad98-9b851be446b5", "92f79e42-30a1-4266-9426-fa9359f3c728", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsBaskets");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "54e0d9f3-7603-4aa3-aefa-2131ef43decd");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "889ea732-ed7c-40e0-ad98-9b851be446b5");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2961255e-f38a-4c9e-9cb3-8066e0826797", "5e909d50-8fce-43de-9b20-9543e2344670", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "75bbf983-1e62-4dac-8c18-ffe43735a03a", "776430f4-cf56-4507-b782-c8426b68d9e2", "User", "USER" });
        }
    }
}
