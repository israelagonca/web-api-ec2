using AutoMapper;
using AutoMapper.QueryableExtensions;
using FutShowMe.Domain.Entities;
using FutShowMe.Domain.Interfaces.Repository;
using FutShowMe.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FutShowMe.Infra.Data.Repository
{
    public class AcoesCameraRepository : Repository<AcoesCamera>, IAcoesCameraRepository
    {
        public AcoesCameraRepository(FutshowmedbContext context)
            : base(context)
        {

        }

        public AcoesCamera ObterUltimaAcao()
        {
            return Db.Tblacoescamera.Select(c => Mapper.Map<AcoesCamera>(c)).OrderBy(c => c.DataCriacao).FirstOrDefault();
        }

        public IEnumerable<AcoesCamera> ListarPorCamera(int IdCamera)
        {
            return Db.Tblacoescamera.Where(c => c.IdCamera == IdCamera)
            .Select(c => Mapper.Map<AcoesCamera>(c));
        }
    }
}
