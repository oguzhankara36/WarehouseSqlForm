using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depo_Entity
{
    public partial class MalzemeSayfa : Form
    {
        public MalzemeSayfa()
        {
            InitializeComponent();
        }
        DepoEntities4 baglanti = new DepoEntities4();
        private void btnliste_Click(object sender, EventArgs e)
        {
            goster();
        }
        public void goster()
        {
            dataGridView1.DataSource = baglanti.mlistele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Malzeme ekle = new Malzeme();
            ekle.malzemeadi = txtmalzemead.Text;
            ekle.malzemeadet = int.Parse(txtmalzemeadet.Text);
            ekle.malzemefiyat = decimal.Parse(txtmalzemefiyat.Text);
            ekle.malzememarka = txtmalzememarka.Text;
            ekle.malzememodel = txtmodel.Text;
            baglanti.mekle(ekle.malzemeadi,ekle.malzemeadet,ekle.malzemefiyat,ekle.malzememarka,ekle.malzememodel);
            baglanti.SaveChanges();
            goster();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            Malzeme sil = new Malzeme();
            sil.malzemeno = Convert.ToInt32(txtmalzemead.Tag);
            baglanti.msil(sil.malzemeno);
            baglanti.SaveChanges();
            goster();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtmalzemead.Text = satir.Cells["malzemeadi"].Value.ToString();
            txtmalzemead.Tag = satir.Cells["malzemeno"].Value.ToString();
            txtmalzemeadet.Text = satir.Cells["malzemeadet"].Value.ToString();
            txtmalzemefiyat.Text = satir.Cells["malzemefiyat"].Value.ToString();
            txtmalzememarka.Text = satir.Cells["malzememarka"].Value.ToString();
            txtmodel.Text = satir.Cells["malzememodel"].Value.ToString();
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            Malzeme guncelle = new Malzeme();
            guncelle.malzemeno=   Convert.ToInt32(txtmalzemead.Tag);
            guncelle.malzemeadi = txtmalzemead.Text;
            guncelle.malzemeadet = int.Parse(txtmalzemeadet.Text);
            guncelle.malzemefiyat = decimal.Parse(txtmalzemefiyat.Text);
            guncelle.malzememarka = txtmalzememarka.Text;
            guncelle.malzememodel = txtmodel.Text;
            baglanti.mguncelle(guncelle.malzemeno, guncelle.malzemeadi, guncelle.malzemeadet, guncelle.malzemefiyat, guncelle.malzememarka, guncelle.malzememodel);
            baglanti.SaveChanges();
            goster();
        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            Malzeme ara = new Malzeme();
            ara.malzemeadi = txtmalzemead.Text;
            dataGridView1.DataSource = baglanti.mbul(ara.malzemeadi);
        }
    }
}
