using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEnvio.Model
{
    public class ParametroConfig
    {
        public string UrlSeguridad { get; set; }
        public string ApiNameSeguridad { get; set; }
        public string BusUrl { get; set; }
        public string BusTopic { get; set; }
    }
}
