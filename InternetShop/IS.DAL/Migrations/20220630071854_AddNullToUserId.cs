using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class AddNullToUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cb627032-ff57-4c77-b687-7fb45d207066");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ef8411ba-8958-4c54-9b9b-13eafb7cfa94");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2766f6b8-c24c-4bfe-928d-f2f75493c538", "67e0be1e-70f1-403a-af2b-3ec985712266", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5f6b057-f55b-4a13-a744-408fb5a319a7", "325281c4-1412-44ec-843d-ec926ff3debe", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2766f6b8-c24c-4bfe-928d-f2f75493c538");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c5f6b057-f55b-4a13-a744-408fb5a319a7");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb627032-ff57-4c77-b687-7fb45d207066", "33786001-1268-4574-b4e8-16491ac6367a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef8411ba-8958-4c54-9b9b-13eafb7cfa94", "9d928315-b2c3-4a23-bb79-e9a49525abb1", "User", "USER" });
        }
    }
}
