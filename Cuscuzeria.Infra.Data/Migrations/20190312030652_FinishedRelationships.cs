using Microsoft.EntityFrameworkCore.Migrations;

namespace Cuscuzeria.Infra.Data.Migrations
{
    public partial class FinishedRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Promos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Drinks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Beverages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CuscuzId",
                table: "Accompaniments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Promos_OrderId",
                table: "Promos",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_OrderId",
                table: "Drinks",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Cuscuz_TypeId",
                table: "Cuscuz",
                column: "TypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Beverages_OrderId",
                table: "Beverages",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Accompaniments_CuscuzId",
                table: "Accompaniments",
                column: "CuscuzId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accompaniments_Cuscuz_CuscuzId",
                table: "Accompaniments",
                column: "CuscuzId",
                principalTable: "Cuscuz",
                principalColumn: "CuscuzId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Beverages_Orders_OrderId",
                table: "Beverages",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cuscuz_Types_TypeId",
                table: "Cuscuz",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Drinks_Orders_OrderId",
                table: "Drinks",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Usuarios_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Usuarios",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Promos_Orders_OrderId",
                table: "Promos",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accompaniments_Cuscuz_CuscuzId",
                table: "Accompaniments");

            migrationBuilder.DropForeignKey(
                name: "FK_Beverages_Orders_OrderId",
                table: "Beverages");

            migrationBuilder.DropForeignKey(
                name: "FK_Cuscuz_Types_TypeId",
                table: "Cuscuz");

            migrationBuilder.DropForeignKey(
                name: "FK_Drinks_Orders_OrderId",
                table: "Drinks");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Usuarios_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Promos_Orders_OrderId",
                table: "Promos");

            migrationBuilder.DropIndex(
                name: "IX_Promos_OrderId",
                table: "Promos");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Drinks_OrderId",
                table: "Drinks");

            migrationBuilder.DropIndex(
                name: "IX_Cuscuz_TypeId",
                table: "Cuscuz");

            migrationBuilder.DropIndex(
                name: "IX_Beverages_OrderId",
                table: "Beverages");

            migrationBuilder.DropIndex(
                name: "IX_Accompaniments_CuscuzId",
                table: "Accompaniments");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Promos");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Drinks");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Beverages");

            migrationBuilder.DropColumn(
                name: "CuscuzId",
                table: "Accompaniments");
        }
    }
}
