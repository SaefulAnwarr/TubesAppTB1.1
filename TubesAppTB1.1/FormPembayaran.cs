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
    public partial class FormPembayaran : Form
    {
        public FormPembayaran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pembayaran<string, int>(comboBox1.Text, int.Parse(textBox1.Text));
            void pembayaran<T, U>(string jenis, int ban)
            {
                int harga = 0;
                //adouble hrga;
                //string value = comboBox1.SelectedItem.ToString();
                if (jenis == "Mobil")
                {
                    harga = 15000;
                }
                else if (jenis == "Motor")
                {
                    harga = 10000;
                }


                /*double jumlah = double.Parse(textBox1.Text);
                var total = harga * jumlah;*/
                int total = harga * ban;
                textBox2.Text = total.ToString();
            }
        }
    }
}
