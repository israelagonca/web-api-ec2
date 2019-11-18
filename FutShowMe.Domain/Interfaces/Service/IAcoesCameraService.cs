using FutShowMe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Domain.Interfaces.Service
{
    public interface IAcoesCameraService : IDisposable
    {
        void Adicionar(AcoesCamera AcoesCamera);
        AcoesCamera ObterPorId(int id);

        IEnumerable<AcoesCamera> ListarPorCamera(int IdCamera);

        AcoesCamera Atualizar(AcoesCamera AcoesCamera);
        void Remover(int id);
    }
}
