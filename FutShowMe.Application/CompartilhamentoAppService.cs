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
    public class CompartilhamentoAppService : ApplicationService, ICompartilhamentoAppService
    {
        private readonly ICompartilhamentoService _CompartilhamentoService;

        public CompartilhamentoAppService(ICompartilhamentoService CompartilhamentoService, IUnitOfWork uow)
            : base(uow)
        {
            _CompartilhamentoService = CompartilhamentoService;
        }

        public void Adicionar(CompartilhamentoViewModel CompartilhamentoViewModel)
        {
            _CompartilhamentoService.Adicionar(Mapper.Map<Compartilhamento>(CompartilhamentoViewModel));
        }

        public CompartilhamentoViewModel Atualizar(CompartilhamentoViewModel CompartilhamentoViewModel)
        {
            var CompartilhamentoAtualizado = _CompartilhamentoService.Atualizar(Mapper.Map<Compartilhamento>(CompartilhamentoViewModel));
            return Mapper.Map<CompartilhamentoViewModel>(CompartilhamentoAtualizado);
        }

        public void Dispose()
        {
            _CompartilhamentoService.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<CompartilhamentoViewModel> ListarPorVideo(int IdCamera)
        {
            return Mapper.Map<IEnumerable<CompartilhamentoViewModel>>(_CompartilhamentoService.ObterPorVideo(IdCamera));
        }

        public CompartilhamentoViewModel ObterPorId(int Id)
        {
            return Mapper.Map<CompartilhamentoViewModel>(_CompartilhamentoService.ObterPorId(Id));
        }

        public IEnumerable<CompartilhamentoViewModel> ObterPorTipo(string Tipo)
        {
            return Mapper.Map<IEnumerable<CompartilhamentoViewModel>>(_CompartilhamentoService.ObterPorTipo(Tipo));
        }

        public IEnumerable<CompartilhamentoViewModel> ObterPorUsuario(int IdUsuario)
        {
            return Mapper.Map<IEnumerable<CompartilhamentoViewModel>>(_CompartilhamentoService.ObterPorUsuario(IdUsuario));
        }

        public IEnumerable<CompartilhamentoViewModel> ObterPorUsuarioETipo(int IdUsuario, string Tipo)
        {
            return Mapper.Map<IEnumerable<CompartilhamentoViewModel>>(_CompartilhamentoService.ObterPorUsuarioETipo(IdUsuario, Tipo));
        }

        public IEnumerable<CompartilhamentoViewModel> ObterPorVideo(int IdVideo)
        {
            return Mapper.Map<IEnumerable<CompartilhamentoViewModel>>(_CompartilhamentoService.ObterPorVideo(IdVideo));
        }

        public CompartilhamentoViewModel ObterUltimaAcao()
        {
            throw new NotImplementedException();
        }

        public void Remover(int Id)
        {
            _CompartilhamentoService.Remover(Id);
        }
    }
}
