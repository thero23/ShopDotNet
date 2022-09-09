using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class ChangeProductIdToProductEntityIdInAdditionalCharacteristics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b005d59c-b3b1-47ee-a664-5db02a701b29");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d8e3ff04-f937-4a85-b40d-6a1d39e7164e");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Characteristics",
                newName: "ProductEntityId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "AdditionalCharacteristics",
                newName: "ProductEntityId");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "5afa1623-db2d-44b7-848d-13aa8f156539",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "8c1f1915-81cd-44e5-8cd5-8d5223d1cff5");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a56262c-b7d2-4625-9ceb-e9b6461de7d1", "b456d98e-d286-405d-b5d5-0b541deb8f52", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d280d678-e47e-4864-993f-492b9c06d3f5", "0355a44b-6eb9-406f-bd86-2377da21eaf5", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_Characteristics_ProductEntityId",
                table: "Characteristics",
                column: "ProductEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characteristics_Products_ProductEntityId",
                table: "Characteristics",
                column: "ProductEntityId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characteristics_Products_ProductEntityId",
                table: "Characteristics");

            migrationBuilder.DropIndex(
                name: "IX_Characteristics_ProductEntityId",
                table: "Characteristics");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7a56262c-b7d2-4625-9ceb-e9b6461de7d1");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d280d678-e47e-4864-993f-492b9c06d3f5");

            migrationBuilder.RenameColumn(
                name: "ProductEntityId",
                table: "Characteristics",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "ProductEntityId",
                table: "AdditionalCharacteristics",
                newName: "ProductId");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "8c1f1915-81cd-44e5-8cd5-8d5223d1cff5",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "5afa1623-db2d-44b7-848d-13aa8f156539");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b005d59c-b3b1-47ee-a664-5db02a701b29", "1c8d0eac-6ded-4e3a-8869-1ae9c8bcb2fe", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8e3ff04-f937-4a85-b40d-6a1d39e7164e", "f92f21de-ad62-4446-9a1e-cf5223380113", "User", "USER" });
        }
    }
}
