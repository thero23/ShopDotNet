using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class ChangeEntityToBuyinOneClick : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "18bbd3a7-eaf8-4f86-8fdf-cddee3118009");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9c616e47-0d85-4138-a2b0-c5d072d195ff");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BuyInOneClick");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "BuyInOneClick",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2a092d8f-ee11-45bf-b77c-ad3407fabda3", "2d4c040e-b4e6-4fa4-ba26-420174264094", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "42696d61-e612-44ce-997a-62a883499580", "d350a6f0-a4ea-4142-952d-b664b1467029", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2a092d8f-ee11-45bf-b77c-ad3407fabda3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "42696d61-e612-44ce-997a-62a883499580");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "BuyInOneClick");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "BuyInOneClick",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "18bbd3a7-eaf8-4f86-8fdf-cddee3118009", "25ae8fc1-9c66-455d-b882-dd562e559bee", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9c616e47-0d85-4138-a2b0-c5d072d195ff", "466d5276-470c-4299-b2ee-26d0f4f91a09", "User", "USER" });
        }
    }
}
