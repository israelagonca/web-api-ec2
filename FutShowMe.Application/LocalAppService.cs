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
    public class LocalAppService : ApplicationService, ILocalAppService
    {
        private readonly ILocalService _LocalService;

        public LocalAppService(ILocalService LocalService, IUnitOfWork uow)
            : base(uow)
        {
            _LocalService = LocalService;
        }

        public void Adicionar(LocalViewModel LocalViewModel)
        {
            _LocalService.Adicionar(Mapper.Map<Local>(LocalViewModel));
        }

        public LocalViewModel Atualizar(LocalViewModel LocalViewModel)
        {
            var localAtualizado = _LocalService.Atualizar(Mapper.Map<Local>(LocalViewModel));
            return Mapper.Map<LocalViewModel>(localAtualizado);
        }

        public void Dispose()
        {
            _LocalService.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<LocalViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<LocalViewModel>>(_LocalService.ObterTodos());
        }

        public LocalViewModel ObterPorId(int Id)
        {
            return Mapper.Map<LocalViewModel>(_LocalService.ObterPorId(Id));
        }

        public void Remover(int Id)
        {
            _LocalService.Remover(Id);
        }
    }
}
