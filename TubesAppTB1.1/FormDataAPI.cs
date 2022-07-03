using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;

namespace TubesAppTB1._1
{
    public partial class FormDataAPI : Form
    {
        public FormDataAPI()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7283/");
            HttpResponseMessage response = client.GetAsync("api/UserData").Result;
            var result = response.Content.ReadAsAsync<List<UserList>>();
            var emp = result.Result;
            dataGridView1.DataSource = emp;
        }

        private void btnGerai_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7283/");
            HttpResponseMessage response = client.GetAsync("api/GeraiData").Result;
            var result = response.Content.ReadAsAsync<List<GeraiList>>();
            var emp = result.Result;
            dataGridView1.DataSource = emp;
        }
    }
}
