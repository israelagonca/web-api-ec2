using AutoMapper;
using AutoMapper.QueryableExtensions;
using FutShowMe.Domain.Entities;
using FutShowMe.Domain.Interfaces.Repository;
using FutShowMe.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace FutShowMe.Infra.Data.Repository
{
    public class VideoRepository : Repository<Video>, IVideoRepository
    {
        public VideoRepository(FutshowmedbContext context)
            : base(context)
        {

        }

        public IEnumerable<Video> ListarPorCamera(int IdCamera)
        {
            return Db.Tblvideo.Where(c => c.IdCamera == IdCamera)
            .Select(c => Mapper.Map<Video>(c));
        }
    }
}
