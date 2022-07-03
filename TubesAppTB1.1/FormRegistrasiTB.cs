using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace TubesAppTB1._1
{
    public partial class FormRegistrasiTB : Form
    {
        public FormRegistrasiTB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string uname = textBox2.Text;
            string pass = textBox3.Text;
            RegistrasiLibrary.Class1.WriteJSON(email, uname, pass);
            RegistrasiLibrary.Class1.ReadJSON(email, uname, pass);
            FormLoginTB formLoginTB = new FormLoginTB();
            this.Hide();
            formLoginTB.Show();
        }
    }
}