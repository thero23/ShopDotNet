using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class addCountToOrderproductEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e38f39da-6cb4-45af-b56c-211f0fc56e20");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e866c8da-3972-4fed-99ff-32e393ddfa7e");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "OrdersProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "88305cf9-f76e-4e38-9665-1ea2a3fce1d3",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "681da06d-a6c2-4ea5-bfe9-a1546d9b8cb2");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3afe9831-be1a-4338-9b56-3a8d8610b32a", "c0f5f74f-772c-42fd-b732-075ff8c1490b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "60b61535-e493-4a18-b7f6-64377a1e10ad", "a171429b-588d-4cc1-92e1-4e52c874914c", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3afe9831-be1a-4338-9b56-3a8d8610b32a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "60b61535-e493-4a18-b7f6-64377a1e10ad");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "OrdersProducts");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "681da06d-a6c2-4ea5-bfe9-a1546d9b8cb2",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "88305cf9-f76e-4e38-9665-1ea2a3fce1d3");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e38f39da-6cb4-45af-b56c-211f0fc56e20", "c9175ba7-5e74-4665-9636-0cd97f6742b2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e866c8da-3972-4fed-99ff-32e393ddfa7e", "ad3c4c73-df80-4e9f-9f4d-10b41a9a83fe", "User", "USER" });
        }
    }
}
