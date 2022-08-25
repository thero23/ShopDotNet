using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class AddSubCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c55ee4d7-839b-42ef-8dad-e7d98cbc0ed1");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c7024daa-011b-4fcc-bca9-5ee80ef32b6e");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "db6c3f10-a2ba-4106-a27e-774ec657fa24",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "657a99aa-63e0-4fdc-a071-6efd98706333");

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "29284c21-b555-4537-a81b-e113425650c4", "818af268-c573-4873-8685-6379ca00f521", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c47b3748-7e1c-46ef-bee0-c7833dc4f90c", "e5d01e49-218c-4f42-a206-ec97c70fa3db", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "29284c21-b555-4537-a81b-e113425650c4");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c47b3748-7e1c-46ef-bee0-c7833dc4f90c");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "657a99aa-63e0-4fdc-a071-6efd98706333",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "db6c3f10-a2ba-4106-a27e-774ec657fa24");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c55ee4d7-839b-42ef-8dad-e7d98cbc0ed1", "df1881f5-ba2b-4747-9334-9b3468b87b13", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c7024daa-011b-4fcc-bca9-5ee80ef32b6e", "61612de3-7ec7-4874-ba50-5a8a89f819b3", "User", "USER" });
        }
    }
}
