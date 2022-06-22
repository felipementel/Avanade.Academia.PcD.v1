using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Avanade.Academia.PcD.Infra.Database.Migrations
{
    public partial class UpdateDecimalSalario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "SalarioProfessor",
                table: "TblProfessor",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "SalarioProfessor",
                table: "TblProfessor",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");
        }
    }
}
