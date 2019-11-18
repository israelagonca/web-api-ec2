using FutShowMe.Domain.Interfaces.Repository;
using FutShowMe.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FutShowMe.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected FutshowmedbContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository(FutshowmedbContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Adicionar(TEntity obj)
        {
            var objreturn = DbSet.Add(obj);
        }

        public virtual TEntity ObterPorId(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> ObterTodos()//(int s, int t)
        {
            return DbSet.ToList(); //Take(t).Skip(s).ToList();
        }

        public virtual TEntity Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;

            return obj;
        }

        public virtual void Remover(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
