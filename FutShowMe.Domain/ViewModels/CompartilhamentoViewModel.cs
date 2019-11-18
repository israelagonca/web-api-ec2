using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FutShowMe.Domain.ViewModels
{
    public class CompartilhamentoViewModel
    {
        public int IdCompartilhamento { get; set; }
        public int IdUsuario { get; set; }
        public int IdVideo { get; set; }
        public DateTime DataCriacao { get; set; }
        public string TipoCompartilhamento { get; set; }

    }
}
