using FutShowMe.Domain.Entities;
using System.Collections.Generic;

namespace FutShowMe.Domain.Interfaces.Repository
{
    public interface IQuadraRepository : IRepository<Quadra>
    {
        IEnumerable<Quadra> ObterPorLocal(int IdCamera);
    }
}
