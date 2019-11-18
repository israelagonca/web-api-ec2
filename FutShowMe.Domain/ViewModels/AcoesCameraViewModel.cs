using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FutShowMe.Domain.ViewModels
{
    public class AcoesCameraViewModel
    {
        public int IdAcoesCamera { get; set; }
        public string Status { get; set; }
        public int IdCamera { get; set; }
        public DateTime DataCriacao { get; set; }
        public byte? Excluido { get; set; }
        public string MsgErro { get; set; }

    }
}
