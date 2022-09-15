using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class addSomething : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsCharacteristic");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "120eb1a3-0e2e-4321-b79a-17331461bd31");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "54b2cd3d-34c1-494e-8fa0-68b26259a021");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "315121d5-4600-4da5-ba5d-84402ce527a9",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "2ed05ffb-4373-4183-9f98-d39e4e314fb6");

            migrationBuilder.CreateTable(
                name: "ProductCharacteristics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CharacteristicsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCharacteristics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCharacteristics_Characteristics_CharacteristicsId",
                        column: x => x.CharacteristicsId,
                        principalTable: "Characteristics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCharacteristics_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3aff40a0-df6b-4f20-afdb-0a00d845f904", "ec5bd824-c877-4854-be82-e7623031cd44", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8f31c9f5-fffa-451d-b337-410da7aa29f6", "94a99dd2-14b5-4405-8de3-a1be25da44e0", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCharacteristics_CharacteristicsId",
                table: "ProductCharacteristics",
                column: "CharacteristicsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCharacteristics_ProductId",
                table: "ProductCharacteristics",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCharacteristics");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3aff40a0-df6b-4f20-afdb-0a00d845f904");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8f31c9f5-fffa-451d-b337-410da7aa29f6");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "2ed05ffb-4373-4183-9f98-d39e4e314fb6",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "315121d5-4600-4da5-ba5d-84402ce527a9");

            migrationBuilder.CreateTable(
                name: "ProductsCharacteristic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacteristicsId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsCharacteristic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsCharacteristic_Characteristics_CharacteristicsId",
                        column: x => x.CharacteristicsId,
                        principalTable: "Characteristics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsCharacteristic_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "120eb1a3-0e2e-4321-b79a-17331461bd31", "4ae4e11a-85b2-4436-928c-11dd545095e7", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "54b2cd3d-34c1-494e-8fa0-68b26259a021", "db0ca672-1c46-40b0-b719-acd5b659e669", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsCharacteristic_CharacteristicsId",
                table: "ProductsCharacteristic",
                column: "CharacteristicsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsCharacteristic_ProductId",
                table: "ProductsCharacteristic",
                column: "ProductId");
        }
    }
}
