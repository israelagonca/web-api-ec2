using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FutShowMe.Infra.Data.Context
{
    public partial class Tblacoescamera
    {
        [Key]
        public int IdAcoesCamera { get; set; }
        public string Status { get; set; }
        public int IdCamera { get; set; }
        public DateTime DataCriacao { get; set; }
        public byte? Excluido { get; set; }
        public string MsgErro { get; set; }
    }
}
