using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class SetupProductInOrderEntityFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0c4ac912-40a0-4f51-9ddf-2836c902b1e3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "df0ba6bb-787f-4f6f-8196-cbc36f9dcddb");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dc5c0b22-2129-42b5-9d4f-b74dfec131df", "0b189791-d894-49d0-bd7a-1fc7eb6c5491", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0dcbb06-aa62-47da-957e-388b991fa1e1", "6af831a6-2a2e-462d-92d2-a7de0203f6a3", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "dc5c0b22-2129-42b5-9d4f-b74dfec131df");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f0dcbb06-aa62-47da-957e-388b991fa1e1");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c4ac912-40a0-4f51-9ddf-2836c902b1e3", "ca57e7a0-43dd-45cd-b630-9b609a6527ea", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "df0ba6bb-787f-4f6f-8196-cbc36f9dcddb", "dd44a3c7-ee29-4c08-b876-30838b03b9cf", "User", "USER" });
        }
    }
}
