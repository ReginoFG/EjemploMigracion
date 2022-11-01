using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entityBasicoDAL.Migrations
{
    public partial class _101DataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "desc_acceso",
                table: "nivel_accesos",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "desc_acceso",
                table: "nivel_accesos");
        }
    }
}
