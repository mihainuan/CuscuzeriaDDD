using Microsoft.EntityFrameworkCore.Migrations;

namespace Cuscuzeria.Infra.Data.Migrations
{
    public partial class OneToOneRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Orders_CuscuzeiroId",
                table: "Orders",
                column: "CuscuzeiroId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Cuscuzeiros_CuscuzeiroId",
                table: "Orders",
                column: "CuscuzeiroId",
                principalTable: "Cuscuzeiros",
                principalColumn: "CuscuzeiroId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Cuscuzeiros_CuscuzeiroId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CuscuzeiroId",
                table: "Orders");
        }
    }
}
