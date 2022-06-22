using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Avanade.Academia.PcD.Infra.Database.Migrations
{
    public partial class AddUpdateModelv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeProfessor",
                table: "TblProfessor",
                type: "varchar(400)",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Periodo",
                table: "TblProfessor",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Periodo",
                table: "TblProfessor");

            migrationBuilder.AlterColumn<string>(
                name: "NomeProfessor",
                table: "TblProfessor",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(400)",
                oldMaxLength: 400);
        }
    }
}
