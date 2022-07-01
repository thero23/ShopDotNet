using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class AddProductEntityId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "31befd07-85b4-4bb2-9fa4-9e52742405fc");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c5bcfc96-55c6-4c9f-9dc5-298e6eadf68a");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "42b90020-0474-430c-bfe0-1d689665511b", "e74f7097-2458-4d9d-91d0-e02dc6d281c2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fff827f6-19ab-4f69-814c-d32e243f7aeb", "16a7ec8e-f442-4ce9-879a-df23715194a5", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "42b90020-0474-430c-bfe0-1d689665511b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fff827f6-19ab-4f69-814c-d32e243f7aeb");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31befd07-85b4-4bb2-9fa4-9e52742405fc", "b8b85d77-88dc-4e43-b0e3-dca92d1850b8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5bcfc96-55c6-4c9f-9dc5-298e6eadf68a", "e2a023e4-93b3-4dac-b2a4-127249f935c4", "User", "USER" });
        }
    }
}
