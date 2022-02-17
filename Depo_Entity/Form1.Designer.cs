
namespace Depo_Entity
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.malzemebtn = new System.Windows.Forms.Button();
            this.sektorbtn = new System.Windows.Forms.Button();
            this.teslimatbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // malzemebtn
            // 
            this.malzemebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("malzemebtn.BackgroundImage")));
            this.malzemebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.malzemebtn.Location = new System.Drawing.Point(269, 204);
            this.malzemebtn.Name = "malzemebtn";
            this.malzemebtn.Size = new System.Drawing.Size(189, 180);
            this.malzemebtn.TabIndex = 0;
            this.malzemebtn.UseVisualStyleBackColor = true;
            this.malzemebtn.Click += new System.EventHandler(this.malzemebtn_Click);
            // 
            // sektorbtn
            // 
            this.sektorbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sektorbtn.BackgroundImage")));
            this.sektorbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sektorbtn.Location = new System.Drawing.Point(513, 204);
            this.sektorbtn.Name = "sektorbtn";
            this.sektorbtn.Size = new System.Drawing.Size(189, 180);
            this.sektorbtn.TabIndex = 1;
            this.sektorbtn.UseVisualStyleBackColor = true;
            this.sektorbtn.Click += new System.EventHandler(this.sektorbtn_Click);
            // 
            // teslimatbtn
            // 
            this.teslimatbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teslimatbtn.BackgroundImage")));
            this.teslimatbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.teslimatbtn.Location = new System.Drawing.Point(767, 204);
            this.teslimatbtn.Name = "teslimatbtn";
            this.teslimatbtn.Size = new System.Drawing.Size(189, 180);
            this.teslimatbtn.TabIndex = 2;
            this.teslimatbtn.UseVisualStyleBackColor = true;
            this.teslimatbtn.Click += new System.EventHandler(this.teslimatbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1167, 649);
            this.Controls.Add(this.teslimatbtn);
            this.Controls.Add(this.sektorbtn);
            this.Controls.Add(this.malzemebtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button malzemebtn;
        private System.Windows.Forms.Button sektorbtn;
        private System.Windows.Forms.Button teslimatbtn;
    }
}

