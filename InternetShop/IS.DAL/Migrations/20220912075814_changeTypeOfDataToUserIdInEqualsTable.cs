using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class changeTypeOfDataToUserIdInEqualsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "300e75b6-a401-4e12-9a2c-4e0a0d50c464");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7a5156c7-d78f-4140-88ec-06578573b940");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Equals",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "f444ccee-95f8-4b77-bffc-00a343cf406c",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "eec62641-2391-4bda-ac5f-3b9f7f4357c1");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "92fd1f16-e8db-4050-aa43-12c3bb54e65d", "48a15442-436d-4c89-8614-0c8ee31c57a2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b4cc5ed2-62d4-4643-b639-c48a534f491c", "29d9030b-a144-4042-b08b-1b57f5a259ab", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_Equals_ProductId",
                table: "Equals",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equals_Products_ProductId",
                table: "Equals",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equals_Products_ProductId",
                table: "Equals");

            migrationBuilder.DropIndex(
                name: "IX_Equals_ProductId",
                table: "Equals");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "92fd1f16-e8db-4050-aa43-12c3bb54e65d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b4cc5ed2-62d4-4643-b639-c48a534f491c");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Equals",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "eec62641-2391-4bda-ac5f-3b9f7f4357c1",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "f444ccee-95f8-4b77-bffc-00a343cf406c");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "300e75b6-a401-4e12-9a2c-4e0a0d50c464", "32f29bf2-031a-44ac-ab0c-c81d345041bb", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a5156c7-d78f-4140-88ec-06578573b940", "1f72ec11-8a1a-4931-81e6-2b9caa4a210c", "User", "USER" });
        }
    }
}
