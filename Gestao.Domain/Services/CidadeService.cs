using System;
using System.Collections.Generic;
using Gestao.Domain.Entities;
using Gestao.Domain.Interfaces.Repositotories;
using Gestao.Domain.Interfaces.Services;

namespace Gestao.Domain.Services
{
    public class CidadeService : ICidadeService
    {
        private readonly ICidadeRepository _cidadeRepository;

        public CidadeService(ICidadeRepository cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }

        public Cidade Adicionar(Cidade curso)
        {
            if (!curso.IsValid())
            {
                return curso;
            }
            return _cidadeRepository.Adicionar(curso);
        }

        public Cidade Atualizar(Cidade curso)
        {
            return _cidadeRepository.Atualizar(curso);
        }

        public void Remover(int id)
        {
            _cidadeRepository.Remover(id);
        }

        public Cidade ObterPorId(int id)
        {
            return _cidadeRepository.ObterPorId(id);
        }

        public IEnumerable<Cidade> ObterTodos()
        {
            return _cidadeRepository.ObterTodos();
        }
        public void Dispose()
        {
            _cidadeRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
