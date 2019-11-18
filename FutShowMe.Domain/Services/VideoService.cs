using FutShowMe.Domain.Entities;
using FutShowMe.Domain.Interfaces.Repository;
using FutShowMe.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Domain.Services
{
    public class VideoService : IVideoService
    {
        private readonly IVideoRepository _VideoRepository;

        public VideoService(IVideoRepository VideoRepository)
        {
            _VideoRepository = VideoRepository;
        }

        public void Adicionar(Video cliente)
        {
            _VideoRepository.Adicionar(cliente);
        }

        public Video Atualizar(Video cliente)
        {
           return _VideoRepository.Atualizar(cliente);
        }

        public void Dispose()
        {
            _VideoRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Video ObterPorId(int id)
        {
            return _VideoRepository.ObterPorId(id);
        }

        public IEnumerable<Video> ListarPorCamera(int IdCamera)
        {
            return _VideoRepository.ListarPorCamera(IdCamera);
        }

        public void Remover(int id)
        {
            _VideoRepository.Remover(id);
        }
    }
}
