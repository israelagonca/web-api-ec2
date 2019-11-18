using FutShowMe.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Application.Interfaces
{
    public interface IQuadraAppService : IDisposable
    {
        void Adicionar(QuadraViewModel QuadraViewModel);
        QuadraViewModel ObterPorId(int Id);
        IEnumerable<QuadraViewModel> ListarPorLocal(int idLocal);
        QuadraViewModel Atualizar(QuadraViewModel QuadraViewModel);
        void Remover(int Id);
    }
}
