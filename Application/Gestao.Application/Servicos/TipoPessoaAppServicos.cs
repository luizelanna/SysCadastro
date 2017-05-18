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
    public class TipoPessoaAppServicos : AppService, ITipoPessoaAppServicos
    {
        private readonly ITipoPessoaService _tipoPessoaServicos;
        public TipoPessoaAppServicos(ITipoPessoaService tipoPessoaService, IUnitofWork uow) : base(uow)
        {
            _tipoPessoaServicos = tipoPessoaService;
        }

        public TipoPessoasViewModel Adicionar(TipoPessoasViewModel tipoPessoasViewModel)
        {
            var tipopessoa = Mapper.Map<TipoPessoasViewModel, TipoPessoa>(tipoPessoasViewModel);
            var tipopessoareturn = _tipoPessoaServicos.Adicionar(tipopessoa);
            if (tipopessoareturn.IsValid())
            {
                Commit();
            }
            return tipoPessoasViewModel;
        }

        public TipoPessoasViewModel Atualizar(TipoPessoasViewModel tipoPessoasViewModel)
        {
            var tipopessoa = Mapper.Map<TipoPessoasViewModel, TipoPessoa>(tipoPessoasViewModel);
            var tipopessoaReturn = _tipoPessoaServicos.Atualizar(tipopessoa);

            if (tipopessoaReturn.IsValid())
                Commit();

            return tipoPessoasViewModel;
        }

        public void Remover(int id)
        {
            _tipoPessoaServicos.Remover(id);
            Commit();
        }

        public TipoPessoasViewModel ObterPorId(int id)
        {
            return Mapper.Map<TipoPessoa, TipoPessoasViewModel>(_tipoPessoaServicos.ObterPorId(id));
        }

        public IEnumerable<TipoPessoasViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<TipoPessoa>, IEnumerable<TipoPessoasViewModel>>(_tipoPessoaServicos.ObterTodos());
        }

        public void Dispose()
        {
            _tipoPessoaServicos.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
