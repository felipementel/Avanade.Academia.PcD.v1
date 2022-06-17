using Avanade.Academia.PcD.Domain.Entities;
using Avanade.Academia.PcD.Infra.Database.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Avanade.Academia.PcD.Infra.Database
{
    public class ProjetoContext : DbContext
    {
        public ProjetoContext(DbContextOptions<ProjetoContext> options)
        : base(options)
        {
        }

        public ProjetoContext()
        {

        }

        public DbSet<Professor> Professores { get; set; }

        //public DbSet<Curso> Cursos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Persist Security Info=False;User ID=sa;Initial Catalog=DesafioAvanade;Data Source=localhost:1433");

            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new BaseEntityTypeConfiguration().Configure(modelBuilder.Entity<BaseEntity>());
            new ProfessorEntityTypeConfiguration().Configure(modelBuilder.Entity<Professor>());

            base.OnModelCreating(modelBuilder);
        }
    }
}