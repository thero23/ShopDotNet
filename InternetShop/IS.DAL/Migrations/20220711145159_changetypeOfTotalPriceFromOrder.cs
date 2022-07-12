using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class changetypeOfTotalPriceFromOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "45a22d2e-08b2-4f5d-bf14-e867989ed1ee");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d8825240-d48d-4dfd-a8e6-6c93b3d2d591");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "0a07c26d-56c6-4d54-9ebd-1f67097823fc",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "7e9daa1a-b15b-4777-928e-99ea987cc744");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "39121193-1081-4498-a2b8-48e315500720", "9498cfed-641d-45ab-ab92-237afdbc7a2b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb9abc0d-7ca8-44a5-be96-cbfbf7112fe6", "ecd6a195-7d28-4df8-b5cd-b19105240c83", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "39121193-1081-4498-a2b8-48e315500720");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cb9abc0d-7ca8-44a5-be96-cbfbf7112fe6");

            migrationBuilder.AlterColumn<int>(
                name: "TotalPrice",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "7e9daa1a-b15b-4777-928e-99ea987cc744",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "0a07c26d-56c6-4d54-9ebd-1f67097823fc");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "45a22d2e-08b2-4f5d-bf14-e867989ed1ee", "b7116280-5977-421e-b29f-40a1e926dccf", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8825240-d48d-4dfd-a8e6-6c93b3d2d591", "beea1512-4d66-4919-9036-383cc4c68717", "User", "USER" });
        }
    }
}
