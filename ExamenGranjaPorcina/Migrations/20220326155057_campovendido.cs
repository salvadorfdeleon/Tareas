using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamenGranjaPorcina.Migrations
{
    public partial class campovendido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Vendido",
                table: "Cerdo",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vendido",
                table: "Cerdo");
        }
    }
}
