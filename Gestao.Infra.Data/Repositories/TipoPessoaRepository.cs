using Gestao.Domain.Entities;
using Gestao.Domain.Interfaces.Repositotories;
using Gestao.Infra.Data.Contexto;

namespace Gestao.Infra.Data.Repositories
{
    public class TipoPessoaRepository : RepositoryBase<TipoPessoa>, ITipoPessoaRepository
    {
        public TipoPessoaRepository(ProfissionalContext context) : base(context)
        {
        }
    }
}
