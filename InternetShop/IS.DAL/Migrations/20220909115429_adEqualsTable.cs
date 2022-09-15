using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class adEqualsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9d3dc4e2-52a0-44b5-a3a8-f418536563ff");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b2293eee-1ceb-480a-9027-5134b0ade2c5");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "eec62641-2391-4bda-ac5f-3b9f7f4357c1",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "6cba03ba-20f1-497e-9747-6328f783e853");

            migrationBuilder.CreateTable(
                name: "Equals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equals", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "300e75b6-a401-4e12-9a2c-4e0a0d50c464", "32f29bf2-031a-44ac-ab0c-c81d345041bb", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a5156c7-d78f-4140-88ec-06578573b940", "1f72ec11-8a1a-4931-81e6-2b9caa4a210c", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equals");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "300e75b6-a401-4e12-9a2c-4e0a0d50c464");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7a5156c7-d78f-4140-88ec-06578573b940");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "6cba03ba-20f1-497e-9747-6328f783e853",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "eec62641-2391-4bda-ac5f-3b9f7f4357c1");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d3dc4e2-52a0-44b5-a3a8-f418536563ff", "e37bd8c3-b1b7-435e-ab4c-b9c676e2fbfc", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2293eee-1ceb-480a-9027-5134b0ade2c5", "76012d2d-62d2-4500-b53e-9a5aa59c6bbf", "User", "USER" });
        }
    }
}
