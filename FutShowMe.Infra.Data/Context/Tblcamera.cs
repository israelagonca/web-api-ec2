using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FutShowMe.Infra.Data.Context
{
    public partial class Tblcamera
    {
        [Key]
        public int Idtblcamera { get; set; }
        public int IdQuadra { get; set; }
        public string Modelo { get; set; }
        public string Posicao { get; set; }
        public byte? Excluido { get; set; }
        public string DataCriacao { get; set; }
    }
}
