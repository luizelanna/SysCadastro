using System;
using Gestao.Infra.Data.Contexto;
using Gestao.Infra.Data.Interface;

namespace Gestao.Infra.Data.UnitofWork
{
    public class UnitofWork : IUnitofWork
    {
        private readonly ProfissionalContext _context;
        private bool _disposed;

        public UnitofWork(ProfissionalContext context)
        {
            _context = context;
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