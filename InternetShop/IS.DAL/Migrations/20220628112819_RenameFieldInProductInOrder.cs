using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class RenameFieldInProductInOrder : Migration
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
                keyValue: "7489a1ed-c6ea-407e-85b0-11a28628688a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "936d9c77-f8ce-4b23-b92f-5c1714df1ee1");

            migrationBuilder.DropColumn(
                name: "UserDataId",
                table: "productInOrderEntities");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "productInOrderEntities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "productInOrderEntities",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "29c8dc9d-715d-4f89-87af-221fec4071ff", "600bfdc4-78ac-402e-8263-6c3dfbb64d59", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e43c2dc2-81c7-434f-84da-01a8a1329f44", "7750f6d7-ab1c-4e68-a67f-52c897c96d5b", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_productInOrderEntities_UserId1",
                table: "productInOrderEntities",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_productInOrderEntities_Users_UserId1",
                table: "productInOrderEntities",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productInOrderEntities_Users_UserId1",
                table: "productInOrderEntities");

            migrationBuilder.DropIndex(
                name: "IX_productInOrderEntities_UserId1",
                table: "productInOrderEntities");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "29c8dc9d-715d-4f89-87af-221fec4071ff");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e43c2dc2-81c7-434f-84da-01a8a1329f44");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "productInOrderEntities");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "productInOrderEntities",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "UserDataId",
                table: "productInOrderEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7489a1ed-c6ea-407e-85b0-11a28628688a", "d1c17fd8-bbb4-44c5-a5d7-6bad17e12872", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "936d9c77-f8ce-4b23-b92f-5c1714df1ee1", "073f51cd-4685-4bc1-92f2-db349700bf25", "User", "USER" });

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
