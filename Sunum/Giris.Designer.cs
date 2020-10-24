namespace Sunum
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.personellbl = new System.Windows.Forms.Label();
            this.Urunlbl = new System.Windows.Forms.Label();
            this.PBPersonel = new System.Windows.Forms.PictureBox();
            this.PBUrun = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // personellbl
            // 
            this.personellbl.AutoSize = true;
            this.personellbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personellbl.ForeColor = System.Drawing.Color.Maroon;
            this.personellbl.Location = new System.Drawing.Point(39, 35);
            this.personellbl.Name = "personellbl";
            this.personellbl.Size = new System.Drawing.Size(275, 38);
            this.personellbl.TabIndex = 0;
            this.personellbl.Text = "Personel İşlemleri";
            // 
            // Urunlbl
            // 
            this.Urunlbl.AutoSize = true;
            this.Urunlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Urunlbl.ForeColor = System.Drawing.Color.Maroon;
            this.Urunlbl.Location = new System.Drawing.Point(496, 35);
            this.Urunlbl.Name = "Urunlbl";
            this.Urunlbl.Size = new System.Drawing.Size(217, 38);
            this.Urunlbl.TabIndex = 1;
            this.Urunlbl.Text = "Ürün İşlemleri";
            // 
            // PBPersonel
            // 
            this.PBPersonel.Image = ((System.Drawing.Image)(resources.GetObject("PBPersonel.Image")));
            this.PBPersonel.Location = new System.Drawing.Point(12, 113);
            this.PBPersonel.Name = "PBPersonel";
            this.PBPersonel.Size = new System.Drawing.Size(352, 263);
            this.PBPersonel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBPersonel.TabIndex = 2;
            this.PBPersonel.TabStop = false;
            this.PBPersonel.Click += new System.EventHandler(this.PBPersonel_Click);
            // 
            // PBUrun
            // 
            this.PBUrun.Image = ((System.Drawing.Image)(resources.GetObject("PBUrun.Image")));
            this.PBUrun.Location = new System.Drawing.Point(434, 113);
            this.PBUrun.Name = "PBUrun";
            this.PBUrun.Size = new System.Drawing.Size(352, 263);
            this.PBUrun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBUrun.TabIndex = 3;
            this.PBUrun.TabStop = false;
            this.PBUrun.Click += new System.EventHandler(this.PBUrun_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(798, 410);
            this.Controls.Add(this.PBUrun);
            this.Controls.Add(this.PBPersonel);
            this.Controls.Add(this.Urunlbl);
            this.Controls.Add(this.personellbl);
            this.Name = "Giris";
            this.Text = "Giris Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Giris_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PBPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label personellbl;
        private System.Windows.Forms.Label Urunlbl;
        private System.Windows.Forms.PictureBox PBPersonel;
        private System.Windows.Forms.PictureBox PBUrun;
    }
}

