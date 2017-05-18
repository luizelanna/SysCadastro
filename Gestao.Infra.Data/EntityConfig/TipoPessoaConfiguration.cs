using System.Data.Entity.ModelConfiguration;
using Gestao.Domain.Entities;

namespace Gestao.Infra.Data.EntityConfig
{
    public class TipoPessoaConfiguration : EntityTypeConfiguration<TipoPessoa>
    {
        public TipoPessoaConfiguration()
        {
            HasKey(c => c.id);

            Property(c => c.Descricao)
                .IsRequired();

            ToTable("TipoPessoas");

        }

    }
}
