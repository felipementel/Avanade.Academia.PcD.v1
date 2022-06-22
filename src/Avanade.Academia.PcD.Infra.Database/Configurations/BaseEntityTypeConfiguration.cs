using Avanade.Academia.PcD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avanade.Academia.PcD.Infra.Database.Configurations
{
    public class BaseEntityTypeConfiguration : IEntityTypeConfiguration<BaseEntity>
    {
        public void Configure(EntityTypeBuilder<BaseEntity> builder)
        {
            builder
                .HasKey(x => x.Id)
                .HasName("Identificador");

            //builder.Property(p => p.Id)
            //    .ValueGeneratedOnAdd();

            builder
                .Property(x => x.DataCriacao)
                .HasColumnName("DataCriacao")
                .HasDefaultValue(DateTime.Now)
                .HasColumnType("datetime")
                .IsRequired();

            builder
                .Property(x => x.DataAtualizacao)
                .HasColumnName("DataAtualizacao")
                .IsRequired(false);
        }
    }
}
