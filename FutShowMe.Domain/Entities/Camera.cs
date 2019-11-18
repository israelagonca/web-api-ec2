using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Domain.Entities
{
    public class Camera : EntityBase<Camera>
    {
        public int IdCamera { get; set; }
        public int IdQuadra { get; set; }
        public string Modelo { get; set; }
        public string Posicao { get; set; }
        public byte? Excluido { get; set; }
        public string DataCriacao { get; set; }
    }
}
