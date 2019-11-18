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
    public class LocalController : BaseController
    {
        private readonly ILocalAppService _LocalAppService;

        public LocalController(ILocalAppService LocalAppService)
        {
            _LocalAppService = LocalAppService;
        }

        [Route("Adicionar")]
        [HttpPost]
        public JsonResult Adicionar([FromBody] LocalViewModel local)
        {
            ResponseBase<string> response = new ResponseBase<string>();

            try
            {
                _LocalAppService.Adicionar(local);
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
        public JsonResult ObterPorId([FromBody] int IdLocal)
        {
            ResponseBase<LocalViewModel> response = new ResponseBase<LocalViewModel>();

            try
            {
                response.Data = _LocalAppService.ObterPorId(IdLocal);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return base.buildJsonResult(response);

        }

        [Route("ListarTodos")]
        [HttpGet]
        public JsonResult ListarTodos()
        {
            ResponseBase<IEnumerable<LocalViewModel>> response = new ResponseBase<IEnumerable<LocalViewModel>>();

            try
            {
                response.Data = _LocalAppService.ObterTodos();
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
        public JsonResult Atualizar([FromBody] LocalViewModel local)
        {
            ResponseBase<LocalViewModel> response = new ResponseBase<LocalViewModel>();

            try
            {
                response.Data = _LocalAppService.Atualizar(local);
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
        public JsonResult Remover([FromBody] int IdLocal)
        {
            ResponseBase<string> response = new ResponseBase<string>();

            try
            {
                _LocalAppService.Remover(IdLocal);
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