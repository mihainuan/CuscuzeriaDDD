using Microsoft.EntityFrameworkCore.Migrations;

namespace Cuscuzeria.Infra.Data.Migrations
{
    public partial class FinishedRelationshipsForReal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accompaniments_Cuscuz_CuscuzId",
                table: "Accompaniments");

            migrationBuilder.DropForeignKey(
                name: "FK_Promos_Orders_OrderId",
                table: "Promos");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Promos",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Cuscuzeiros",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CuscuzId",
                table: "Accompaniments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Accompaniments_Cuscuz_CuscuzId",
                table: "Accompaniments",
                column: "CuscuzId",
                principalTable: "Cuscuz",
                principalColumn: "CuscuzId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Promos_Orders_OrderId",
                table: "Promos",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accompaniments_Cuscuz_CuscuzId",
                table: "Accompaniments");

            migrationBuilder.DropForeignKey(
                name: "FK_Promos_Orders_OrderId",
                table: "Promos");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Cuscuzeiros");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Promos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CuscuzId",
                table: "Accompaniments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Accompaniments_Cuscuz_CuscuzId",
                table: "Accompaniments",
                column: "CuscuzId",
                principalTable: "Cuscuz",
                principalColumn: "CuscuzId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Promos_Orders_OrderId",
                table: "Promos",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
