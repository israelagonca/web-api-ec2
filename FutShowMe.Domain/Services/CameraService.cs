using FutShowMe.Domain.Entities;
using FutShowMe.Domain.Interfaces.Repository;
using FutShowMe.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Domain.Services
{
    public class CameraService : ICameraService
    {
        private readonly ICameraRepository _CameraRepository;

        public CameraService(ICameraRepository CameraRepository)
        {
            _CameraRepository = CameraRepository;
        }

        public void Adicionar(Camera cliente)
        {
            _CameraRepository.Adicionar(cliente);
        }

        public Camera Atualizar(Camera cliente)
        {
            return _CameraRepository.Atualizar(cliente);
        }

        public void Dispose()
        {
            _CameraRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Camera ObterPorId(int id)
        {
            return _CameraRepository.ObterPorId(id);
        }

        public Camera ObterPorPosicao(string Posicao, int IdQuadra)
        {
            return _CameraRepository.ObterPorPosicao(Posicao, IdQuadra);
        }

        public IEnumerable<Camera> ListarPorQuadra(int IdCamera)
        {
            return _CameraRepository.ObterPorQuadra(IdCamera);
        }

        public void Remover(int id)
        {
            _CameraRepository.Remover(id);
        }
    }
}
