using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Infra.Data.Interfaces
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
    }
}
