using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Gestao.Domain.Interfaces.Repositotories
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class 
    {
        TEntity Adicionar(TEntity obj);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        TEntity Atualizar(TEntity obj);
        void Remover(int id);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
    }
}
