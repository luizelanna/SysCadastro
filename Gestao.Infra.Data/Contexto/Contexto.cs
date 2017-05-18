using System.Data.Entity;
using Gestao.Domain.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;
using Gestao.Infra.Data.EntityConfig;

namespace Gestao.Infra.Data.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto()
            : base("DefaultConnection")
        {

        }

        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<TipoPessoa> TipoPessoas { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Retirando algumas convencoes
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Configurando as chaves primarias
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            //Caso nao seja informado um tipo especifico em propriedades string, sera considerado como varchar
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            //Caso nao seja informado um tamanho maximo em propriedades string, sera considerado como 100
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            //Adicionando classes de configuração dos modelos FLUENT API
            modelBuilder.Configurations.Add(new CidadeConfiguration());
            modelBuilder.Configurations.Add(new TipoPessoaConfiguration());
            modelBuilder.Configurations.Add(new PessoaConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
