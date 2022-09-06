using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class addSubCategoriesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "caec68db-e38e-4e0e-879b-1e49a6c40837");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d81e49e6-6f26-4669-a78f-65c650aeb5c1");

            migrationBuilder.AddColumn<int>(
                name: "SubcategoryId",
                table: "GeneralSubCategoryNameEntity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "d007359b-e425-4bf4-87e0-e9081a5d21b2",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "7bf3e41e-2681-479e-8b52-45c025e5fa64");

            migrationBuilder.CreateTable(
                name: "SubCategoryNameEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneralSubCategoryNameId = table.Column<int>(type: "int", nullable: false),
                    GeneralSubCategoryNameEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategoryNameEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategoryNameEntity_GeneralSubCategoryNameEntity_GeneralSubCategoryNameEntityId",
                        column: x => x.GeneralSubCategoryNameEntityId,
                        principalTable: "GeneralSubCategoryNameEntity",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "484c6c08-eccf-4ed6-a232-b7795b1941bd", "297e5285-2abf-463e-a35e-42bbd87d4a0a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d61f66b6-6bf2-4f94-9523-9fbe562e6d68", "2b1c4ab0-07c3-4716-9176-3725f98ecc1c", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoryNameEntity_GeneralSubCategoryNameEntityId",
                table: "SubCategoryNameEntity",
                column: "GeneralSubCategoryNameEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategoryNameEntity");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "484c6c08-eccf-4ed6-a232-b7795b1941bd");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d61f66b6-6bf2-4f94-9523-9fbe562e6d68");

            migrationBuilder.DropColumn(
                name: "SubcategoryId",
                table: "GeneralSubCategoryNameEntity");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "7bf3e41e-2681-479e-8b52-45c025e5fa64",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "d007359b-e425-4bf4-87e0-e9081a5d21b2");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "caec68db-e38e-4e0e-879b-1e49a6c40837", "c2d70542-bf7b-4dcd-90e3-514cedb64209", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d81e49e6-6f26-4669-a78f-65c650aeb5c1", "5e6e682b-64a3-49e2-af15-e278b7284336", "User", "USER" });
        }
    }
}
