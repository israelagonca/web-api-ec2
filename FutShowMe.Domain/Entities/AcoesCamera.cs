using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Domain.Entities
{
    public class AcoesCamera : EntityBase<Quadra>
    {
        public int IdAcoesCamera { get; set; }
        public string Status { get; set; }
        public int IdCamera { get; set; }
        public DateTime DataCriacao { get; set; }
        public byte? Excluido { get; set; }
        public string MsgErro { get; set; }
    }
}
