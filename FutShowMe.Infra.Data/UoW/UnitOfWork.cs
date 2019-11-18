using FutShowMe.Infra.Data.Context;
using FutShowMe.Infra.Data.Interfaces;
using System;

namespace FutShowMe.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FutshowmedbContext _context;
        private bool _disposed;

        public UnitOfWork(FutshowmedbContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
