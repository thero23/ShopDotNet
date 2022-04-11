using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4daad2fd-2d0c-4527-a1e9-7fb8fddd5499");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fe61a363-5c79-416c-b606-3c03adbac00e");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6390ea22-cc5e-4894-b5d8-dab3bc1482b7", "a51a5968-3970-4ddf-8f97-75a5bc941f1f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d9ad2745-01df-41e3-9951-27f7f09bc150", "33144623-4fed-4f32-99e7-25cbec62ea16", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6390ea22-cc5e-4894-b5d8-dab3bc1482b7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d9ad2745-01df-41e3-9951-27f7f09bc150");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4daad2fd-2d0c-4527-a1e9-7fb8fddd5499", "f6c895b1-2ce3-48c2-a4ed-5ad0054d414d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe61a363-5c79-416c-b606-3c03adbac00e", "ea8eab11-5f0d-4013-bd6b-9d9878dd4f37", "User", "USER" });
        }
    }
}
