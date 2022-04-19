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

        private void butPemesanan_Click(object sender, EventArgs e)
        {
            Program.jnsken = jenisKendaraan.Text;
            Program.jmlhban = int.Parse(jumlahBan.Text);
            DBC(Program.jnsken, Program.jmlhban);
            void DBC(string jenis, int jumlah)
            {
                Debug.Assert(jenis != "" && jenis == (string)jenisKendaraan.Items[0] || jenis == (string)jenisKendaraan.Items[1] || jenis == (string)jenisKendaraan.Items[2], "Input jenis salah");
                Debug.Assert(jumlah > 0 && jumlah <= 5, "Input jumlah 1 sampai 5");
            }
            //label5.Text = jnsken + jmlhban;
            if ((Program.jnsken != "" && Program.jnsken == (string)jenisKendaraan.Items[0] || Program.jnsken == (string)jenisKendaraan.Items[1] || Program.jnsken == (string)jenisKendaraan.Items[2]) && (Program.jmlhban > 0 && Program.jmlhban <= 5))
            {
                //listpanel[++index].BringToFront();
                //DataPesanan dataPesanan = new DataPesanan(jnsken, jmlhban, new DataGerai(""));
                FormPilihGerai formPilihGerai = new FormPilihGerai();
                this.Hide();
                formPilihGerai.Show();
            }


        }
    }
}