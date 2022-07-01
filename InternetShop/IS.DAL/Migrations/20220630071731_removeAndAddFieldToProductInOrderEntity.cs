using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class removeAndAddFieldToProductInOrderEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productInOrderEntities_Users_UserId",
                table: "productInOrderEntities");

            migrationBuilder.DropIndex(
                name: "IX_productInOrderEntities_UserId",
                table: "productInOrderEntities");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2a092d8f-ee11-45bf-b77c-ad3407fabda3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "42696d61-e612-44ce-997a-62a883499580");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "productInOrderEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb627032-ff57-4c77-b687-7fb45d207066", "33786001-1268-4574-b4e8-16491ac6367a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef8411ba-8958-4c54-9b9b-13eafb7cfa94", "9d928315-b2c3-4a23-bb79-e9a49525abb1", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cb627032-ff57-4c77-b687-7fb45d207066");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ef8411ba-8958-4c54-9b9b-13eafb7cfa94");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "productInOrderEntities",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2a092d8f-ee11-45bf-b77c-ad3407fabda3", "2d4c040e-b4e6-4fa4-ba26-420174264094", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "42696d61-e612-44ce-997a-62a883499580", "d350a6f0-a4ea-4142-952d-b664b1467029", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_productInOrderEntities_UserId",
                table: "productInOrderEntities",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_productInOrderEntities_Users_UserId",
                table: "productInOrderEntities",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
