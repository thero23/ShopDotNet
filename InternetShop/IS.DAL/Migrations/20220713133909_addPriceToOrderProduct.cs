using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class addPriceToOrderProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3afe9831-be1a-4338-9b56-3a8d8610b32a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "60b61535-e493-4a18-b7f6-64377a1e10ad");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "OrdersProducts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "9c6c263c-b4fe-42b8-a2b0-532b2502903a",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "88305cf9-f76e-4e38-9665-1ea2a3fce1d3");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "726b44eb-e236-46e1-80f2-34d201a0fe1f", "0546cf51-022f-450f-8cfb-d705bb22a59b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7507dfac-0ba6-451a-b0c6-01ee55632b50", "6e60c218-0336-4a2e-ad36-4f2031ee3536", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "726b44eb-e236-46e1-80f2-34d201a0fe1f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7507dfac-0ba6-451a-b0c6-01ee55632b50");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "OrdersProducts");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "88305cf9-f76e-4e38-9665-1ea2a3fce1d3",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "9c6c263c-b4fe-42b8-a2b0-532b2502903a");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3afe9831-be1a-4338-9b56-3a8d8610b32a", "c0f5f74f-772c-42fd-b732-075ff8c1490b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "60b61535-e493-4a18-b7f6-64377a1e10ad", "a171429b-588d-4cc1-92e1-4e52c874914c", "User", "USER" });
        }
    }
}
