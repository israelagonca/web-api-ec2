using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Domain.Entities
{
    public class Quadra : EntityBase<Quadra>
    {
        public int IdQuadra { get; set; }
        public int? IdLocal { get; set; }
        public string Nome { get; set; }
    }
}
