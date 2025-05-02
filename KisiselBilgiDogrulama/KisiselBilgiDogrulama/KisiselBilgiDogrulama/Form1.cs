using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using KisiselBilgiDogrulama.Models;
using KisiselBilgiDogrulama.Attributes;

namespace KisiselBilgiDogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci
            {
                Ad = txtAd.Text.Trim(),
                Soyad = txtSoyad.Text.Trim(),
                Bolum = txtBolum.Text.Trim()
            };

            var hatalar = new List<string>();
            var properties = typeof(Ogrenci).GetProperties();

            foreach (var prop in properties)
            {
                var attr = (ZorunluAlanAttribute)Attribute.GetCustomAttribute(prop, typeof(ZorunluAlanAttribute));
                if (attr != null)
                {
                    var deger = prop.GetValue(ogrenci) as string;
                    if (string.IsNullOrWhiteSpace(deger))
                    {
                        hatalar.Add(attr.HataMesaji);
                    }
                }
            }

            txtAd.BackColor = string.IsNullOrWhiteSpace(txtAd.Text) ? System.Drawing.Color.LightPink : System.Drawing.Color.White;
            txtSoyad.BackColor = string.IsNullOrWhiteSpace(txtSoyad.Text) ? System.Drawing.Color.LightPink : System.Drawing.Color.White;
            txtBolum.BackColor = string.IsNullOrWhiteSpace(txtBolum.Text) ? System.Drawing.Color.LightPink : System.Drawing.Color.White;

            if (hatalar.Any())
            {
                MessageBox.Show(string.Join("\n", hatalar), "Eksik Bilgiler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblBilgi.Text = "";
            }
            else
            {
                lblBilgi.Text = $"Ad: {ogrenci.Ad}\nSoyad: {ogrenci.Soyad}\nBölüm: {ogrenci.Bolum}";
            }
        }
    }
}
