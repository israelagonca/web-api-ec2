using FutShowMe.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Application.Interfaces
{
    public interface ICameraAppService : IDisposable
    {
        void Adicionar(CameraViewModel CameraViewModel);
        CameraViewModel ObterPorId(int Id);
        CameraViewModel Atualizar(CameraViewModel CameraViewModel);
        void Remover(int Id);

        IEnumerable<CameraViewModel> ListarPorQuadra(int IdQuadra);

        CameraViewModel ObterPorPosicao(string Posicao, int IdQuadra);

        void IniciarStream();
    }
}
