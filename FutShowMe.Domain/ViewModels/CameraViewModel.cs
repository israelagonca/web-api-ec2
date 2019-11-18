using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FutShowMe.Domain.ViewModels
{
    public class CameraViewModel
    {
        public int IdCamera { get; set; }
        public int IdQuadra { get; set; }
        public string Modelo { get; set; }
        public string Posicao { get; set; }
        public byte? Excluido { get; set; }
        public string DataCriacao { get; set; }

    }
}
