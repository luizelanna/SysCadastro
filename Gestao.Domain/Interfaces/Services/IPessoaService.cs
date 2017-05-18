using System;
using System.Collections.Generic;
using Gestao.Domain.Entities;

namespace Gestao.Domain.Interfaces.Services
{
    public interface IPessoaService : IDisposable
    {
        Pessoa Adicionar(Pessoa curso);
        Pessoa Atualizar(Pessoa curso);
        void Remover(int id);
        Pessoa ObterPorId(int id);
        IEnumerable<Pessoa> ObterTodos();
    }
}
