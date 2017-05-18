

using System.Data.Entity.ModelConfiguration;
using Gestao.Domain.Entities;

namespace Gestao.Infra.Data.EntityConfig
{
    public class PessoaConfiguration : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfiguration()
        {
            HasKey(c => c.id);

            Property(c => c.Bairro);

            Property(c => c.Celular1);

            Property(c => c.Celular2);

            Property(c => c.Cep);

            Property(c => c.Cidade);
            Property(c => c.Complemento);
            Property(c => c.Cpf);
            Property(c => c.DataAlteração)
                .HasColumnType("datetime");
            Property(c => c.DataCadastro)
                .HasColumnType("datetime");
            Property(c => c.DataNascimento)
                .HasColumnType("datetime");
            Property(c => c.Estado);
            Property(c => c.Idade);
            Property(c => c.Logradouro);
            Property(c => c.Matricula);
            Property(c => c.Nome)
                .IsRequired();
            Property(c => c.Numero);
            Property(c => c.Complemento);
            Property(c => c.Sexo);
            Property(c => c.Rg);
            Property(c => c.Telefone);
            Property(c => c.idPessoa);
            Property(c => c.Profissao);
            Property(c => c.idTpoPessoa);
            Property(c => c.idUsuarioUpdate);

            ToTable("Pessoas");


        }

    }
}
