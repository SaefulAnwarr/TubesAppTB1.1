using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TubesAppTB1._1
{
    public partial class FormPesananAnda : Form
    {
        public FormPesananAnda()
        {
            InitializeComponent();
            infoJenis.Text = Program.jnsken;
            infoJumlah.Text = Program.jmlhban.ToString();
            infoGerai.Text = Program.gerai;
        }

        private void FormPesananAnda_Load(object sender, EventArgs e)
        {

        }

        private void butLakukanPembayaran_Click(object sender, EventArgs e)
        {
            FormPembayaran formPembayaran = new FormPembayaran();
            this.Hide();
            formPembayaran.Show();
        }
    }
}