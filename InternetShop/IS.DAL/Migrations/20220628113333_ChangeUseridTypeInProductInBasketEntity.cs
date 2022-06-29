using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class ChangeUseridTypeInProductInBasketEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5183f406-2758-48e0-b07c-6f5fb3002d4e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a31ed0fc-952e-4964-b96c-a37a9482838c");

            migrationBuilder.RenameColumn(
                name: "USerId",
                table: "ProductInBasket",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ProductInBasket",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "194604eb-d167-4d0b-82e1-16bfe1529072", "a1cf3a8f-7e08-4ab2-bd81-e8cb864c7ff9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bd5e2d96-7431-45ef-a24a-4a828b428890", "d3c114b0-32c4-4647-8587-38d44565fddd", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "194604eb-d167-4d0b-82e1-16bfe1529072");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "bd5e2d96-7431-45ef-a24a-4a828b428890");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ProductInBasket",
                newName: "USerId");

            migrationBuilder.AlterColumn<int>(
                name: "USerId",
                table: "ProductInBasket",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5183f406-2758-48e0-b07c-6f5fb3002d4e", "ec96a72b-c1a6-49af-972a-0e07b9ecafaf", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a31ed0fc-952e-4964-b96c-a37a9482838c", "10c4e184-c16d-4fcf-8951-e6f6cc769446", "User", "USER" });
        }
    }
}
