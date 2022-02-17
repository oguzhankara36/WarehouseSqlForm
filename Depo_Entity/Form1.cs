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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void malzemebtn_Click(object sender, EventArgs e)
        {
            MalzemeSayfa mlz = new MalzemeSayfa();
            mlz.Show();
            this.Hide();
        }

        private void sektorbtn_Click(object sender, EventArgs e)
        {
            SektorSayfa sk = new SektorSayfa();
            sk.Show();
            this.Hide();
        }

        private void teslimatbtn_Click(object sender, EventArgs e)
        {
            teslimatsayfa tslm = new teslimatsayfa();
            tslm.Show();
            this.Hide();
        }
    }
}
