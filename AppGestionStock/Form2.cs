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
using WebApiStock.Models;

namespace AppGestionStock
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetRequest();
        }

        private async Task  GetRequest()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:50017/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response;
                response = await client.GetAsync("api/Produits/GetProduit");
                if (response.IsSuccessStatusCode)
                {
                    var reports = await response.Content.ReadAsAsync<Produit[]>();
                    dgProduit.DataSource = reports.ToList();
                }
            }
        }

        private async Task<Produit> GetOneRequest(int Id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:50017/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response;
                response = await client.GetAsync(string.Format("api/Produits/GetProduit/{0}", Id));
                if (response.IsSuccessStatusCode)
                {
                    var report = await response.Content.ReadAsAsync<Produit>();
                    return report;
                }
            }
            return null;
        }

        private async Task<int?> PostOneRequest(Produit produit)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:50017/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response;
                response = await client.PostAsJsonAsync("api/Produits/PostProduit", produit);
                if (response.IsSuccessStatusCode)
                {
                    var report = await response.Content.ReadAsAsync<int>();
                    return report;
                }
            }
            return null;
        }
    }
}
