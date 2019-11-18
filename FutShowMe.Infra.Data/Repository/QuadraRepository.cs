using AutoMapper;
using AutoMapper.QueryableExtensions;
using FutShowMe.Domain.Entities;
using FutShowMe.Domain.Interfaces.Repository;
using FutShowMe.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace FutShowMe.Infra.Data.Repository
{
    public class QuadraRepository : Repository<Quadra>, IQuadraRepository
    {
        public QuadraRepository(FutshowmedbContext context)
            : base(context)
        {

        }

        public IEnumerable<Quadra> ObterPorLocal(int IdLocal)
        {
            return Db.Tblquadra.Where(c => c.IdLocal == IdLocal)
            .Select(c => Mapper.Map<Quadra>(c));
        }
    }
}
