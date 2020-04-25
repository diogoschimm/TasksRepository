using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrabalhandoComTasks.Domain.Entities;

namespace TrabalhandoComTasks.Data.Mappings
{
    public class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoa");
            builder.HasKey(p => p.IdPessoa).HasName("pk_pessoa");
            
            builder.Property(p => p.IdPessoa).HasColumnName("idPessoa");
            builder.Property(p => p.NomePessoa).HasColumnName("nomePessoa");

            builder.OwnsOne(p => p.Documento, c =>
            {
                c.Property(d => d.TipoDocumento).HasColumnName("tipoDocumento");
                c.Property(d => d.NumeroDocumento).HasColumnName("numeroDocumento");
            });

            builder.HasOne(p => p.GrupoPessoa)
                .WithMany(g => g.Pessoas)
                .HasForeignKey(p => p.IdGrupoPessoa)
                .HasConstraintName("fk_pessoa_grupoPessoa");

            builder.Property(p => p.IdGrupoPessoa).HasColumnName("idGrupoPessoa");
        }
    }
}
