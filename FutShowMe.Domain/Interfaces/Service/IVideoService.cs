using FutShowMe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Domain.Interfaces.Service
{
    public interface IVideoService : IDisposable
    {
        void Adicionar(Video Video);
        Video ObterPorId(int id);

        IEnumerable<Video> ListarPorCamera(int IdCamera);

        Video Atualizar(Video Video);
        void Remover(int id);
    }
}
