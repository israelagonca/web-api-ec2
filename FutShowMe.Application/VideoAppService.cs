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
    public class VideoAppService : ApplicationService, IVideoAppService
    {
        private readonly IVideoService videoService;

        public VideoAppService(IVideoService VideoService, IUnitOfWork uow)
            : base(uow)
        {
            videoService = VideoService;
        }

        public void Adicionar(VideoViewModel VideoViewModel)
        {
            videoService.Adicionar(Mapper.Map<Video>(VideoViewModel));
        }

        public VideoViewModel Atualizar(VideoViewModel VideoViewModel)
        {
            var VideoAtualizado = videoService.Atualizar(Mapper.Map<Video>(VideoViewModel));
            return Mapper.Map<VideoViewModel>(VideoAtualizado);
        }

        public void Dispose()
        {
            videoService.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<VideoViewModel> ListarPorCamera(int IdCamera)
        {
            return Mapper.Map<IEnumerable<VideoViewModel>>(videoService.ListarPorCamera(IdCamera));
        }

        public VideoViewModel ObterPorId(int Id)
        {
            return Mapper.Map<VideoViewModel>(videoService.ObterPorId(Id));
        }

        public void Remover(int Id)
        {
            videoService.Remover(Id);
        }
    }
}
