using FutShowMe.Domain.Entities;
using FutShowMe.Domain.Interfaces.Repository;
using FutShowMe.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Domain.Services
{
    public class CompartilhamentoService : ICompartilhamentoService
    {
        private readonly ICompartilhamentoRepository _CompartilhamentoRepository;

        public CompartilhamentoService(ICompartilhamentoRepository CompartilhamentoRepository)
        {
            _CompartilhamentoRepository = CompartilhamentoRepository;
        }

        public void Adicionar(Compartilhamento cliente)
        {
            _CompartilhamentoRepository.Adicionar(cliente);
        }

        public Compartilhamento Atualizar(Compartilhamento cliente)
        {
            return _CompartilhamentoRepository.Atualizar(cliente);
        }

        public void Dispose()
        {
            _CompartilhamentoRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Compartilhamento ObterPorId(int id)
        {
            return _CompartilhamentoRepository.ObterPorId(id);
        }

        public IEnumerable<Compartilhamento> ObterPorTipo(string Tipo)
        {
            return _CompartilhamentoRepository.ObterPorTipo(Tipo);
        }

        public IEnumerable<Compartilhamento> ObterPorUsuario(int IdUsuario)
        {
            return _CompartilhamentoRepository.ObterPorUsuario(IdUsuario);
        }

        public IEnumerable<Compartilhamento> ObterPorUsuarioETipo(int IdUsuario, string Tipo)
        {
            return _CompartilhamentoRepository.ObterPorUsuarioETipo(IdUsuario, Tipo);
        }

        public IEnumerable<Compartilhamento> ObterPorVideo(int IdVideo)
        {
            return _CompartilhamentoRepository.ObterPorVideo(IdVideo);
        }

        public void Remover(int id)
        {
            _CompartilhamentoRepository.Remover(id);
        }
    }
}
