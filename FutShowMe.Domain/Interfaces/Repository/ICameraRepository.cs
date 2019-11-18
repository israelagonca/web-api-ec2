using FutShowMe.Domain.Entities;
using System.Collections.Generic;

namespace FutShowMe.Domain.Interfaces.Repository
{


    public interface ICameraRepository : IRepository<Camera>
    {
        Camera ObterPorPosicao(string Posicao, int IdQuadra);
        IEnumerable<Camera> ObterPorQuadra(int IdQuadra);
    }
}
