using AutoMapper;
using AutoMapper.QueryableExtensions;
using FutShowMe.Domain.Entities;
using FutShowMe.Domain.Interfaces.Repository;
using FutShowMe.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace FutShowMe.Infra.Data.Repository
{
    public class CameraRepository : RepositorySQLite<Camera>, ICameraRepository
    {
        public CameraRepository(FutshowmedbContext context)
            : base(context)
        {

        }

        public Camera ObterPorPosicao(string Posicao, int IdQuadra)
        {
            return Buscar(c => c.Posicao == Posicao && c.IdQuadra == IdQuadra).FirstOrDefault();
        }

        public IEnumerable<Camera> ObterPorQuadra(int IdQuadra)
        {
            return Db.Tblcamera.Where(c => c.IdQuadra == IdQuadra)
            .Select(c => Mapper.Map<Camera>(c));
        }
    }
}
