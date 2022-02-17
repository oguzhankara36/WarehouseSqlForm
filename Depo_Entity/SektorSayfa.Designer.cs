
namespace Depo_Entity
{
    partial class SektorSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsadı = new System.Windows.Forms.TextBox();
            this.txtsacıklama = new System.Windows.Forms.TextBox();
            this.txtmno = new System.Windows.Forms.TextBox();
            this.eklebtn = new System.Windows.Forms.Button();
            this.silbtn = new System.Windows.Forms.Button();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.arabtn = new System.Windows.Forms.Button();
            this.listelebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsfaaliyet = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "sektör adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "sektör faaliyet yılı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "sektör açıklama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "malzeme no";
            // 
            // txtsadı
            // 
            this.txtsadı.Location = new System.Drawing.Point(124, 51);
            this.txtsadı.Name = "txtsadı";
            this.txtsadı.Size = new System.Drawing.Size(100, 20);
            this.txtsadı.TabIndex = 4;
            // 
            // txtsacıklama
            // 
            this.txtsacıklama.Location = new System.Drawing.Point(124, 124);
            this.txtsacıklama.Name = "txtsacıklama";
            this.txtsacıklama.Size = new System.Drawing.Size(100, 20);
            this.txtsacıklama.TabIndex = 6;
            // 
            // txtmno
            // 
            this.txtmno.Location = new System.Drawing.Point(124, 161);
            this.txtmno.Name = "txtmno";
            this.txtmno.Size = new System.Drawing.Size(100, 20);
            this.txtmno.TabIndex = 7;
            // 
            // eklebtn
            // 
            this.eklebtn.Location = new System.Drawing.Point(93, 313);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(75, 23);
            this.eklebtn.TabIndex = 8;
            this.eklebtn.Text = "ekle";
            this.eklebtn.UseVisualStyleBackColor = true;
            this.eklebtn.Click += new System.EventHandler(this.eklebtn_Click);
            // 
            // silbtn
            // 
            this.silbtn.Location = new System.Drawing.Point(188, 313);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(75, 23);
            this.silbtn.TabIndex = 9;
            this.silbtn.Text = "sil";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // guncellebtn
            // 
            this.guncellebtn.Location = new System.Drawing.Point(288, 312);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(75, 23);
            this.guncellebtn.TabIndex = 10;
            this.guncellebtn.Text = "güncelle";
            this.guncellebtn.UseVisualStyleBackColor = true;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // arabtn
            // 
            this.arabtn.Location = new System.Drawing.Point(387, 313);
            this.arabtn.Name = "arabtn";
            this.arabtn.Size = new System.Drawing.Size(75, 23);
            this.arabtn.TabIndex = 11;
            this.arabtn.Text = "ara";
            this.arabtn.UseVisualStyleBackColor = true;
            this.arabtn.Click += new System.EventHandler(this.arabtn_Click);
            // 
            // listelebtn
            // 
            this.listelebtn.Location = new System.Drawing.Point(538, 214);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(75, 23);
            this.listelebtn.TabIndex = 12;
            this.listelebtn.Text = "listele";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 170);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtsfaaliyet
            // 
            this.txtsfaaliyet.Location = new System.Drawing.Point(124, 84);
            this.txtsfaaliyet.Name = "txtsfaaliyet";
            this.txtsfaaliyet.Size = new System.Drawing.Size(172, 20);
            this.txtsfaaliyet.TabIndex = 14;
            // 
            // SektorSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsfaaliyet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listelebtn);
            this.Controls.Add(this.arabtn);
            this.Controls.Add(this.guncellebtn);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.eklebtn);
            this.Controls.Add(this.txtmno);
            this.Controls.Add(this.txtsacıklama);
            this.Controls.Add(this.txtsadı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SektorSayfa";
            this.Text = "SektorSayfa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsadı;
        private System.Windows.Forms.TextBox txtsacıklama;
        private System.Windows.Forms.TextBox txtmno;
        private System.Windows.Forms.Button eklebtn;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.Button guncellebtn;
        private System.Windows.Forms.Button arabtn;
        private System.Windows.Forms.Button listelebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker txtsfaaliyet;
    }
}