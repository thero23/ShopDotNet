using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class changeUserDataEntityToUserEntityInProductInOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productInOrderEntities_UserDataEntity_UserDataId",
                table: "productInOrderEntities");

            migrationBuilder.DropTable(
                name: "UserDataEntity");

            migrationBuilder.DropIndex(
                name: "IX_productInOrderEntities_UserDataId",
                table: "productInOrderEntities");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e714002c-844f-4827-957e-1955ab47d2c5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f0de5644-d9d9-41ab-b250-99e32dfb029a");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "productInOrderEntities",
                type: "nvarchar(450)",
                nullable: true);

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
                keyValue: "7489a1ed-c6ea-407e-85b0-11a28628688a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "936d9c77-f8ce-4b23-b92f-5c1714df1ee1");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "productInOrderEntities");

            migrationBuilder.CreateTable(
                name: "UserDataEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressToDelivery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDataEntity", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e714002c-844f-4827-957e-1955ab47d2c5", "9a53f39e-de25-42e5-a02a-cca8c399f4d4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0de5644-d9d9-41ab-b250-99e32dfb029a", "385f94ca-b3e7-4c3b-b72a-001871e43c5b", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_productInOrderEntities_UserDataId",
                table: "productInOrderEntities",
                column: "UserDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_productInOrderEntities_UserDataEntity_UserDataId",
                table: "productInOrderEntities",
                column: "UserDataId",
                principalTable: "UserDataEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
