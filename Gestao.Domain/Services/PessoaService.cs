using System;
using System.Collections.Generic;
using Gestao.Domain.Entities;
using Gestao.Domain.Interfaces.Repositotories;
using Gestao.Domain.Interfaces.Services;

namespace Gestao.Domain.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public Pessoa Adicionar(Pessoa curso)
        {
            if (!curso.IsValid())
            {
                return curso;
            }
            return _pessoaRepository.Adicionar(curso);
        }

        public Pessoa Atualizar(Pessoa curso)
        {
            return _pessoaRepository.Atualizar(curso);
        }

        public void Remover(int id)
        {
            _pessoaRepository.Remover(id);
        }

        public Pessoa ObterPorId(int id)
        {
            return _pessoaRepository.ObterPorId(id);
        }

        public IEnumerable<Pessoa> ObterTodos()
        {
            return _pessoaRepository.ObterTodos();
        }
        public void Dispose()
        {
            _pessoaRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
