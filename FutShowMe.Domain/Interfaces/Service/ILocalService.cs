using FutShowMe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Domain.Interfaces.Service
{
    public interface ILocalService : IDisposable
    {
        void Adicionar(Local local);
        Local ObterPorId(int id);

        IEnumerable<Local> ObterTodos();

        Local Atualizar(Local local);
        void Remover(int id);
    }
}
