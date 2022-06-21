using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class SomethingChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressToDelivery = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDataEntity", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89e00057-5f98-478b-a372-22995a1f0a0e", "80cceef5-d86c-4e4a-b9e0-1dfdf2284bfa", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5fcb0ce-8590-4b1d-bd36-dd9f7b2e1911", "27fbe523-09bf-4536-aff8-a16e9373afb6", "User", "USER" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: "89e00057-5f98-478b-a372-22995a1f0a0e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d5fcb0ce-8590-4b1d-bd36-dd9f7b2e1911");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "17b9d804-07be-4965-9ea3-63ebd737b3d0", "bc05decc-9ecf-4dff-9b50-944023ee5f4c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "23de9470-5253-4aca-a331-5a51604de95e", "58526e78-d6cd-4192-abd8-68a6b2c40c2e", "User", "USER" });
        }
    }
}
