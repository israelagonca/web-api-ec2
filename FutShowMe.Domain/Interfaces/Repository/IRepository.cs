using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FutShowMe.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity obj);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        TEntity Atualizar(TEntity obj);
        void Remover(int id);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
    }
}
