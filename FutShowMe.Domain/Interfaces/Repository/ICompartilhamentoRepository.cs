using FutShowMe.Domain.Entities;
using System.Collections.Generic;

namespace FutShowMe.Domain.Interfaces.Repository
{
    public interface ICompartilhamentoRepository : IRepository<Compartilhamento>
    {
        IEnumerable<Compartilhamento> ObterPorTipo(string Tipo);

        IEnumerable<Compartilhamento> ObterPorVideo(int IdVideo);

        IEnumerable<Compartilhamento> ObterPorUsuario(int IdUsuario);

        IEnumerable<Compartilhamento> ObterPorUsuarioETipo(int IdUsuario, string Tipo);
    }
}
