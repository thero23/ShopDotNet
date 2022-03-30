using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class addProductBusketMtM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2824d195-c312-4b88-b4d6-dbc73225f3c2");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "364105bd-006c-4424-bfe8-97f0650a2bd2");

            migrationBuilder.CreateTable(
                name: "ProductBasketEntity",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    BasketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBasketEntity", x => new { x.BasketId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductBasketEntity_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductBasketEntity_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b6fa95a3-f412-437f-a6fc-22e85a25668b", "3d8f64a1-a957-4a38-bb43-856449347e30", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc7d453f-4c18-449d-ac54-3330ff922eed", "c9b5997c-ddab-4fe3-8faa-5940ebfbbdc4", "Visitor", "VISITOR" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductBasketEntity_ProductId",
                table: "ProductBasketEntity",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductBasketEntity");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b6fa95a3-f412-437f-a6fc-22e85a25668b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cc7d453f-4c18-449d-ac54-3330ff922eed");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2824d195-c312-4b88-b4d6-dbc73225f3c2", "68fd6ce6-0565-4a20-9458-70bbcb2f4dde", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "364105bd-006c-4424-bfe8-97f0650a2bd2", "b3b7f952-78af-4573-871f-8ede169f46e8", "Visitor", "VISITOR" });
        }
    }
}
