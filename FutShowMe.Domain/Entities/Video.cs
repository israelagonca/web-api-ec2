using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Domain.Entities
{
    public class Video : EntityBase<Video>
    {
        public int IdVideo { get; set; }
        public int IdCamera { get; set; }
        public byte? Excluido { get; set; }
        public DateTime? DataExclusao { get; set; }
        public DateTime DataCriacao { get; set; }
        public string NomeArquivo { get; set; }
        public string Diretorio { get; set; }
    }
}
