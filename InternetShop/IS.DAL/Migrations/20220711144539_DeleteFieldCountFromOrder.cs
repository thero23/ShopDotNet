using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class DeleteFieldCountFromOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1afc25dc-f683-4e0a-8b00-43aed96d443e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "69bb37e4-9813-40d5-a9c4-e8fe8f820f17");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "7e9daa1a-b15b-4777-928e-99ea987cc744",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "909f73bc-4700-4496-b303-70be05303363");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "45a22d2e-08b2-4f5d-bf14-e867989ed1ee", "b7116280-5977-421e-b29f-40a1e926dccf", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8825240-d48d-4dfd-a8e6-6c93b3d2d591", "beea1512-4d66-4919-9036-383cc4c68717", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "45a22d2e-08b2-4f5d-bf14-e867989ed1ee");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d8825240-d48d-4dfd-a8e6-6c93b3d2d591");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "909f73bc-4700-4496-b303-70be05303363",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "7e9daa1a-b15b-4777-928e-99ea987cc744");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1afc25dc-f683-4e0a-8b00-43aed96d443e", "0c2973ac-f506-44da-9fa3-cd35c8b9abbf", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "69bb37e4-9813-40d5-a9c4-e8fe8f820f17", "66b65458-1288-45b8-929f-3f9711122853", "User", "USER" });
        }
    }
}
