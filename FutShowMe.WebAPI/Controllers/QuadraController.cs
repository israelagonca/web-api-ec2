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
    public class QuadraController : BaseController
    {
        private readonly IQuadraAppService _QuadraAppService;

        public QuadraController(IQuadraAppService QuadraAppService)
        {
            _QuadraAppService = QuadraAppService;
        }

        [Route("Adicionar")]
        [HttpPost]
        public JsonResult Adicionar([FromBody] QuadraViewModel Quadra)
        {
            ResponseBase<string> response = new ResponseBase<string>();

            try
            {
                _QuadraAppService.Adicionar(Quadra);
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
        public JsonResult ObterPorId([FromBody] int IdQuadra)
        {
            ResponseBase<QuadraViewModel> response = new ResponseBase<QuadraViewModel>();

            try
            {
                response.Data = _QuadraAppService.ObterPorId(IdQuadra);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return base.buildJsonResult(response);

        }

        [Route("ListarPorLocal")]
        [HttpGet]
        public JsonResult ListarPorLocal([FromBody] int IdQuadra)
        {
            ResponseBase<IEnumerable<QuadraViewModel>> response = new ResponseBase<IEnumerable<QuadraViewModel>>();

            try
            {
                response.Data = _QuadraAppService.ListarPorLocal(IdQuadra);
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
        public JsonResult Atualizar([FromBody] QuadraViewModel Quadra)
        {
            ResponseBase<QuadraViewModel> response = new ResponseBase<QuadraViewModel>();

            try
            {
                response.Data = _QuadraAppService.Atualizar(Quadra);
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
        public JsonResult Remover([FromBody] int IdQuadra)
        {
            ResponseBase<string> response = new ResponseBase<string>();

            try
            {
                _QuadraAppService.Remover(IdQuadra);
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