using Business.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        static HttpClient client = new HttpClient();
        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:44300/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("api/Personeller"));

        }
        static async Task<IPersonelService> GetProductAsync(string path)
        {
            Product product = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Product>();
            }
            return product;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
