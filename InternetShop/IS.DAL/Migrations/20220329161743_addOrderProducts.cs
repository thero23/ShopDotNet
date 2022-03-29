using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class addOrderProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductBasketEntity_Baskets_BasketId",
                table: "ProductBasketEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductBasketEntity_Products_ProductId",
                table: "ProductBasketEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_OrderEntityId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_OrderEntityId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductBasketEntity",
                table: "ProductBasketEntity");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "03f09a6d-db98-4f1f-a46c-e12f02ec703c");

            migrationBuilder.DropColumn(
                name: "OrderEntityId",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "ProductBasketEntity",
                newName: "ProductsBaskets");

            migrationBuilder.RenameIndex(
                name: "IX_ProductBasketEntity_ProductId",
                table: "ProductsBaskets",
                newName: "IX_ProductsBaskets_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsBaskets",
                table: "ProductsBaskets",
                columns: new[] { "BasketId", "ProductId" });

            migrationBuilder.CreateTable(
                name: "OrdersProducts",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersProducts", x => new { x.ProductId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_OrdersProducts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "df59ca97-8310-4dcd-ae63-f3ea8b040fcf", "554c218e-5e89-435c-a2ea-064980b276e5", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_OrdersProducts_OrderId",
                table: "OrdersProducts",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsBaskets_Baskets_BasketId",
                table: "ProductsBaskets",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsBaskets_Products_ProductId",
                table: "ProductsBaskets",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsBaskets_Baskets_BasketId",
                table: "ProductsBaskets");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsBaskets_Products_ProductId",
                table: "ProductsBaskets");

            migrationBuilder.DropTable(
                name: "OrdersProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsBaskets",
                table: "ProductsBaskets");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "df59ca97-8310-4dcd-ae63-f3ea8b040fcf");

            migrationBuilder.RenameTable(
                name: "ProductsBaskets",
                newName: "ProductBasketEntity");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsBaskets_ProductId",
                table: "ProductBasketEntity",
                newName: "IX_ProductBasketEntity_ProductId");

            migrationBuilder.AddColumn<int>(
                name: "OrderEntityId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductBasketEntity",
                table: "ProductBasketEntity",
                columns: new[] { "BasketId", "ProductId" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "03f09a6d-db98-4f1f-a46c-e12f02ec703c", "aea23832-2b8f-43d1-b971-c9d75fc88413", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderEntityId",
                table: "Products",
                column: "OrderEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductBasketEntity_Baskets_BasketId",
                table: "ProductBasketEntity",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductBasketEntity_Products_ProductId",
                table: "ProductBasketEntity",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_OrderEntityId",
                table: "Products",
                column: "OrderEntityId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
