namespace Kitaplık.WinFormUI
{
    partial class Form_Kategoriler
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
            this.gbKategori = new System.Windows.Forms.GroupBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsıl = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbKategori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKategori
            // 
            this.gbKategori.Controls.Add(this.textBox1);
            this.gbKategori.Controls.Add(this.btnsıl);
            this.gbKategori.Controls.Add(this.btnguncelle);
            this.gbKategori.Controls.Add(this.btnekle);
            this.gbKategori.Controls.Add(this.lblAd);
            this.gbKategori.Location = new System.Drawing.Point(46, 43);
            this.gbKategori.Name = "gbKategori";
            this.gbKategori.Size = new System.Drawing.Size(705, 198);
            this.gbKategori.TabIndex = 0;
            this.gbKategori.TabStop = false;
            this.gbKategori.Text = "Kategori";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(26, 45);
            this.lblAd.Name = "lblAd";
            this.lblAd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAd.Size = new System.Drawing.Size(25, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Adı:";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(77, 78);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(160, 23);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(77, 107);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(160, 23);
            this.btnguncelle.TabIndex = 2;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            // 
            // btnsıl
            // 
            this.btnsıl.Location = new System.Drawing.Point(77, 136);
            this.btnsıl.Name = "btnsıl";
            this.btnsıl.Size = new System.Drawing.Size(160, 23);
            this.btnsıl.TabIndex = 3;
            this.btnsıl.Text = "SİL";
            this.btnsıl.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form_Kategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbKategori);
            this.Name = "Form_Kategoriler";
            this.Text = "Form_Kategoriler";
            this.gbKategori.ResumeLayout(false);
            this.gbKategori.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKategori;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnsıl;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}