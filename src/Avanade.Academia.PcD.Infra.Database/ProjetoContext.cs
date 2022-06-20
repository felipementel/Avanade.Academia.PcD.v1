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

        public DbSet<Professor> Professores { get; set; }
        //public DbSet<Curso> Cursos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source='localhost, 1433';User ID=sa;Database=Avanade; Password=yourStrong@Password;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //new BaseEntityTypeConfiguration().Configure(modelBuilder.Entity<BaseEntity>());
            //new ProfessorEntityTypeConfiguration().Configure(modelBuilder.Entity<Professor>());

            modelBuilder.ApplyConfiguration(new ProfessorEntityTypeConfiguration());

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}