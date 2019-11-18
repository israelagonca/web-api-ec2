using System;
using System.Collections.Generic;
using System.Text;

namespace FutShowMe.Domain
{
    public class ConfiguracoesGerais
    {
        public string DiretorioVideos { get; set; }
        //AWS S3
        public string AWS_ACCESS_KEY_ID { get; set; }
        public string AWS_SECRET_ACCESS_KEY { get; set; }
        public string ClientAppId { get; set; }
        public string Authority { get; set; }

        public string BucketName { get; set; }

        public string UrlBase { get; set; }

        public string ContentType { get; set; }
        

    }
}
