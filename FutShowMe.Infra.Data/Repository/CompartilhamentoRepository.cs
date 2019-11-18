using AutoMapper;
using AutoMapper.QueryableExtensions;
using FutShowMe.Domain.Entities;
using FutShowMe.Domain.Interfaces.Repository;
using FutShowMe.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace FutShowMe.Infra.Data.Repository
{
    public class CompartilhamentoRepository : Repository<Compartilhamento>, ICompartilhamentoRepository
    {
        public CompartilhamentoRepository(FutshowmedbContext context)
            : base(context)
        {

        }

        public IEnumerable<Compartilhamento> ObterPorTipo(string Tipo)
        {
            return Db.Tblcompartilhamento.Where(c => c.TipoCompartilhamento == Tipo)
            .Select(c => Mapper.Map<Compartilhamento>(c));
        }

        public IEnumerable<Compartilhamento> ObterPorUsuario(int IdUsuario)
        {
            return Db.Tblcompartilhamento.Where(c => c.IdUsuario == IdUsuario)
            .Select(c => Mapper.Map<Compartilhamento>(c));
        }

        public IEnumerable<Compartilhamento> ObterPorUsuarioETipo(int IdUsuario, string Tipo)
        {
            return Db.Tblcompartilhamento.Where(c => c.IdUsuario == IdUsuario && c.TipoCompartilhamento == Tipo)
            .Select(c => Mapper.Map<Compartilhamento>(c));
        }

        public IEnumerable<Compartilhamento> ObterPorVideo(int IdVideo)
        {
            return Db.Tblcompartilhamento.Where(c => c.IdVideo == IdVideo)
            .Select(c => Mapper.Map<Compartilhamento>(c));
        }

        public Compartilhamento ObterUltimaAcao()
        {
            return Db.Tblcompartilhamento.Select(c => Mapper.Map<Compartilhamento>(c)).OrderBy(c => c.DataCriacao).FirstOrDefault();
        }
    }
}
