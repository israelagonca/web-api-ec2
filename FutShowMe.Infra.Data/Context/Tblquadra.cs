using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FutShowMe.Infra.Data.Context
{
    public partial class Tblquadra
    {
        [Key]
        public int IdQuadra { get; set; }
        public int? IdLocal { get; set; }
        public string Nome { get; set; }
    }
}
