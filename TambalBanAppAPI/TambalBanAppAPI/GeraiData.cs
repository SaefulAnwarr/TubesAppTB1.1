using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
namespace UserAPI
{
    public class GeraiData
    {
        public string NamaGerai { get; set; }
        public int IdGerai { get; set; }
        public string Alamat { get; set; }
        public GeraiData(string NamaGerai, int IdGerai, string Alamat)
        {
            this.NamaGerai = NamaGerai;
            this.IdGerai = IdGerai;
            this.Alamat = Alamat;
        }
    }
}
