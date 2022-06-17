using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class AddWhishListtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "347dc8e1-64e3-46db-8345-918e46b99316");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "653c3044-f949-4b3d-b2a5-ac1b9bfbda9f");

            migrationBuilder.CreateTable(
                name: "WhishList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhishList", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43432be8-ce57-4348-a4e6-d40b613c0cf2", "f6639948-74a9-4c8d-bc81-29dc068b2713", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a4bf3b62-d822-4010-9dd9-94c69cffa8e6", "edca1490-06c6-4f25-bb0f-8fd09b997494", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WhishList");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "43432be8-ce57-4348-a4e6-d40b613c0cf2");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a4bf3b62-d822-4010-9dd9-94c69cffa8e6");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "347dc8e1-64e3-46db-8345-918e46b99316", "412570f7-cd14-4c11-b920-a0bb5d736b21", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "653c3044-f949-4b3d-b2a5-ac1b9bfbda9f", "8885c7f5-cc76-4857-9807-014fab2a72e1", "User", "USER" });
        }
    }
}
