using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FutShowMe.Domain.ViewModels
{
    public class QuadraViewModel
    {
        [Key]
        public int IdQuadra { get; set; }
        public int? IdLocal { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

    }
}
