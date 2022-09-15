using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class deleteFieldCharacteristicsIdFromProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: "1e5c8747-87e1-4a5d-a380-46347e22a03c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3c6b5e0e-8456-4334-b56a-ea12ffdfdfe4");

            migrationBuilder.DropColumn(
                name: "CharacteristicId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductEntityId",
                table: "Characteristics");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "c566bbbd-4c50-4f3a-b1df-03b3bf049979",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "caefb6ba-fd13-4310-8215-4e1ea080228e");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "33caaa2d-7385-4168-a2bd-9a3daa0d8df2", "1d9e93b1-c6bd-4672-ade7-19d7c68cf73d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "77352779-5501-4fec-842d-52f9433e9329", "9123d6ef-5e5c-42a8-9735-472110f678f3", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "33caaa2d-7385-4168-a2bd-9a3daa0d8df2");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "77352779-5501-4fec-842d-52f9433e9329");

            migrationBuilder.AddColumn<int>(
                name: "CharacteristicId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductEntityId",
                table: "Characteristics",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "caefb6ba-fd13-4310-8215-4e1ea080228e",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "c566bbbd-4c50-4f3a-b1df-03b3bf049979");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1e5c8747-87e1-4a5d-a380-46347e22a03c", "63b39c39-e496-4335-b424-bc24fd6d250d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3c6b5e0e-8456-4334-b56a-ea12ffdfdfe4", "9c1ed25b-2bdb-44e1-9a87-490a0c47a263", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_Characteristics_ProductEntityId",
                table: "Characteristics",
                column: "ProductEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characteristics_Products_ProductEntityId",
                table: "Characteristics",
                column: "ProductEntityId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
