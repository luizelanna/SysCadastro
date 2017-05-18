using System;
using System.Collections.Generic;
using Gestao.Domain.Entities;

namespace Gestao.Domain.Interfaces.Services
{
    public interface ITipoPessoaService : IDisposable
    {
        TipoPessoa Adicionar(TipoPessoa curso);
        TipoPessoa Atualizar(TipoPessoa curso);
        void Remover(int id);
        TipoPessoa ObterPorId(int id);
        IEnumerable<TipoPessoa> ObterTodos();
    }
}
