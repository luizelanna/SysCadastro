using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Gestao.Application.Interfaces;
using Gestao.Application.ViewModels;
using Gestao.Domain.Entities;
using Gestao.Domain.Interfaces.Services;
using Gestao.Infra.Data.Interface;

namespace Gestao.Application.Servicos
{
    public  class PessoaAppServicos : AppService, IPessoaAppServicos
    {

        private readonly IPessoaService _pessoaService;
        public PessoaAppServicos(IPessoaService pessoaService, IUnitofWork uow) : base(uow)
        {
            _pessoaService = pessoaService;
        }

        public PessoasViewModel Adicionar(PessoasViewModel pessoasViewModel)
        {
            var pessoa = Mapper.Map<PessoasViewModel, Pessoa>(pessoasViewModel);
            var pessoareturn = _pessoaService.Adicionar(pessoa);
            if (pessoareturn.IsValid())
            {
                Commit();
            }
            return pessoasViewModel;
        }

        public PessoasViewModel Atualizar(PessoasViewModel pessoasViewModel)
        {
            var pessoa = Mapper.Map<PessoasViewModel, Pessoa>(pessoasViewModel);
            var pessoareturn = _pessoaService.Atualizar(pessoa);
            if (pessoareturn.IsValid())
            {
                Commit();
            }
            return pessoasViewModel;
        }

        public void Remover(int id)
        {
            _pessoaService.Remover(id);
            Commit();
        }

        public PessoasViewModel ObterPorId(int id)
        {
            return Mapper.Map<Pessoa, PessoasViewModel>(_pessoaService.ObterPorId(id));
        }

        public IEnumerable<PessoasViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Pessoa>, IEnumerable<PessoasViewModel>>(_pessoaService.ObterTodos());
        }

        public void Dispose()
        {
            _pessoaService.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
