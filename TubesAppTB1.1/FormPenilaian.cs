using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace TubesAppTB1._1
{
    public partial class FormPenilaian : Form
    {
        public FormPenilaian()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hitungPenilaianConfig nilaiConf = new hitungPenilaianConfig();
            string gerai, rate;
            //Console.WriteLine("Beri Penilaian");
            string inputNamaGerai = textBox1.Text;
            List<string> listNamaGerai = nilaiConf.conf.namaGerai;
            if (listNamaGerai.Contains(inputNamaGerai))
            {
                gerai = "gerai ada";
            }
            else
            {
                gerai = "gerai tidak ada";
            }

            //Console.WriteLine("Rating layanan Gerai : ");
            //String inputBintang = Console.ReadLine();
            if (radioButton1.Checked)
            {
                rate = nilaiConf.conf.beriRating.satu;
            }
            else
            {
                rate = nilaiConf.conf.beriRating.dua;
            }
            textBox2.Text = gerai.ToString() + " " + rate.ToString();
        }
    }
}
