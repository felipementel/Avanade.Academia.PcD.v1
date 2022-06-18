using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Avanade.Academia.PcD.Infra.Database.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblProfessor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeProfessor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalarioProfessor = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblProfessor", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblProfessor");
        }
    }
}
