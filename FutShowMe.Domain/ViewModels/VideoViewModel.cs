﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FutShowMe.Domain.ViewModels
{
    public class VideoViewModel
    {
        public int IdVideo { get; set; }
        public int IdCamera { get; set; }
        public byte? Excluido { get; set; }
        public DateTime? DataExclusao { get; set; }
        public DateTime DataCriacao { get; set; }
        public string NomeArquivo { get; set; }

        public string Thumb { get; set; }

        public string Diretorio { get; set; }

        public string Url { get; set; }

        public DateTime DataInicioFiltro { get; set; }

        public DateTime DataTerminoFiltro { get; set; }

        public int IdFiltroData { get; set; }

        public DateTime DataFiltro { get; set; }

    }
}
