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
    public partial class SektorSayfa : Form
    {
        public SektorSayfa()
        {
            InitializeComponent();
        }
        DepoEntities4 baglanti = new DepoEntities4();
        private void listelebtn_Click(object sender, EventArgs e)
        {
            goster();
        }
        public void goster()
        {
            dataGridView1.DataSource = baglanti.slistele();
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            Sektor ekle = new Sektor();
            ekle.sektoradi = txtsadı.Text;
            ekle.sektorfaaliyetyil = txtsfaaliyet.Value.ToString();
            ekle.sektoraciklama = txtsacıklama.Text;
            ekle.malzemeno =int.Parse(txtmno.Text);
            baglanti.sekle(ekle.sektoradi, ekle.sektorfaaliyetyil, ekle.sektoraciklama, ekle.malzemeno);
            baglanti.SaveChanges();
            goster();
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            Sektor sil = new Sektor();
            sil.sektorno = Convert.ToInt32(txtsadı.Tag);
            baglanti.ssil(sil.sektorno);
            baglanti.SaveChanges();
            goster();
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            Sektor guncelle = new Sektor();
            guncelle.sektorno = Convert.ToInt32( txtsadı.Tag);
            guncelle.sektoradi = txtsadı.Text;
            guncelle.sektorfaaliyetyil = txtsfaaliyet.Value.ToString();
            guncelle.sektoraciklama = txtsacıklama.Text;
            guncelle.malzemeno =int.Parse( txtmno.Text);
            baglanti.sguncelle(guncelle.sektorno, guncelle.sektoradi, guncelle.sektorfaaliyetyil, guncelle.sektoraciklama, guncelle.malzemeno);
            baglanti.SaveChanges();
            goster();
        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            Sektor ara = new Sektor();
            ara.sektoradi = txtsadı.Text;
            dataGridView1.DataSource = baglanti.sbul(ara.sektoradi);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtsadı.Text = satir.Cells["sektoradi"].Value.ToString();
            txtsadı.Tag = satir.Cells["sektorno"].Value.ToString();
            txtsfaaliyet.Text = satir.Cells["sektorfaaliyetyil"].Value.ToString();
            txtsacıklama.Text = satir.Cells["sektoraciklama"].Value.ToString();
            txtmno.Text = satir.Cells["malzemeno"].Value.ToString();
        }
    }
}
