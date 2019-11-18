using FutShowMe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Domain.Interfaces.Service
{
    public interface IQuadraService : IDisposable
    {
        void Adicionar(Quadra cliente);
        Quadra ObterPorId(int id);

        IEnumerable<Quadra> ListarPorLocal(int IdLocal);

        Quadra Atualizar(Quadra cliente);
        void Remover(int id);
    }
}
