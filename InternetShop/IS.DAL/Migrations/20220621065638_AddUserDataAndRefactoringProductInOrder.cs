using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class AddUserDataAndRefactoringProductInOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "18ac56b5-68a0-43b7-98e7-68b3e0a17fea");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "bf24f7b9-369d-44ef-8d0f-b72d68143804");

            migrationBuilder.DropColumn(
                name: "AddressToDelivery",
                table: "productInOrderEntities");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "productInOrderEntities");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "productInOrderEntities");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "productInOrderEntities");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "productInOrderEntities",
                newName: "UserDataId");

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
                values: new object[] { "18809de1-15ed-4208-9d88-5f4edb07b0b4", "83724447-1096-4c04-9eba-d6d5f4239d83", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "688e7e81-478a-47ea-86e9-430dbba5f8b4", "6de5a7e8-938c-494e-92fc-39bb77216aed", "User", "USER" });

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
                keyValue: "18809de1-15ed-4208-9d88-5f4edb07b0b4");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "688e7e81-478a-47ea-86e9-430dbba5f8b4");

            migrationBuilder.RenameColumn(
                name: "UserDataId",
                table: "productInOrderEntities",
                newName: "UserId");

            migrationBuilder.AddColumn<string>(
                name: "AddressToDelivery",
                table: "productInOrderEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "productInOrderEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "productInOrderEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "productInOrderEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "18ac56b5-68a0-43b7-98e7-68b3e0a17fea", "82a9290c-03d2-4aaa-b285-540646436136", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf24f7b9-369d-44ef-8d0f-b72d68143804", "dc22312d-09f9-4c54-be67-f67e9f766254", "User", "USER" });
        }
    }
}
