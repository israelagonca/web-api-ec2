using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FutShowMe.Infra.Data.Context
{
    public partial class Tbllocal
    {
        [Key]
        public int Idlocal { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
    }
}
