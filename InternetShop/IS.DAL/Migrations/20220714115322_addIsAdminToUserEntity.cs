using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class addIsAdminToUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "726b44eb-e236-46e1-80f2-34d201a0fe1f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7507dfac-0ba6-451a-b0c6-01ee55632b50");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "657a99aa-63e0-4fdc-a071-6efd98706333",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "9c6c263c-b4fe-42b8-a2b0-532b2502903a");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c55ee4d7-839b-42ef-8dad-e7d98cbc0ed1", "df1881f5-ba2b-4747-9334-9b3468b87b13", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c7024daa-011b-4fcc-bca9-5ee80ef32b6e", "61612de3-7ec7-4874-ba50-5a8a89f819b3", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c55ee4d7-839b-42ef-8dad-e7d98cbc0ed1");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c7024daa-011b-4fcc-bca9-5ee80ef32b6e");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "9c6c263c-b4fe-42b8-a2b0-532b2502903a",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldDefaultValue: "657a99aa-63e0-4fdc-a071-6efd98706333");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "726b44eb-e236-46e1-80f2-34d201a0fe1f", "0546cf51-022f-450f-8cfb-d705bb22a59b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7507dfac-0ba6-451a-b0c6-01ee55632b50", "6e60c218-0336-4a2e-ad36-4f2031ee3536", "User", "USER" });
        }
    }
}
