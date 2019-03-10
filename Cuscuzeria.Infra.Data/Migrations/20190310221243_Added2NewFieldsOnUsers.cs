using Microsoft.EntityFrameworkCore.Migrations;

namespace Cuscuzeria.Infra.Data.Migrations
{
    public partial class Added2NewFieldsOnUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Prop1",
                table: "Usuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Prop2",
                table: "Usuarios",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prop1",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Prop2",
                table: "Usuarios");
        }
    }
}
