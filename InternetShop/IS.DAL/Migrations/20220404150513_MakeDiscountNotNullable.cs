using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class MakeDiscountNotNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1b2ea123-a72d-4432-a557-9d5532029499");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a50790cb-14be-4d9b-92aa-9fc865e38afe");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4daad2fd-2d0c-4527-a1e9-7fb8fddd5499", "f6c895b1-2ce3-48c2-a4ed-5ad0054d414d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe61a363-5c79-416c-b606-3c03adbac00e", "ea8eab11-5f0d-4013-bd6b-9d9878dd4f37", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4daad2fd-2d0c-4527-a1e9-7fb8fddd5499");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fe61a363-5c79-416c-b606-3c03adbac00e");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b2ea123-a72d-4432-a557-9d5532029499", "364fa53a-c8a9-4591-b116-3c6c48c5ff6d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a50790cb-14be-4d9b-92aa-9fc865e38afe", "d5eb902c-566c-4dd6-9e39-bef7819108dd", "User", "USER" });
        }
    }
}
