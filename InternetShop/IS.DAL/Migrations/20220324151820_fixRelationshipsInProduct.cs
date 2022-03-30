using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class fixRelationshipsInProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Users_UserRef",
                table: "Baskets");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "395989ee-286f-41ba-9c4c-b786d77d988f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a85f3c69-123b-4c53-8759-94b26e4f07d1");

            migrationBuilder.RenameColumn(
                name: "UserRef",
                table: "Baskets",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Baskets_UserRef",
                table: "Baskets",
                newName: "IX_Baskets_UserId");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "510bc559-0ece-4c4a-8c49-4ac1a04e91ad", "91fc8dd1-00e8-4910-b56a-0504a1e06389", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba63a7ff-365d-4236-84e3-f97875a8d979", "d09b1bf5-7735-4818-b8a7-8bc04f257bb7", "Visitor", "VISITOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Users_UserId",
                table: "Baskets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Users_UserId",
                table: "Baskets");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "510bc559-0ece-4c4a-8c49-4ac1a04e91ad");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ba63a7ff-365d-4236-84e3-f97875a8d979");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Baskets",
                newName: "UserRef");

            migrationBuilder.RenameIndex(
                name: "IX_Baskets_UserId",
                table: "Baskets",
                newName: "IX_Baskets_UserRef");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "395989ee-286f-41ba-9c4c-b786d77d988f", "4abd0c42-9336-4d1b-b776-217371624bf9", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a85f3c69-123b-4c53-8759-94b26e4f07d1", "a737c77d-9b4c-4bc9-99d0-2c4a3b183f27", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Users_UserRef",
                table: "Baskets",
                column: "UserRef",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
