using System;
using System.Collections.Generic;
using Gestao.Application.ViewModels;

namespace Gestao.Application.Interfaces
{
    public interface ITipoPessoaAppServicos :IDisposable
    {
        TipoPessoasViewModel Adicionar(TipoPessoasViewModel cidadesViewModel);
        TipoPessoasViewModel Atualizar(TipoPessoasViewModel cidadesViewModel);
        void Remover(int id);
        TipoPessoasViewModel ObterPorId(int id);
        IEnumerable<TipoPessoasViewModel> ObterTodos();
    }
}
