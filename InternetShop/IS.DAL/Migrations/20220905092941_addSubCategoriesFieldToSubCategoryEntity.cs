using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class addSubCategoriesFieldToSubCategoryEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                defaultValue: "7bf3e41e-2681-479e-8b52-45c025e5fa64",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "1540294f-a08c-4d57-991c-962928d3f757");

            migrationBuilder.CreateTable(
                name: "GeneralSubCategoryNameEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralSubCategoryNameEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralSubCategoryNameEntity_SubCategories_SubCategoryEntityId",
                        column: x => x.SubCategoryEntityId,
                        principalTable: "SubCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "caec68db-e38e-4e0e-879b-1e49a6c40837", "c2d70542-bf7b-4dcd-90e3-514cedb64209", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d81e49e6-6f26-4669-a78f-65c650aeb5c1", "5e6e682b-64a3-49e2-af15-e278b7284336", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_GeneralSubCategoryNameEntity_SubCategoryEntityId",
                table: "GeneralSubCategoryNameEntity",
                column: "SubCategoryEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneralSubCategoryNameEntity");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "caec68db-e38e-4e0e-879b-1e49a6c40837");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d81e49e6-6f26-4669-a78f-65c650aeb5c1");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "1540294f-a08c-4d57-991c-962928d3f757",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "7bf3e41e-2681-479e-8b52-45c025e5fa64");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "05ef48ee-b00b-438c-9718-66d5afe49088", "a3ad08bd-b121-40e7-ba50-f0c04cdc1fcb", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ef7f9bf-8fa6-4743-912d-2fd953bb6ac6", "dff3565b-a620-4f8f-8e13-05aae6c4c1b5", "User", "USER" });
        }
    }
}
