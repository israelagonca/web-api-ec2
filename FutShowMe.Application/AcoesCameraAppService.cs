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
    public class AcoesCameraAppService : ApplicationService, IAcoesCameraAppService
    {
        private readonly IAcoesCameraService _AcoesCameraService;

        public AcoesCameraAppService(IAcoesCameraService AcoesCameraService, IUnitOfWork uow)
            : base(uow)
        {
            _AcoesCameraService = AcoesCameraService;
        }

        public void Adicionar(AcoesCameraViewModel AcoesCameraViewModel)
        {
            _AcoesCameraService.Adicionar(Mapper.Map<AcoesCamera>(AcoesCameraViewModel));
        }

        public AcoesCameraViewModel Atualizar(AcoesCameraViewModel AcoesCameraViewModel)
        {
            var AcoesCameraAtualizado = _AcoesCameraService.Atualizar(Mapper.Map<AcoesCamera>(AcoesCameraViewModel));
            return Mapper.Map<AcoesCameraViewModel>(AcoesCameraAtualizado);
        }

        public void Dispose()
        {
            _AcoesCameraService.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<AcoesCameraViewModel> ListarPorCamera(int IdCamera)
        {
            return Mapper.Map<IEnumerable<AcoesCameraViewModel>>(_AcoesCameraService.ListarPorCamera(IdCamera));
        }

        public AcoesCameraViewModel ObterPorId(int Id)
        {
            return Mapper.Map<AcoesCameraViewModel>(_AcoesCameraService.ObterPorId(Id));
        }

        public void Remover(int Id)
        {
            _AcoesCameraService.Remover(Id);
        }
    }
}
