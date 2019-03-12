using Microsoft.EntityFrameworkCore.Migrations;

namespace Cuscuzeria.Infra.Data.Migrations
{
    public partial class OneToManyRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Cuscuz",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cuscuz_OrderId",
                table: "Cuscuz",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuscuz_Orders_OrderId",
                table: "Cuscuz",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuscuz_Orders_OrderId",
                table: "Cuscuz");

            migrationBuilder.DropIndex(
                name: "IX_Cuscuz_OrderId",
                table: "Cuscuz");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Cuscuz");
        }
    }
}
