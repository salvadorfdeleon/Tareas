using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamenGranjaPorcina.Migrations
{
    public partial class ventascerditos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CerdoId",
                table: "Ventas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_CerdoId",
                table: "Ventas",
                column: "CerdoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Cerdo_CerdoId",
                table: "Ventas",
                column: "CerdoId",
                principalTable: "Cerdo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Cerdo_CerdoId",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_CerdoId",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "CerdoId",
                table: "Ventas");
        }
    }
}
