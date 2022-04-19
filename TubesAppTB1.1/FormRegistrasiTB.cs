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
            WriteJSON();
            ReadJSON();
            void WriteJSON()
            {
                //Contoh object yang akan ditulis dalam JSON
                User user = new User(email, uname, pass);
                //[Opsional] Merapikan format JSON
                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    WriteIndented = true
                };
                //Melakukan perubahan object menjadi string(Serialization)
                String jsonString = JsonSerializer.Serialize(user, options);

                //Membuat file JSON yg berisi string hasil serialization
                File.WriteAllText(Directory.GetParent(Directory.GetCurrentDirectory()) + ".json", jsonString);
            }
            void ReadJSON()
            {
                //Baca file Json yang diinginkan
                String jsonString = File.ReadAllText(Directory.GetParent(Directory.GetCurrentDirectory()) + ".json");
                //Deserialize file json menjadi object
                User user = JsonSerializer.Deserialize<User>(jsonString);
                textBox4.Text = user.Email + " " + user.Username + " " + user.Password;

            }
            FormLoginTB formLoginTB = new FormLoginTB();
            this.Hide();
            formLoginTB.Show();
        }
    }
}