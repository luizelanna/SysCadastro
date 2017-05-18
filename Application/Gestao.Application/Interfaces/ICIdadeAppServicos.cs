using System;
using System.Collections.Generic;
using Gestao.Application.ViewModels;
using Gestao.Domain.Entities;

namespace Gestao.Application.Interfaces
{
    public interface ICIdadeAppServicos : IDisposable
    {
        CidadesViewModel Adicionar(CidadesViewModel cidadesViewModel);
        CidadesViewModel Atualizar(CidadesViewModel cidadesViewModel);
        void Remover(int id);
        CidadesViewModel ObterPorId(int id);
        IEnumerable<CidadesViewModel> ObterTodos();
    }
}
