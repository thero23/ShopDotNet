using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IS.DAL.Migrations
{
    public partial class deleteProductId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2e4de8db-0470-4453-8a2e-a18d7e8c75a8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d5a185af-fc02-4ffc-94d0-7ec2d69e9c32");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "productInOrderEntities");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31befd07-85b4-4bb2-9fa4-9e52742405fc", "b8b85d77-88dc-4e43-b0e3-dca92d1850b8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5bcfc96-55c6-4c9f-9dc5-298e6eadf68a", "e2a023e4-93b3-4dac-b2a4-127249f935c4", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "31befd07-85b4-4bb2-9fa4-9e52742405fc");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c5bcfc96-55c6-4c9f-9dc5-298e6eadf68a");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "productInOrderEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e4de8db-0470-4453-8a2e-a18d7e8c75a8", "27033a88-bf0b-4a78-b11d-3b0f59962721", "User", "USER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5a185af-fc02-4ffc-94d0-7ec2d69e9c32", "93adc22d-c112-4356-a2ad-a3a834658533", "User", "USER" });
        }
    }
}
