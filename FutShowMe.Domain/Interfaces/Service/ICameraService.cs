using FutShowMe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Domain.Interfaces.Service
{
    public interface ICameraService : IDisposable
    {
        void Adicionar(Camera camera);
        Camera ObterPorId(int id);

        Camera ObterPorPosicao(string Posicao, int IdQuadra);

        IEnumerable<Camera> ListarPorQuadra(int IdCamera);

        Camera Atualizar(Camera camera);
        void Remover(int id);
    }
}
