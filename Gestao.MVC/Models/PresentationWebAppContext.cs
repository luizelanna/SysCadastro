using System.Data.Entity;

namespace Gestao.MVC.Models
{
    public class PresentationWebAppContext : DbContext
    {
        public PresentationWebAppContext() : base("name=PresentationWebAppContext")
        {
        }

        public DbSet<Application.ViewModels.CidadesViewModel> CidadeViewModels
        {
            get;
            set;
        }

        public DbSet<Application.ViewModels.TipoPessoasViewModel> TipoPessoaViewModels
        {
            get;
            set;
        }

        public DbSet<Application.ViewModels.PessoasViewModel> PessoasViewModels
        {
            get;
            set;
        }
    }
}