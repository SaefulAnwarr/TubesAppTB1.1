﻿using System;
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
    public partial class FormLoginTB : Form
    {
        int attempt = 0;
        public FormLoginTB()
        {
            InitializeComponent();
        }

        private void buttLoginTB_Click(object sender, EventArgs e)
        {
            string[] usernameData = { "devarj00", "saefulanw88", "asyrafbll99", "bellamyik22", "melvinj66", "acer123456789123456789123abcd" };
            string[] passwordData = { "singa00", "hiu88", "elang99", "zebra22", "badak66", "macan123456789123456789" };
         


            if (usernameData.Contains(txtUsername.Text) && passwordData.Contains(txtPassword.Text) && Array.IndexOf(usernameData, txtUsername.Text) ==
                Array.IndexOf(passwordData, txtPassword.Text))
            {
                FormPemesananLayanan formPemesananLayanan = new FormPemesananLayanan();
                this.Hide();
                formPemesananLayanan.Show();
                MessageBox.Show("Login berhasil! Selamat datang di Aplikasi Tambal Ban");
            }
            else
            {
                txtUsername.Clear();
                txtPassword.Clear();
                MessageBox.Show("Login gagal! Mohon cek username dan password");
                attempt += 1;

                if (attempt == 3)
                {
                    Application.Exit();
                }
            }

        }
    }
}
