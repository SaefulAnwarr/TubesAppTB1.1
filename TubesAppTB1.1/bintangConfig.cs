using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesAppTB1._1
{
    internal class bintangConfig
    {
        public beriRatingConfig beriRating { get; set; }
        public List<string> namaGerai { get; set; }

        public bintangConfig() { }
        public bintangConfig(beriRatingConfig beriRating, List<string> namaGerai)
        {
            this.beriRating = beriRating;
            this.namaGerai = namaGerai;
        }
    }
}