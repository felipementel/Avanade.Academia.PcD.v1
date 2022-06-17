using Avanade.Academia.PcD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avanade.Academia.PcD.Infra.Database.Configurations
{
    public class ProfessorEntityTypeConfiguration : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("TblProfessor");

            builder
                .Property(x => x.Nome)
                .HasColumnName("NomeProfessor");

            builder
                .Property(x => x.Salario)
                .HasColumnName("SalarioProfessor");
        }
    }
}
