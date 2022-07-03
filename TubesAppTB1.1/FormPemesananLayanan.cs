using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TubesAppTB1._1
{
    public partial class FormPemesananLayanan : System.Windows.Forms.Form
    {
        public FormPemesananLayanan()
        {
            InitializeComponent();
        }
        public void DBC<T, U>(IList<T> jenis, U jumlah)
        {
            Debug.Assert(jenis.Contains((T)Convert.ChangeType(jenisKendaraan.Text, typeof(T))), "Input jenis salah");
            Debug.Assert(Convert.ToInt32(jumlah) > 0 && Convert.ToInt32(jumlah) <= 5, "Input jumlah 1 sampai 5");
        }

        private void butPemesanan_Click(object sender, EventArgs e)
        {
            List<string> jenis = new List<string>();
            jenis.Add((string)jenisKendaraan.Items[0]);
            jenis.Add((string)jenisKendaraan.Items[1]);
            jenis.Add((string)jenisKendaraan.Items[2]);
            jenis.Contains(jenisKendaraan.SelectedItem);
            int jumlah = Convert.ToInt32(jumlahBan.Text);
            DBC<string, int>(jenis, jumlah);

            if (jenis.Contains(jenisKendaraan.Text) && jumlah > 0 && jumlah <= 5)
            {
                Program.jnsken = jenisKendaraan.Text;
                Program.jmlhban = int.Parse(jumlahBan.Text);
                FormPilihGerai formPilihGerai = new FormPilihGerai();
                this.Hide();
                formPilihGerai.Show();
            }
        }
    }
}