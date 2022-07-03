using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesAppTB1._1
{
    public class FormPenilaianTB
    {
        public enum Gerai { gerai1, gerai2, gerai3, gerai4, gerai5 };

        public static string GetNamaGerai(Gerai inputGerai)
        {
            string[] NamaGerai = { "Indo Sejati", "Sejuta Kasih", "Merdeka Abadi", "Cinta Ibu", "Semangat Jaya" };

            return NamaGerai[(int)inputGerai];
        }

        public enum Bintang { satu, dua, tiga, empat, lima };

        public static string BeriRating(Bintang inputBintang)
        {
            string[] PesanRating =
                {"Sorry if our services is very bad",
                "Sorry if our services bad",
                "Sorry if our services is bad, we will evaluate",
                "Thankyou for the rating, we will improve the quality of our service",
                "Thankyou for the rating"};

            return PesanRating[(int)inputBintang];

        }
    }
}
