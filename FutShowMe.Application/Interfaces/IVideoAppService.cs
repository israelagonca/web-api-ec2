using FutShowMe.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Application.Interfaces
{
    public interface IVideoAppService : IDisposable
    {
        void Adicionar(VideoViewModel VideoViewModel);
        VideoViewModel ObterPorId(int Id);
        IEnumerable<VideoViewModel> ListarPorCamera(int IdCamera);
        VideoViewModel Atualizar(VideoViewModel VideoViewModel);
        void Remover(int Id);
    }
}
