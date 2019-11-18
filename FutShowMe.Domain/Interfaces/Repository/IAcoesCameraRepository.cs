using FutShowMe.Domain.Entities;
using System.Collections.Generic;

namespace FutShowMe.Domain.Interfaces.Repository
{
    public interface IAcoesCameraRepository : IRepository<AcoesCamera>
    {
        AcoesCamera ObterUltimaAcao();
        IEnumerable<AcoesCamera> ListarPorCamera(int IdCamera);
    }
}
