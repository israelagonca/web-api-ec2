using FutShowMe.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Application.Interfaces
{
    public interface ICompartilhamentoAppService : IDisposable
    {
        void Adicionar(CompartilhamentoViewModel CompartilhamentoViewModel);
        CompartilhamentoViewModel ObterPorId(int Id);
        IEnumerable<CompartilhamentoViewModel> ListarPorVideo(int IdVideo);
        CompartilhamentoViewModel Atualizar(CompartilhamentoViewModel CompartilhamentoViewModel);
        void Remover(int Id);

        CompartilhamentoViewModel ObterUltimaAcao();
        IEnumerable<CompartilhamentoViewModel> ObterPorTipo(string Tipo);

        IEnumerable<CompartilhamentoViewModel> ObterPorVideo(int IdVideo);

        IEnumerable<CompartilhamentoViewModel> ObterPorUsuario(int IdUsuario);

        IEnumerable<CompartilhamentoViewModel> ObterPorUsuarioETipo(int IdUsuario, string Tipo);
    }
}
