using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class addProductsCharacteristicTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "30175e81-c1aa-42e9-847e-6acc9bb867ab");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "789767a7-b9eb-417e-ae61-4fdbe75a04a8");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "87d8c3e9-472c-434d-8d1c-b1c90cf0303c",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "895df220-9c71-48f7-8b3f-c2ec9b14ed7f");

            migrationBuilder.CreateTable(
                name: "ProductsCharacteristic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CharacteristicId = table.Column<int>(type: "int", nullable: false),
                    CharacteristicsId = table.Column<int>(type: "int", nullable: false),
                    ProductEntityId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_ProductsCharacteristic_Products_ProductEntityId",
                        column: x => x.ProductEntityId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductsCharacteristic_ProductsBaskets_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductsBaskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7d866302-b8f2-450e-96b3-6d7bb47ae174", "11d5b77a-3d98-423e-9696-30bdc9e30b1d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "828a6f9b-5262-47b6-80e2-6a0a8b8ee965", "7cae586f-94fe-4a04-863d-b82a86a96ecb", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsCharacteristic_CharacteristicsId",
                table: "ProductsCharacteristic",
                column: "CharacteristicsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsCharacteristic_ProductEntityId",
                table: "ProductsCharacteristic",
                column: "ProductEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsCharacteristic_ProductId",
                table: "ProductsCharacteristic",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsCharacteristic");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7d866302-b8f2-450e-96b3-6d7bb47ae174");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "828a6f9b-5262-47b6-80e2-6a0a8b8ee965");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "895df220-9c71-48f7-8b3f-c2ec9b14ed7f",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "87d8c3e9-472c-434d-8d1c-b1c90cf0303c");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "30175e81-c1aa-42e9-847e-6acc9bb867ab", "6154bc7d-f0eb-4279-9511-a65897bd765b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "789767a7-b9eb-417e-ae61-4fdbe75a04a8", "de57bc88-06ac-4bdb-90c4-b06bb9b9b19e", "User", "USER" });
        }
    }
}
