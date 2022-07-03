using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class addForeignKeyDataAnnotation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2bd3d53c-929e-499f-b5ae-8bf0da19d439");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c49a1b45-9209-4f1b-999b-3f5a9bd92af0");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c4ac912-40a0-4f51-9ddf-2836c902b1e3", "ca57e7a0-43dd-45cd-b630-9b609a6527ea", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "df0ba6bb-787f-4f6f-8196-cbc36f9dcddb", "dd44a3c7-ee29-4c08-b876-30838b03b9cf", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "2bd3d53c-929e-499f-b5ae-8bf0da19d439", "00011076-3119-4e33-9e22-e56d48a7fad8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c49a1b45-9209-4f1b-999b-3f5a9bd92af0", "66e67120-688a-46d1-87ef-0ed607932034", "User", "USER" });
        }
    }
}
