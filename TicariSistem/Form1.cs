using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariSistem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public HttpClient Baglanti()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:44380/");
            return client;

        }


        private async void button1_Click(object sender, EventArgs e)
        {
            var client = Baglanti();
            HttpResponseMessage response = await client.GetAsync("api/Personeller/getall");
            string result = await response.Content.ReadAsStringAsync();
            label1.Text = result;
        }
    }
}
