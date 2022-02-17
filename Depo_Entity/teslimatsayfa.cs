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
    public partial class teslimatsayfa : Form
    {
        public teslimatsayfa()
        {
            InitializeComponent();
        }
        DepoEntities4 baglanti = new DepoEntities4();
        private void listelebtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.tlistele();
        }
        public void goster()
        {
            dataGridView1.DataSource = baglanti.tlistele();
        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            Teslimat ara = new Teslimat();
            ara.teslimatadi = txtsadı.Text;
            dataGridView1.DataSource = baglanti.tbul(ara.teslimatadi);
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            Teslimat guncelle = new Teslimat();
            guncelle.teslimatno = Convert.ToInt32(txtsadı.Tag);
            guncelle.teslimatadi = txtsadı.Text;
            guncelle.teslimatadres = txttadres.Text;
            guncelle.ucret = decimal.Parse(txtucret.Text);
            guncelle.sektorno = int.Parse(txtsektorno.Text);
            baglanti.tguncelle(guncelle.teslimatno,guncelle.teslimatadi,guncelle.teslimatadres,guncelle.ucret,guncelle.sektorno);
            baglanti.SaveChanges();
            goster();
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            Teslimat sil = new Teslimat();
            sil.teslimatno = Convert.ToInt32(txtsadı.Tag);
            baglanti.tsil(sil.teslimatno);
            baglanti.SaveChanges();
            goster();
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            Teslimat ekle = new Teslimat();
            ekle.teslimatadi = txtsadı.Text;
            ekle.teslimatadres = txttadres.Text;
            ekle.ucret = decimal.Parse(txtucret.Text);
            ekle.sektorno = int.Parse(txtsektorno.Text);
            baglanti.tekle(ekle.teslimatadi, ekle.teslimatadres, ekle.ucret, ekle.sektorno);
            baglanti.SaveChanges();
            goster();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtsadı.Text = satir.Cells["teslimatadi"].Value.ToString();
            txtsadı.Tag = satir.Cells["teslimatno"].Value.ToString();
            txttadres.Text = satir.Cells["teslimatadres"].Value.ToString();
            txtucret.Text = satir.Cells["ucret"].Value.ToString();
            txtsektorno.Text = satir.Cells["sektorno"].Value.ToString();
        }
    }
}
