using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entityBasicoDAL.Migrations
{
    public partial class versionpruebafk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_nivel_accesos_empleados_empleadoId",
                table: "nivel_accesos");

            migrationBuilder.DropIndex(
                name: "IX_nivel_accesos_empleadoId",
                table: "nivel_accesos");

            migrationBuilder.DropColumn(
                name: "empleadoId",
                table: "nivel_accesos");

            migrationBuilder.AddColumn<int>(
                name: "nivel_accId",
                table: "empleados",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_empleados_nivel_accId",
                table: "empleados",
                column: "nivel_accId");

            migrationBuilder.AddForeignKey(
                name: "FK_empleados_nivel_accesos_nivel_accId",
                table: "empleados",
                column: "nivel_accId",
                principalTable: "nivel_accesos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_empleados_nivel_accesos_nivel_accId",
                table: "empleados");

            migrationBuilder.DropIndex(
                name: "IX_empleados_nivel_accId",
                table: "empleados");

            migrationBuilder.DropColumn(
                name: "nivel_accId",
                table: "empleados");

            migrationBuilder.AddColumn<int>(
                name: "empleadoId",
                table: "nivel_accesos",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_nivel_accesos_empleadoId",
                table: "nivel_accesos",
                column: "empleadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_nivel_accesos_empleados_empleadoId",
                table: "nivel_accesos",
                column: "empleadoId",
                principalTable: "empleados",
                principalColumn: "Id");
        }
    }
}
