using System.Data.Entity.ModelConfiguration;
using Gestao.Domain.Entities;

namespace Gestao.Infra.Data.EntityConfig
{
    public class CidadeConfiguration : EntityTypeConfiguration<Cidade>
    {
        public CidadeConfiguration()
        {
            HasKey(c => c.id);


            Property(c => c.NomeCidade)
                .IsRequired();
            Property(c => c.Estado)
                .IsRequired();
            Property(c => c.Cep)
                .IsRequired();

            ToTable("Cidades");
        }
    }
}
