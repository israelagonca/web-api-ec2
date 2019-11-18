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
    public class CompartilhamentoController : BaseController
    {
        private readonly ICompartilhamentoAppService _CompartilhamentoAppService;

        public CompartilhamentoController(ICompartilhamentoAppService CompartilhamentoAppService)
        {
            _CompartilhamentoAppService = CompartilhamentoAppService;
        }

        [Route("Adicionar")]
        [HttpPost]
        public JsonResult Adicionar([FromBody] CompartilhamentoViewModel Compartilhamento)
        {
            ResponseBase<string> response = new ResponseBase<string>();

            try
            {
                _CompartilhamentoAppService.Adicionar(Compartilhamento);
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
        public JsonResult ObterPorId([FromBody] int IdCompartilhamento)
        {
            ResponseBase<CompartilhamentoViewModel> response = new ResponseBase<CompartilhamentoViewModel>();

            try
            {
                response.Data = _CompartilhamentoAppService.ObterPorId(IdCompartilhamento);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return base.buildJsonResult(response);

        }

        [Route("ListarPorVideo")]
        [HttpGet]
        public JsonResult ListarPorVideo([FromBody] int IdVideo)
        {
            ResponseBase<IEnumerable<CompartilhamentoViewModel>> response = new ResponseBase<IEnumerable<CompartilhamentoViewModel>>();

            try
            {
                response.Data = _CompartilhamentoAppService.ListarPorVideo(IdVideo);
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
        public JsonResult Atualizar([FromBody] CompartilhamentoViewModel Compartilhamento)
        {
            ResponseBase<CompartilhamentoViewModel> response = new ResponseBase<CompartilhamentoViewModel>();

            try
            {
                response.Data = _CompartilhamentoAppService.Atualizar(Compartilhamento);
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
        public JsonResult Remover([FromBody] int IdCompartilhamento)
        {
            ResponseBase<string> response = new ResponseBase<string>();

            try
            {
                _CompartilhamentoAppService.Remover(IdCompartilhamento);
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