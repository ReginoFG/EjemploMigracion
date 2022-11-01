using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entityBasicoDAL.Migrations
{
    public partial class versiontablarelacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "empleadonivel_acc",
                columns: table => new
                {
                    empleadosId = table.Column<int>(type: "integer", nullable: false),
                    nivel_accesosId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleadonivel_acc", x => new { x.empleadosId, x.nivel_accesosId });
                    table.ForeignKey(
                        name: "FK_empleadonivel_acc_empleados_empleadosId",
                        column: x => x.empleadosId,
                        principalTable: "empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_empleadonivel_acc_nivel_accesos_nivel_accesosId",
                        column: x => x.nivel_accesosId,
                        principalTable: "nivel_accesos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_empleadonivel_acc_nivel_accesosId",
                table: "empleadonivel_acc",
                column: "nivel_accesosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "empleadonivel_acc");

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
    }
}
