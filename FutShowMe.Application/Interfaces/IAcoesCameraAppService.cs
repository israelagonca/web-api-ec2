using FutShowMe.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Application.Interfaces
{
    public interface IAcoesCameraAppService : IDisposable
    {
        void Adicionar(AcoesCameraViewModel AcoesCameraViewModel);
        AcoesCameraViewModel ObterPorId(int Id);
        AcoesCameraViewModel Atualizar(AcoesCameraViewModel AcoesCameraViewModel);
        void Remover(int Id);

        IEnumerable<AcoesCameraViewModel> ListarPorCamera(int IdCamera);

    }
}
