using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Domain.Entities
{
    public class Compartilhamento : EntityBase<Compartilhamento>
    {
        public int IdCompartilhamento { get; set; }
        public int IdUsuario { get; set; }
        public int IdVideo { get; set; }
        public DateTime DataCriacao { get; set; }
        public string TipoCompartilhamento { get; set; }
    }
}
