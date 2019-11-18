using FutShowMe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Domain.Interfaces.Service
{
    public interface ICompartilhamentoService : IDisposable
    {
        void Adicionar(Compartilhamento Compartilhamento);
        Compartilhamento ObterPorId(int id);

        Compartilhamento Atualizar(Compartilhamento Compartilhamento);
        void Remover(int id);

        IEnumerable<Compartilhamento> ObterPorTipo(string Tipo);

        IEnumerable<Compartilhamento> ObterPorVideo(int IdVideo);

        IEnumerable<Compartilhamento> ObterPorUsuario(int IdUsuario);

        IEnumerable<Compartilhamento> ObterPorUsuarioETipo(int IdUsuario, string Tipo);
    }
}
