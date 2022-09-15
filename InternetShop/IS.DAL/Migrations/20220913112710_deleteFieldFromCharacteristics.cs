using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class deleteFieldFromCharacteristics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characteristics_Products_ProductEntityId",
                table: "Characteristics");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "92fd1f16-e8db-4050-aa43-12c3bb54e65d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b4cc5ed2-62d4-4643-b639-c48a534f491c");

            migrationBuilder.AlterColumn<int>(
                name: "ProductEntityId",
                table: "Characteristics",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "caefb6ba-fd13-4310-8215-4e1ea080228e",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "f444ccee-95f8-4b77-bffc-00a343cf406c");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1e5c8747-87e1-4a5d-a380-46347e22a03c", "63b39c39-e496-4335-b424-bc24fd6d250d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3c6b5e0e-8456-4334-b56a-ea12ffdfdfe4", "9c1ed25b-2bdb-44e1-9a87-490a0c47a263", "User", "USER" });

            migrationBuilder.AddForeignKey(
                name: "FK_Characteristics_Products_ProductEntityId",
                table: "Characteristics",
                column: "ProductEntityId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characteristics_Products_ProductEntityId",
                table: "Characteristics");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1e5c8747-87e1-4a5d-a380-46347e22a03c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3c6b5e0e-8456-4334-b56a-ea12ffdfdfe4");

            migrationBuilder.AlterColumn<int>(
                name: "ProductEntityId",
                table: "Characteristics",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "f444ccee-95f8-4b77-bffc-00a343cf406c",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "caefb6ba-fd13-4310-8215-4e1ea080228e");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "92fd1f16-e8db-4050-aa43-12c3bb54e65d", "48a15442-436d-4c89-8614-0c8ee31c57a2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b4cc5ed2-62d4-4643-b639-c48a534f491c", "29d9030b-a144-4042-b08b-1b57f5a259ab", "User", "USER" });

            migrationBuilder.AddForeignKey(
                name: "FK_Characteristics_Products_ProductEntityId",
                table: "Characteristics",
                column: "ProductEntityId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
