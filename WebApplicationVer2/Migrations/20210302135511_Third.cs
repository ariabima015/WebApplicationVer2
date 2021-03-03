using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationVer2.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_Groups_GroupId",
                table: "Warehouses");

            migrationBuilder.DropIndex(
                name: "IX_Warehouses_GroupId",
                table: "Warehouses");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "Warehouses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_GroupId",
                table: "Warehouses",
                column: "GroupId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_Groups_GroupId",
                table: "Warehouses",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_Groups_GroupId",
                table: "Warehouses");

            migrationBuilder.DropIndex(
                name: "IX_Warehouses_GroupId",
                table: "Warehouses");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "Warehouses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_GroupId",
                table: "Warehouses",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_Groups_GroupId",
                table: "Warehouses",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
