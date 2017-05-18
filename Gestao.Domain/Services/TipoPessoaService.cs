using System;
using System.Collections.Generic;
using Gestao.Domain.Entities;
using Gestao.Domain.Interfaces.Repositotories;
using Gestao.Domain.Interfaces.Services;

namespace Gestao.Domain.Services
{
    public class TipoPessoaService : ITipoPessoaService
    {
        private readonly ITipoPessoaRepository _tipoPessoaRepository;

        public TipoPessoaService(ITipoPessoaRepository tipoPessoaRepository)
        {
            _tipoPessoaRepository = tipoPessoaRepository;
        }
        
        public TipoPessoa Adicionar(TipoPessoa curso)
        {
            if (!curso.IsValid())
            {
                return curso;
            }
            return _tipoPessoaRepository.Adicionar(curso);
        }

        public TipoPessoa Atualizar(TipoPessoa curso)
        {
            return _tipoPessoaRepository.Atualizar(curso);
        }

        public void Remover(int id)
        {
            _tipoPessoaRepository.Remover(id);
        }

        public TipoPessoa ObterPorId(int id)
        {
            return _tipoPessoaRepository.ObterPorId(id);
        }

        public IEnumerable<TipoPessoa> ObterTodos()
        {
            return ObterTodos();
        }
        public void Dispose()
        {
            _tipoPessoaRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
