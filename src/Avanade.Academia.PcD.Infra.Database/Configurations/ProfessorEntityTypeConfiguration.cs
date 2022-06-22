using Avanade.Academia.PcD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Avanade.Academia.PcD.Domain.ValueObject.Enumerators;

namespace Avanade.Academia.PcD.Infra.Database.Configurations
{
    public class ProfessorEntityTypeConfiguration : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder
                .ToTable("TblProfessor");

            builder
                .Property(x => x.Nome)
                .HasColumnName("NomeProfessor")
                .HasMaxLength(400)
                .HasColumnType<string>("varchar(300)")
                .IsRequired();

            builder
                .Property(x => x.Salario)
                .HasColumnName("SalarioProfessor")
                .HasColumnType("decimal(10,2)")
                .IsRequired();

            builder
               .Property(x => x.Periodo)
               .HasColumnName("Turno")
               .HasMaxLength(100)
               .HasColumnType<Periodo>("varchar(50)")
               .IsRequired()
               .HasConversion(
               s => s.ToString(),
               s => (Periodo)Enum.Parse(typeof(Periodo), s));
        }
    }
}
