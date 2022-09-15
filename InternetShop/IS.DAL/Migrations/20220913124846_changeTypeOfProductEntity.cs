using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class changeTypeOfProductEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsCharacteristic_Products_ProductEntityId",
                table: "ProductsCharacteristic");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsCharacteristic_ProductsBaskets_ProductId",
                table: "ProductsCharacteristic");

            migrationBuilder.DropIndex(
                name: "IX_ProductsCharacteristic_ProductEntityId",
                table: "ProductsCharacteristic");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7d866302-b8f2-450e-96b3-6d7bb47ae174");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "828a6f9b-5262-47b6-80e2-6a0a8b8ee965");

            migrationBuilder.DropColumn(
                name: "ProductEntityId",
                table: "ProductsCharacteristic");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "cc799e08-749b-41c6-9e2d-80b26c090513",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "87d8c3e9-472c-434d-8d1c-b1c90cf0303c");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "41bf922a-f867-4cb3-90f3-a39d444b59ad", "be474bfe-bed2-4bec-8c97-9ab9980bd675", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ed1b132-6c0e-491e-a2bd-e85d9ee810f0", "64aa506f-90e4-4ebe-8363-6bdf08ccd6b4", "User", "USER" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsCharacteristic_Products_ProductId",
                table: "ProductsCharacteristic",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsCharacteristic_Products_ProductId",
                table: "ProductsCharacteristic");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "41bf922a-f867-4cb3-90f3-a39d444b59ad");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9ed1b132-6c0e-491e-a2bd-e85d9ee810f0");

            migrationBuilder.AddColumn<int>(
                name: "ProductEntityId",
                table: "ProductsCharacteristic",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "87d8c3e9-472c-434d-8d1c-b1c90cf0303c",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "cc799e08-749b-41c6-9e2d-80b26c090513");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7d866302-b8f2-450e-96b3-6d7bb47ae174", "11d5b77a-3d98-423e-9696-30bdc9e30b1d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "828a6f9b-5262-47b6-80e2-6a0a8b8ee965", "7cae586f-94fe-4a04-863d-b82a86a96ecb", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsCharacteristic_ProductEntityId",
                table: "ProductsCharacteristic",
                column: "ProductEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsCharacteristic_Products_ProductEntityId",
                table: "ProductsCharacteristic",
                column: "ProductEntityId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsCharacteristic_ProductsBaskets_ProductId",
                table: "ProductsCharacteristic",
                column: "ProductId",
                principalTable: "ProductsBaskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
