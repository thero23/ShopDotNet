using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class CreatebuyInOneClick : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "84c0d8e5-21d8-4ff6-9270-1f464fbfd81a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a9f9d8fc-7d3e-4d27-8420-c20947dc6220");

            migrationBuilder.CreateTable(
                name: "BuyInOneClick",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyInOneClick", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "347dc8e1-64e3-46db-8345-918e46b99316", "412570f7-cd14-4c11-b920-a0bb5d736b21", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "653c3044-f949-4b3d-b2a5-ac1b9bfbda9f", "8885c7f5-cc76-4857-9807-014fab2a72e1", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuyInOneClick");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "347dc8e1-64e3-46db-8345-918e46b99316");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "653c3044-f949-4b3d-b2a5-ac1b9bfbda9f");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84c0d8e5-21d8-4ff6-9270-1f464fbfd81a", "007bf51f-610d-4be3-9448-e75ca9da861d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a9f9d8fc-7d3e-4d27-8420-c20947dc6220", "86174735-f1a4-4728-ba4b-7f375552f97e", "User", "USER" });
        }
    }
}
