using AutoMapper;
using AutoMapper.QueryableExtensions;
using FutShowMe.Domain.Entities;
using FutShowMe.Domain.Interfaces.Repository;
using FutShowMe.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace FutShowMe.Infra.Data.Repository
{
    public class LocalRepository : Repository<Local>, ILocalRepository
    {
        public LocalRepository(FutshowmedbContext context)
            : base(context)
        {

        }
    }
}
