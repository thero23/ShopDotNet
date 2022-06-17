using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class addRateToProduct : Migration
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

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "128dacc2-c031-4531-acc8-0d3b9f9b544c", "a28d863c-20cd-4ffc-9e87-b6296efa084d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e73b1de-1eff-4d90-ad9e-7e2b926c225a", "e465a430-5b9d-4666-b1a5-2499731d17e3", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "128dacc2-c031-4531-acc8-0d3b9f9b544c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6e73b1de-1eff-4d90-ad9e-7e2b926c225a");

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
