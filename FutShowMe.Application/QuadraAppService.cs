using FutShowMe.Application.Interfaces;
using FutShowMe.Domain.Interfaces.Service;
using FutShowMe.Domain.ViewModels;
using FutShowMe.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using AutoMapper;
using FutShowMe.Domain.Entities;

namespace FutShowMe.Application
{
    public class QuadraAppService : ApplicationService, IQuadraAppService
    {
        private readonly IQuadraService _quadraService;

        public QuadraAppService(IQuadraService quadraService, IUnitOfWork uow)
            : base(uow)
        {
            _quadraService = quadraService;
        }

        public void Adicionar(QuadraViewModel QuadraViewModel)
        {
            _quadraService.Adicionar(Mapper.Map<Quadra>(QuadraViewModel));
        }

        public QuadraViewModel Atualizar(QuadraViewModel QuadraViewModel)
        {
            var quadraAtualizado = _quadraService.Atualizar(Mapper.Map<Quadra>(QuadraViewModel));
            return Mapper.Map<QuadraViewModel>(quadraAtualizado);
        }

        public void Dispose()
        {
            _quadraService.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<QuadraViewModel> ListarPorLocal(int idLocal)
        {
            return Mapper.Map<IEnumerable<QuadraViewModel>>(_quadraService.ListarPorLocal(idLocal));
        }

        public QuadraViewModel ObterPorId(int Id)
        {
            return Mapper.Map<QuadraViewModel>(_quadraService.ObterPorId(Id));
        }

        public void Remover(int Id)
        {
            _quadraService.Remover(Id);
        }
    }
}
