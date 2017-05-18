using CrossCutting.Identity.Configuration;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using CrossCutting.Identity.Context;
using CrossCutting.Identity.Model;
using SimpleInjector;
using Gestao.Application.Interfaces;
using Gestao.Application.Servicos;
using Gestao.Domain.Interfaces.Repositotories;
using Gestao.Domain.Interfaces.Services;
using Gestao.Domain.Services;
using Gestao.Infra.Data.Interface;
using Gestao.Infra.Data.Repositories;
using Gestao.Infra.Data.UnitofWork;

namespace CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            container.Register<ICidadeRepository, CidadeRepository>(Lifestyle.Scoped);
            container.Register<IPessoaRepository, PessoaRepository>(Lifestyle.Scoped);
            container.Register<ITipoPessoaRepository, TipoPessoaRepository>(Lifestyle.Scoped);

            container.Register<ICIdadeAppServicos, CidadeAppServicos>(Lifestyle.Scoped);
            container.Register<IPessoaAppServicos, PessoaAppServicos>(Lifestyle.Scoped);
            container.Register<ITipoPessoaAppServicos, TipoPessoaAppServicos>(Lifestyle.Scoped);

            container.Register<ICidadeService, CidadeService>(Lifestyle.Scoped);
            container.Register<IPessoaService, PessoaService>(Lifestyle.Scoped);
            container.Register<ITipoPessoaService, TipoPessoaService>(Lifestyle.Scoped);

            container.Register<IUnitofWork, UnitofWork>(Lifestyle.Scoped);


            //Identity
            container.Register<ApplicationDbContext>(Lifestyle.Scoped);
            container.Register<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()));
            container.Register<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>());
            container.Register<ApplicationRoleManager>(Lifestyle.Scoped);
            container.Register<ApplicationUserManager>(Lifestyle.Scoped);
            container.Register<ApplicationSignInManager>(Lifestyle.Scoped);

        }
    }
}