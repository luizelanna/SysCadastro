using System;
using System.Collections.Generic;
using Gestao.Application.ViewModels;

namespace Gestao.Application.Interfaces
{
    public interface IPessoaAppServicos : IDisposable
    {
        PessoasViewModel Adicionar(PessoasViewModel pessoasViewModel);
        PessoasViewModel Atualizar(PessoasViewModel pessoasViewModel);
        void Remover(int id);
        PessoasViewModel ObterPorId(int id);
        IEnumerable<PessoasViewModel> ObterTodos();
    }
}
