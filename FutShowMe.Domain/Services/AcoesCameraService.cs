using FutShowMe.Domain.Entities;
using FutShowMe.Domain.Interfaces.Repository;
using FutShowMe.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Domain.Services
{
    public class AcoesCameraService : IAcoesCameraService
    {
        private readonly IAcoesCameraRepository _AcoesCameraRepository;

        public AcoesCameraService(IAcoesCameraRepository AcoesCameraRepository)
        {
            _AcoesCameraRepository = AcoesCameraRepository;
        }

        public void Adicionar(AcoesCamera cliente)
        {
            _AcoesCameraRepository.Adicionar(cliente);
        }

        public AcoesCamera Atualizar(AcoesCamera cliente)
        {
            return _AcoesCameraRepository.Atualizar(cliente);
        }

        public void Dispose()
        {
            _AcoesCameraRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<AcoesCamera> ListarPorCamera(int IdCamera)
        {
            return _AcoesCameraRepository.ListarPorCamera(IdCamera);
        }

        public AcoesCamera ObterPorId(int id)
        {
            return _AcoesCameraRepository.ObterPorId(id);
        }

        public void Remover(int id)
        {
            _AcoesCameraRepository.Remover(id);
        }
    }
}
