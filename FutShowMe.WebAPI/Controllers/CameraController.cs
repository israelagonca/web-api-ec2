using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FutShowMe.Application.Interfaces;
using FutShowMe.Domain.ViewModels;
using FutShowMe.WebAPI.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FutShowMe.WebAPI.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class CameraController : BaseController
    {
        private readonly ICameraAppService _CameraAppService;

        public CameraController(ICameraAppService CameraAppService)
        {
            _CameraAppService = CameraAppService;
        }

        [Route("Adicionar")]
        [HttpPost]
        public JsonResult Adicionar([FromBody] CameraViewModel Camera)
        {
            ResponseBase<string> response = new ResponseBase<string>();

            try
            {
                _CameraAppService.Adicionar(Camera);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return base.buildJsonResult(response);

        }

        [Route("ObterPorId")]
        [HttpGet]
        public JsonResult ObterPorId([FromBody] int IdCamera)
        {
            ResponseBase<CameraViewModel> response = new ResponseBase<CameraViewModel>();

            try
            {
                response.Data = _CameraAppService.ObterPorId(IdCamera);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return base.buildJsonResult(response);

        }

        [Route("ListarPorQuadra")]
        [HttpGet]
        public JsonResult ListarPorQuadra([FromBody] int IdCamera)
        {
            ResponseBase<IEnumerable<CameraViewModel>> response = new ResponseBase<IEnumerable<CameraViewModel>>();

            try
            {
                response.Data = _CameraAppService.ListarPorQuadra(IdCamera);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return base.buildJsonResult(response);

        }

        [Route("Atualizar")]
        [HttpPut]
        public JsonResult Atualizar([FromBody] CameraViewModel Camera)
        {
            ResponseBase<CameraViewModel> response = new ResponseBase<CameraViewModel>();

            try
            {
                response.Data = _CameraAppService.Atualizar(Camera);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return base.buildJsonResult(response);

        }

        [Route("Remover")]
        [HttpDelete]
        public JsonResult Remover([FromBody] int IdCamera)
        {
            ResponseBase<string> response = new ResponseBase<string>();

            try
            {
                _CameraAppService.Remover(IdCamera);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return base.buildJsonResult(response);

        }

    }
}