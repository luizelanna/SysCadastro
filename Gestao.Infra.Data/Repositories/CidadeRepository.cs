using System;
using Gestao.Domain.Entities;
using Gestao.Domain.Interfaces.Repositotories;
using Gestao.Infra.Data.Contexto;

namespace Gestao.Infra.Data.Repositories
{
    public class CidadeRepository : RepositoryBase<Cidade>, ICidadeRepository
    {
        public CidadeRepository(ProfissionalContext context) : base(context)
        {
            if (context == null)
                throw new ArgumentNullException();
        }
    }
}
