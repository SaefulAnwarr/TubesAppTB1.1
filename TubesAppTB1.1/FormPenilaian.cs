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
            if (radioButton1.Checked)
            {
                FormPenilaianTB.Bintang inputBintang = FormPenilaianTB.Bintang.satu;
                MessageBox.Show(FormPenilaianTB.BeriRating(inputBintang));
            }
            else if (radioButton2.Checked)
            {
                FormPenilaianTB.Bintang inputBintang = FormPenilaianTB.Bintang.dua;
                MessageBox.Show(FormPenilaianTB.BeriRating(inputBintang));
            }
            else if (radioButton3.Checked)
            {
                FormPenilaianTB.Bintang inputBintang = FormPenilaianTB.Bintang.tiga;
                MessageBox.Show(FormPenilaianTB.BeriRating(inputBintang));
            }
            else if (radioButton4.Checked)
            {
                FormPenilaianTB.Bintang inputBintang = FormPenilaianTB.Bintang.empat;
                MessageBox.Show(FormPenilaianTB.BeriRating(inputBintang));
            }
            else if (radioButton5.Checked)
            {
                FormPenilaianTB.Bintang inputBintang = FormPenilaianTB.Bintang.lima;
                MessageBox.Show(FormPenilaianTB.BeriRating(inputBintang));
            }
        }

        private void FormPenilaian_Load(object sender, EventArgs e)
        {
            listGerai.Items.Clear();
            FormPenilaianTB.Gerai inputGerai1 = FormPenilaianTB.Gerai.gerai1;
            listGerai.Items.Add(FormPenilaianTB.GetNamaGerai(inputGerai1));

            FormPenilaianTB.Gerai inputGerai2 = FormPenilaianTB.Gerai.gerai2;
            listGerai.Items.Add(FormPenilaianTB.GetNamaGerai(inputGerai2));

            FormPenilaianTB.Gerai inputGerai3 = FormPenilaianTB.Gerai.gerai3;
            listGerai.Items.Add(FormPenilaianTB.GetNamaGerai(inputGerai3));

            FormPenilaianTB.Gerai inputGerai4 = FormPenilaianTB.Gerai.gerai4;
            listGerai.Items.Add(FormPenilaianTB.GetNamaGerai(inputGerai4));

            FormPenilaianTB.Gerai inputGerai5 = FormPenilaianTB.Gerai.gerai5;
            listGerai.Items.Add(FormPenilaianTB.GetNamaGerai(inputGerai5));
        }
    }
}
