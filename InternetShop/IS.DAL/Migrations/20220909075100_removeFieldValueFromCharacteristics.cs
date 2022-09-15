using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class removeFieldValueFromCharacteristics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "76c29573-63e2-46ca-a671-b64ff60dcfbd");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9fa7b352-372b-4737-bbe0-9bf568190dea");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Characteristics");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "6cba03ba-20f1-497e-9747-6328f783e853",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "5f2d2272-b784-4402-be64-0b5e36dd84c4");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d3dc4e2-52a0-44b5-a3a8-f418536563ff", "e37bd8c3-b1b7-435e-ab4c-b9c676e2fbfc", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2293eee-1ceb-480a-9027-5134b0ade2c5", "76012d2d-62d2-4500-b53e-9a5aa59c6bbf", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9d3dc4e2-52a0-44b5-a3a8-f418536563ff");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b2293eee-1ceb-480a-9027-5134b0ade2c5");

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "Characteristics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "5f2d2272-b784-4402-be64-0b5e36dd84c4",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "6cba03ba-20f1-497e-9747-6328f783e853");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "76c29573-63e2-46ca-a671-b64ff60dcfbd", "08f025be-52c0-4dec-9ea4-4312d6434483", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9fa7b352-372b-4737-bbe0-9bf568190dea", "17b3c59d-a86f-4166-b361-c0af69eca7d4", "User", "USER" });
        }
    }
}
