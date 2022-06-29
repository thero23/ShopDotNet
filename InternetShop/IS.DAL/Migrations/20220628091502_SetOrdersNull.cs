using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class SetOrdersNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6864ea20-ca85-4a07-ba64-b6fa142d79db");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a34c5ec6-c5ed-431d-9dda-0271c179722b");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e714002c-844f-4827-957e-1955ab47d2c5", "9a53f39e-de25-42e5-a02a-cca8c399f4d4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0de5644-d9d9-41ab-b250-99e32dfb029a", "385f94ca-b3e7-4c3b-b72a-001871e43c5b", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e714002c-844f-4827-957e-1955ab47d2c5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f0de5644-d9d9-41ab-b250-99e32dfb029a");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6864ea20-ca85-4a07-ba64-b6fa142d79db", "d44e1c40-bf56-46ba-bc8b-9ffadfcb9a59", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a34c5ec6-c5ed-431d-9dda-0271c179722b", "048551b1-ed60-4237-99c2-b8df4e9f0d61", "User", "USER" });
        }
    }
}
