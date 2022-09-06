using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class initSubCategoryTables : Migration
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
                defaultValue: "1540294f-a08c-4d57-991c-962928d3f757",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "657a99aa-63e0-4fdc-a071-6efd98706333");

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "05ef48ee-b00b-438c-9718-66d5afe49088", "a3ad08bd-b121-40e7-ba50-f0c04cdc1fcb", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ef7f9bf-8fa6-4743-912d-2fd953bb6ac6", "dff3565b-a620-4f8f-8e13-05aae6c4c1b5", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "05ef48ee-b00b-438c-9718-66d5afe49088");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9ef7f9bf-8fa6-4743-912d-2fd953bb6ac6");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "657a99aa-63e0-4fdc-a071-6efd98706333",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "1540294f-a08c-4d57-991c-962928d3f757");

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
