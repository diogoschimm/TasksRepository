using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrabalhandoComTasks.Domain.Entities;

namespace TrabalhandoComTasks.Data.Mappings
{
    public class GrupoPessoaMapping : IEntityTypeConfiguration<GrupoPessoa>
    {
        public void Configure(EntityTypeBuilder<GrupoPessoa> builder)
        {
            builder.ToTable("GrupoPessoa");
            builder.HasKey(g => g.IdGrupoPessoa).HasName("pk_grupoPessoa");

            builder.Property(g => g.IdGrupoPessoa).HasColumnName("idGrupoPessoa");
            builder.Property(p => p.NomeGrupo).HasColumnName("nomeGrupo");

        }
    }
}
