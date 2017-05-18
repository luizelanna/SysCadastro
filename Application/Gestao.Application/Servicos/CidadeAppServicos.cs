
using System;
using System.Collections.Generic;
using AutoMapper;
using Gestao.Application.Interfaces;
using Gestao.Application.ViewModels;
using Gestao.Domain.Entities;
using Gestao.Domain.Interfaces.Services;
using Gestao.Infra.Data.Interface;

namespace Gestao.Application.Servicos
{
    public class CidadeAppServicos : AppService, ICIdadeAppServicos
    {
        private readonly ICidadeService _cIdadeServicos;
        public CidadeAppServicos(ICidadeService cidadeServicos, IUnitofWork uow) : base(uow)
        {
            _cIdadeServicos = cidadeServicos;
        }

        public CidadesViewModel Adicionar(CidadesViewModel cidadesViewModel)
        {
            var cidade = Mapper.Map<CidadesViewModel, Cidade>(cidadesViewModel);
            var cidadeReturn = _cIdadeServicos.Adicionar(cidade);
            if (cidadeReturn.IsValid())
            {
                Commit();
            }
            return cidadesViewModel;
        }

        public CidadesViewModel Atualizar(CidadesViewModel cidadesViewModel)
        {
            var cidade = Mapper.Map<CidadesViewModel, Cidade>(cidadesViewModel);
            var cidadeReturn = _cIdadeServicos.Atualizar(cidade);
            if (cidadeReturn.IsValid())
            {
                Commit();
            }
            return cidadesViewModel;
        }

        public void Remover(int id)
        {
            _cIdadeServicos.Remover(id);
            Commit();
        }

        public CidadesViewModel ObterPorId(int id)
        {
            return Mapper.Map<Cidade, CidadesViewModel>(_cIdadeServicos.ObterPorId(id));
        }

        public IEnumerable<CidadesViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Cidade>, IEnumerable<CidadesViewModel>>(_cIdadeServicos.ObterTodos());
        }

        public void Dispose()
        {
            _cIdadeServicos.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
