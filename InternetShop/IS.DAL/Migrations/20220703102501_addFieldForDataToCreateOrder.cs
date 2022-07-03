using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class addFieldForDataToCreateOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "42b90020-0474-430c-bfe0-1d689665511b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fff827f6-19ab-4f69-814c-d32e243f7aeb");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "productInOrderEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2bd3d53c-929e-499f-b5ae-8bf0da19d439", "00011076-3119-4e33-9e22-e56d48a7fad8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c49a1b45-9209-4f1b-999b-3f5a9bd92af0", "66e67120-688a-46d1-87ef-0ed607932034", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2bd3d53c-929e-499f-b5ae-8bf0da19d439");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c49a1b45-9209-4f1b-999b-3f5a9bd92af0");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "productInOrderEntities");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "42b90020-0474-430c-bfe0-1d689665511b", "e74f7097-2458-4d9d-91d0-e02dc6d281c2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fff827f6-19ab-4f69-814c-d32e243f7aeb", "16a7ec8e-f442-4ce9-879a-df23715194a5", "User", "USER" });
        }
    }
}
