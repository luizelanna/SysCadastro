using System;
using System.Collections.Generic;
using Gestao.Domain.Entities;

namespace Gestao.Domain.Interfaces.Services
{
    public interface ICidadeService : IDisposable
    {
        Cidade Adicionar(Cidade curso);
        Cidade Atualizar(Cidade curso);
        void Remover(int id);
        Cidade ObterPorId(int id);
        IEnumerable<Cidade> ObterTodos();
    }
}
