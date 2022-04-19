using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesAppTB1._1
{
    internal class beriRatingConfig
    {
        public string satu { get; set; }
        public string dua { get; set; }

        public beriRatingConfig() { }
        public beriRatingConfig(string satu, string dua)
        {
            this.satu = satu;
            this.dua = dua;
        }
    }
}