using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class deleteuserIdFieldInProductInOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5183f406-2758-48e0-b07c-6f5fb3002d4e", "ec96a72b-c1a6-49af-972a-0e07b9ecafaf", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a31ed0fc-952e-4964-b96c-a37a9482838c", "10c4e184-c16d-4fcf-8951-e6f6cc769446", "User", "USER" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: "5183f406-2758-48e0-b07c-6f5fb3002d4e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a31ed0fc-952e-4964-b96c-a37a9482838c");

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
    }
}
