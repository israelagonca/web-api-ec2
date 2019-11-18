using FutShowMe.Domain.Entities;
using FutShowMe.Domain.Interfaces.Repository;
using FutShowMe.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Domain.Services
{
    public class LocalService : ILocalService
    {
        private readonly ILocalRepository _LocalRepository;

        public LocalService(ILocalRepository LocalRepository)
        {
            _LocalRepository = LocalRepository;
        }

        public void Adicionar(Local cliente)
        {
            _LocalRepository.Adicionar(cliente);
        }

        public Local Atualizar(Local cliente)
        {
           return _LocalRepository.Atualizar(cliente);
        }

        public void Dispose()
        {
            _LocalRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Local ObterPorId(int id)
        {
            return _LocalRepository.ObterPorId(id);
        }

        public IEnumerable<Local> ObterTodos()
        {
            return _LocalRepository.ObterTodos();
        }

        public void Remover(int id)
        {
            _LocalRepository.Remover(id);
        }
    }
}
