using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class DeleteUserDataEntityFromProductInOrderEntity : Migration
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
                keyValue: "38153bf3-f7f3-426a-8a06-d7c00c32d49d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6a0b9f9a-0847-4807-9329-c551ac58d5a9");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "17b9d804-07be-4965-9ea3-63ebd737b3d0", "bc05decc-9ecf-4dff-9b50-944023ee5f4c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "23de9470-5253-4aca-a331-5a51604de95e", "58526e78-d6cd-4192-abd8-68a6b2c40c2e", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "17b9d804-07be-4965-9ea3-63ebd737b3d0");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "23de9470-5253-4aca-a331-5a51604de95e");

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
                values: new object[] { "38153bf3-f7f3-426a-8a06-d7c00c32d49d", "28d86be3-5b8e-4699-96cf-080829f3a7f8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6a0b9f9a-0847-4807-9329-c551ac58d5a9", "a0f59ab7-a5d5-4a37-9dc4-ff79a006f6f8", "User", "USER" });

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
