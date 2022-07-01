using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class AddNavPropertyToProductInOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2766f6b8-c24c-4bfe-928d-f2f75493c538");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c5f6b057-f55b-4a13-a744-408fb5a319a7");

            migrationBuilder.AddColumn<int>(
                name: "ProductEntityId",
                table: "productInOrderEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59f0fee4-2783-41da-bc50-236677c600c3", "6b23c6a8-0531-4d6f-b3c5-5a4967c9de85", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a9c03211-0d79-4897-bdb8-76e124e4af02", "dca1a159-e256-488e-96f1-09dadccfc5d1", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_productInOrderEntities_ProductEntityId",
                table: "productInOrderEntities",
                column: "ProductEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_productInOrderEntities_Products_ProductEntityId",
                table: "productInOrderEntities",
                column: "ProductEntityId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productInOrderEntities_Products_ProductEntityId",
                table: "productInOrderEntities");

            migrationBuilder.DropIndex(
                name: "IX_productInOrderEntities_ProductEntityId",
                table: "productInOrderEntities");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "59f0fee4-2783-41da-bc50-236677c600c3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a9c03211-0d79-4897-bdb8-76e124e4af02");

            migrationBuilder.DropColumn(
                name: "ProductEntityId",
                table: "productInOrderEntities");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2766f6b8-c24c-4bfe-928d-f2f75493c538", "67e0be1e-70f1-403a-af2b-3ec985712266", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5f6b057-f55b-4a13-a744-408fb5a319a7", "325281c4-1412-44ec-843d-ec926ff3debe", "User", "USER" });
        }
    }
}
