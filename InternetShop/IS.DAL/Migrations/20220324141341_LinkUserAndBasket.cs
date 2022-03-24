using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class LinkUserAndBasket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "139948ab-4c9d-44fb-8237-2b1ba2d251e4");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "739844fe-2fc6-4fe8-b00e-d619f7d9cb3c");

            migrationBuilder.AddColumn<string>(
                name: "UserRef",
                table: "Baskets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d381d823-1459-4445-a445-e971a2a38550", "553d2501-100a-43a2-84ba-336319183011", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e708dd5c-ac0f-45a5-8964-48942eb59647", "db8af426-58eb-403b-bd78-233ae66b6d98", "Visitor", "VISITOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_UserRef",
                table: "Baskets",
                column: "UserRef",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Users_UserRef",
                table: "Baskets",
                column: "UserRef",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Users_UserRef",
                table: "Baskets");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_UserRef",
                table: "Baskets");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d381d823-1459-4445-a445-e971a2a38550");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e708dd5c-ac0f-45a5-8964-48942eb59647");

            migrationBuilder.DropColumn(
                name: "UserRef",
                table: "Baskets");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "139948ab-4c9d-44fb-8237-2b1ba2d251e4", "de4ed99e-9438-4407-b602-a8866608be2b", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "739844fe-2fc6-4fe8-b00e-d619f7d9cb3c", "2d3ee19d-712f-4eca-b7db-d4770bcbe21f", "Administrator", "ADMINISTRATOR" });
        }
    }
}
