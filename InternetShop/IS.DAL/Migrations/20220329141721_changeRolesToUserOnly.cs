using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class changeRolesToUserOnly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b6fa95a3-f412-437f-a6fc-22e85a25668b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cc7d453f-4c18-449d-ac54-3330ff922eed");

            migrationBuilder.AddColumn<int>(
                name: "BasketId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0358e2d5-7b8b-4ead-b541-d920cb5f31a5", "c3c58b67-3945-443f-b6b9-34e4ba8a9b42", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0358e2d5-7b8b-4ead-b541-d920cb5f31a5");

            migrationBuilder.DropColumn(
                name: "BasketId",
                table: "Users");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b6fa95a3-f412-437f-a6fc-22e85a25668b", "3d8f64a1-a957-4a38-bb43-856449347e30", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc7d453f-4c18-449d-ac54-3330ff922eed", "c9b5997c-ddab-4fe3-8faa-5940ebfbbdc4", "Visitor", "VISITOR" });
        }
    }
}
