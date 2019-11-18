using FutShowMe.Domain.Entities;
using FutShowMe.Domain.Interfaces.Repository;
using FutShowMe.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Domain.Services
{
    public class QuadraService : IQuadraService
    {
        private readonly IQuadraRepository _quadraRepository;

        public QuadraService(IQuadraRepository quadraRepository)
        {
            _quadraRepository = quadraRepository;
        }

        public void Adicionar(Quadra cliente)
        {
            _quadraRepository.Adicionar(cliente);
        }

        public Quadra Atualizar(Quadra cliente)
        {
           return _quadraRepository.Atualizar(cliente);
        }

        public void Dispose()
        {
            _quadraRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Quadra ObterPorId(int id)
        {
            return _quadraRepository.ObterPorId(id);
        }

        public IEnumerable<Quadra> ListarPorLocal(int IdLocal)
        {
            return _quadraRepository.ObterPorLocal(IdLocal);
        }

        public void Remover(int id)
        {
            _quadraRepository.Remover(id);
        }
    }
}
