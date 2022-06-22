using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Avanade.Academia.PcD.Infra.Database.Migrations
{
    public partial class AddPeriodo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Periodo",
                table: "TblProfessor",
                newName: "turno");

            migrationBuilder.AlterColumn<string>(
                name: "turno",
                table: "TblProfessor",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "turno",
                table: "TblProfessor",
                newName: "Periodo");

            migrationBuilder.AlterColumn<int>(
                name: "Periodo",
                table: "TblProfessor",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);
        }
    }
}
