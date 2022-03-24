using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class renameCountFieldInProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "510bc559-0ece-4c4a-8c49-4ac1a04e91ad");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ba63a7ff-365d-4236-84e3-f97875a8d979");

            migrationBuilder.RenameColumn(
                name: "CountInStock",
                table: "Products",
                newName: "QuantityInStock");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2824d195-c312-4b88-b4d6-dbc73225f3c2", "68fd6ce6-0565-4a20-9458-70bbcb2f4dde", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "364105bd-006c-4424-bfe8-97f0650a2bd2", "b3b7f952-78af-4573-871f-8ede169f46e8", "Visitor", "VISITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2824d195-c312-4b88-b4d6-dbc73225f3c2");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "364105bd-006c-4424-bfe8-97f0650a2bd2");

            migrationBuilder.RenameColumn(
                name: "QuantityInStock",
                table: "Products",
                newName: "CountInStock");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "510bc559-0ece-4c4a-8c49-4ac1a04e91ad", "91fc8dd1-00e8-4910-b56a-0504a1e06389", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba63a7ff-365d-4236-84e3-f97875a8d979", "d09b1bf5-7735-4818-b8a7-8bc04f257bb7", "Visitor", "VISITOR" });
        }
    }
}
