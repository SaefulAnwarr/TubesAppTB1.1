using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace TubesAppTB1._1
{
    public partial class FormPembayaran : Form
    {
        public FormPembayaran()
        {
            InitializeComponent();
            comboBox1.Text = Program.jnsken;
            textBox1.Text = Program.jmlhban.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pembayaran<string, int>(comboBox1.Text, int.Parse(textBox1.Text));
            void pembayaran<T, U>(string jenis, int ban)
            {
                int harga = 0;
                //adouble hrga;
                //string value = comboBox1.SelectedItem.ToString();
                if (jenis == comboBox1.Items[0].ToString())
                {
                    harga = 3000;
                }
                else if (jenis == comboBox1.Items[1].ToString())
                {
                    harga = 10000;
                }
                else if (jenis == comboBox1.Items[2].ToString())
                {
                    harga = 15000;
                }


                /*double jumlah = double.Parse(textBox1.Text);
                var total = harga * jumlah;*/

                int total = harga * ban;
                Debug.Assert(total <= int.MaxValue && total >= int.MinValue);
                int hasil;
                try
                {
                    hasil = checked(harga * ban);
                    MessageBox.Show("perhitungan tidak ada masalah");
                }
                catch (OverflowException ex)
                {
                    
                    MessageBox.Show("Nilai integer melebihi batas maksimal " + ex.Message);
                    MessageBox.Show("Karena nilai melebihi batas maksimal maka nilai 0");
                    hasil = 0;
                    
                }
                
                textBox2.Text = total.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPenilaian formPenilaian = new FormPenilaian();
            this.Hide();
            formPenilaian.Show();
        }
    }
}
