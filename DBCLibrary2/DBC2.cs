using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCLibrary2
{
    public class DBC2
    {
        public static IList<T> Dbc<T, U>(IList<T> jenis, U jumlah)
        {
            Debug.Assert(jenis.Contains((T)Convert.ChangeType(jenis, typeof(T))), "Input jenis salah");
            Debug.Assert(Convert.ToInt32(jumlah) > 0 && Convert.ToInt32(jumlah) <= 5, "Input jumlah 1 sampai 5");
            return jenis;
        }
    }
}
