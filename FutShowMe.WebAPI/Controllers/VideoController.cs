using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FutShowMe.Application.Interfaces;
using FutShowMe.Domain;
using FutShowMe.Domain.ViewModels;
using FutShowMe.WebAPI.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace FutShowMe.WebAPI.Controllers
{
    //[Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class VideoController : BaseController
    {
        private readonly IVideoAppService _VideoAppService;
        private readonly ConfiguracoesGerais _configuracoesGerais;
        private readonly IHttpContextAccessor _httpcontext;

        public VideoController(IVideoAppService VideoAppService, IOptions<ConfiguracoesGerais> configuracoesGerais, IHttpContextAccessor httpContextAccessor)
        {
            _VideoAppService = VideoAppService;
            _configuracoesGerais = (ConfiguracoesGerais)configuracoesGerais.Value;
            _httpcontext = httpContextAccessor; ;
        }

        [Route("Adicionar")]
        [HttpPost]
        public JsonResult Adicionar([FromBody] VideoViewModel Video)
        {
            ResponseBase<string> response = new ResponseBase<string>();

            try
            {
                _VideoAppService.Adicionar(Video);
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
        public JsonResult ObterPorId([FromBody] int IdVideo)
        {
            ResponseBase<VideoViewModel> response = new ResponseBase<VideoViewModel>();

            try
            {
                response.Data = _VideoAppService.ObterPorId(IdVideo);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return base.buildJsonResult(response);

        }

        [Route("ListarPorCamera")]
        [HttpGet]
        public JsonResult ListarPorCamera([FromBody] int IdCamera)
        {
            ResponseBase<IEnumerable<VideoViewModel>> response = new ResponseBase<IEnumerable<VideoViewModel>>();

            try
            {
                response.Data = _VideoAppService.ListarPorCamera(IdCamera);
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
        public JsonResult Atualizar([FromBody] VideoViewModel Video)
        {
            ResponseBase<VideoViewModel> response = new ResponseBase<VideoViewModel>();

            try
            {
                response.Data = _VideoAppService.Atualizar(Video);
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
        public JsonResult Remover([FromBody] int IdVideo)
        {
            ResponseBase<string> response = new ResponseBase<string>();

            try
            {
                _VideoAppService.Remover(IdVideo);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return base.buildJsonResult(response);

        }

        [Route("ListarVideos")]
        [HttpGet]
        public JsonResult ListarVideos()
        {
            ResponseBase<IEnumerable<VideoViewModel>> response = new ResponseBase<IEnumerable<VideoViewModel>>();

            try
            {
                List<VideoViewModel> videos = new List<VideoViewModel>();

                string[] arquivoVideos = Directory.GetFiles(_configuracoesGerais.DiretorioVideos);

                for (int i = 0; i < arquivoVideos.Length; i++)
                {
                    try
                    {
                        var nomeArquivo = Path.GetFileName(arquivoVideos[i]);
                        videos.Add(new VideoViewModel()
                        {
                            NomeArquivo = nomeArquivo,
                            Url = _configuracoesGerais.UrlBase + nomeArquivo,
                            DataCriacao = getDataCriacaoVideo(nomeArquivo)
                        });
                    }
                    catch (Exception ex)
                    {
                        response.Success = false;
                        response.Message = ex.Message;
                    }

                }

                response.Data = videos;
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return base.buildJsonResult(response);

        }

        private DateTime getDataCriacaoVideo(string dataVideo)
        {
            //01_3_18112019_160109.avi
            var data = dataVideo.Split("_")[2];
            var hora = dataVideo.Split("_")[3];

            return DateTime.Parse(string.Format("{0}/{1}/{2} {3}:{4}:{5}", data.Substring(0, 2), data.Substring(2, 2), data.Substring(4, 4), hora.Substring(0, 2), hora.Substring(2, 2), hora.Substring(4, 2)));
        }

        [Route("Visualizar/{nomeVideo}")]
        [HttpGet]
        public IActionResult Visualizar(string nomeVideo)
        {
            try
            {
                //byte[] bytes = null;
                //var file = new FileStream(_configuracoesGerais.DiretorioVideos + nomeVideo, FileMode.Open);

                //using (MemoryStream ms = new MemoryStream())
                //{
                //    file.CopyTo(ms);
                //    bytes = ms.ToArray();
                //}

                //_httpcontext.HttpContext.Response.Clear();
                //_httpcontext.HttpContext.Response.Headers.Add("Content-Disposition", "attachment; filename=" + nomeVideo);
                //_httpcontext.HttpContext.Response.ContentType = _configuracoesGerais.ContentType;
                //_httpcontext.HttpContext.Response.Body.WriteAsync(bytes);

                var file = new FileStream(_configuracoesGerais.DiretorioVideos + nomeVideo, FileMode.Open);
                return new FileStreamResult(file, new MediaTypeHeaderValue(_configuracoesGerais.ContentType).MediaType);

                return BadRequest();

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

    }
}