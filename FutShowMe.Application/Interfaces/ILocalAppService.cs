using FutShowMe.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Application.Interfaces
{
    public interface ILocalAppService : IDisposable
    {
        void Adicionar(LocalViewModel LocalViewModel);
        LocalViewModel ObterPorId(int id);
        LocalViewModel Atualizar(LocalViewModel LocalViewModel);
        void Remover(int id);
        IEnumerable<LocalViewModel> ObterTodos();
    }
}
