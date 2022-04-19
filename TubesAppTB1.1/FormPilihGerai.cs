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
    public partial class FormPilihGerai : Form
    {
        public FormPilihGerai()
        {
            InitializeComponent();
        }

        private void butPesanGerai_Click(object sender, EventArgs e)
        {
            string pilgerai = "";
            if (geraiA.Checked)
            {
                pilgerai = geraiA.Text;
            }
            else if (geraiB.Checked)
            {
                pilgerai = geraiB.Text;
            }
            DBC(pilgerai);
            void DBC(string gerai)
            {
                Debug.Assert(gerai == geraiA.Text || gerai == geraiB.Text, "Silakan pilih Gerai");
            }
            if (pilgerai == geraiA.Text || pilgerai == geraiB.Text)
            {
                //DataGerai dataGerai = new DataGerai(pilgerai);
                Program.gerai = pilgerai;
                FormPesananAnda formPesananAnda = new FormPesananAnda();
                this.Hide();
                formPesananAnda.Show();
            }
        }
    }
}