using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class RemoveNullableDiscount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "28f7b8e8-c2b4-4fea-8ccd-7657cfe01568");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "924007a5-302d-47b8-8227-321fa016edc4");

            migrationBuilder.AlterColumn<int>(
                name: "Discount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b2ea123-a72d-4432-a557-9d5532029499", "364fa53a-c8a9-4591-b116-3c6c48c5ff6d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a50790cb-14be-4d9b-92aa-9fc865e38afe", "d5eb902c-566c-4dd6-9e39-bef7819108dd", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1b2ea123-a72d-4432-a557-9d5532029499");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a50790cb-14be-4d9b-92aa-9fc865e38afe");

            migrationBuilder.AlterColumn<int>(
                name: "Discount",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "28f7b8e8-c2b4-4fea-8ccd-7657cfe01568", "566875f0-bbe3-4fc6-8465-6015362a118d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "924007a5-302d-47b8-8227-321fa016edc4", "699323f4-f991-4cb7-8f3f-fb000f9a6803", "User", "USER" });
        }
    }
}
