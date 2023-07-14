using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApiStock.Models;

namespace AppGestionStock
{
    public partial class ApiPhpProduit : Form
    {
        public ApiPhpProduit()
        {
            InitializeComponent();
        }

        private void ApiPhpProduit_Load(object sender, EventArgs e)
        {
            effacer();
        }

        private async Task GetRequest()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8000/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response;
                response = await client.GetAsync("/");
                if (response.IsSuccessStatusCode)
                {
                    var reports = await response.Content.ReadAsAsync<Produit[]>();
                    dg.DataSource = reports.ToList();
                }
            }
        }

        private async Task<Produit> GetOneRequest(int Id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8000/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response;
                response = await client.GetAsync(string.Format("/produit/{0}", Id));
                if (response.IsSuccessStatusCode)
                {
                    var report = await response.Content.ReadAsAsync<Produit>();
                    return report;
                }
            }
            return null;
        }

        private async Task<string> PostOneRequest(Produit produit)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8000/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response;
                response = await client.PostAsJsonAsync("/", produit);
                if (response.IsSuccessStatusCode)
                {
                    var report = await response.Content.ReadAsAsync<string>();
                    return report;
                }
            }
            return null;
        }

        private async void btnAjouter_Click(object sender, EventArgs e)
        {
            Produit p = new Produit();

            p.description = txtDescription.Text;
            p.libelle = txtLibelle.Text;
            p.prix = int.Parse(txtPU.Text);
            p.quantite = int.Parse(txtQte.Text);
            await PostOneRequest(p);
            effacer();
        }
        private void effacer()
        {
            txtDescription.Text = string.Empty;
            txtLibelle.Text = string.Empty;
            txtPU.Text = string.Empty;
            txtQte.Text = string.Empty;
            txtId.Text = string.Empty;
            txtLibelle.Focus();
            GetRequest();
        }

        private async void btnChoisir_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dg.CurrentRow.Cells[0].Value.ToString());
            txtId.Enabled = false;
            var p = await GetOneRequest(id.Value);
            txtId.Text = p.id.ToString();
            txtDescription.Text = p.description.ToString();
            txtLibelle.Text = p.libelle.ToString();
            txtPU.Text = p.prix.ToString();
            txtQte.Text = p.quantite.ToString();
        }


        private async Task<string> DeleteRequest(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8000/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response;
                response = await client.DeleteAsync(string.Format("/{0}", id));
                if (response.IsSuccessStatusCode)
                {
                    var report = await response.Content.ReadAsAsync<string>();
                    return report;
                }
            }
            return null;
        }

        private async void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = txtId.Text!=string.Empty? int.Parse(txtId.Text): int.Parse(dg.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show(await DeleteRequest(id.Value));
            effacer();

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            effacer();
        }

        private async void btnModifier_Click(object sender, EventArgs e)
        {
            Produit p = new Produit();
            p.description = txtDescription.Text;
            p.libelle = txtLibelle.Text;
            p.prix = int.Parse(txtPU.Text);
            p.quantite = int.Parse(txtQte.Text);
            p.id = int.Parse(txtId.Text);
            MessageBox.Show(await PutOneRequest(p));
            effacer();

        }

        private async Task<string> PutOneRequest(Produit produit)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8000/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response;
                response = await client.PutAsJsonAsync("/", produit);
                if (response.IsSuccessStatusCode)
                {
                    var report = await response.Content.ReadAsAsync<string>();
                    return report;
                }
            }
            return null;
        }
    }
}
