using FutShowMe.Domain.Entities;
using System.Collections.Generic;

namespace FutShowMe.Domain.Interfaces.Repository
{
    public interface IVideoRepository : IRepository<Video>
    {
        IEnumerable<Video> ListarPorCamera(int IdCamera);
    }
}
