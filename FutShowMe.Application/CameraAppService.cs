using FutShowMe.Application.Interfaces;
using FutShowMe.Domain.Interfaces.Service;
using FutShowMe.Domain.ViewModels;
using FutShowMe.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using AutoMapper;
using FutShowMe.Domain.Entities;
using System.Diagnostics;

namespace FutShowMe.Application
{
    public class CameraAppService : ApplicationService, ICameraAppService
    {
        private readonly ICameraService _CameraService;

        public CameraAppService(ICameraService CameraService, IUnitOfWork uow)
            : base(uow)
        {
            _CameraService = CameraService;
        }

        public void Adicionar(CameraViewModel CameraViewModel)
        {
            _CameraService.Adicionar(Mapper.Map<Camera>(CameraViewModel));
        }

        public CameraViewModel Atualizar(CameraViewModel CameraViewModel)
        {
            var CameraAtualizado = _CameraService.Atualizar(Mapper.Map<Camera>(CameraViewModel));
            return Mapper.Map<CameraViewModel>(CameraAtualizado);
        }

        public void Dispose()
        {
            _CameraService.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<CameraViewModel> ListarPorQuadra(int IdQuadra)
        {
            return Mapper.Map<IEnumerable<CameraViewModel>>(_CameraService.ListarPorQuadra(IdQuadra));
        }

        public CameraViewModel ObterPorId(int Id)
        {
            return Mapper.Map<CameraViewModel>(_CameraService.ObterPorId(Id));
        }

        public CameraViewModel ObterPorPosicao(string Posicao, int IdQuadra)
        {
            return Mapper.Map<CameraViewModel>(_CameraService.ObterPorPosicao(Posicao, IdQuadra));
        }

        #region FFMPEG COMANDS

        public void IniciarStream()
        {
            //var Camera = Mapper.Map<CameraViewModel>(_CameraService.ObterPorId(IdCamera));

            Process process = new Process();
            process.StartInfo.FileName = "/usr/bin/ffmpeg";
            process.StartInfo.Arguments = "-i rtsp://192.168.15.20/user=admin_password=tlJwpbo6_channel=1_stream=0.sdp - crf 30 - preset ultrafast - r 30 - codec:v copy teste.avi";
            process.Start();
        }

        #endregion

        public void Remover(int Id)
        {
            _CameraService.Remover(Id);
        }
    }
}
