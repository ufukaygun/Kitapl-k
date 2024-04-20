namespace Kitaplık.WinFormUI
{
    partial class Form_Yayincilar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbYayincilar = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnsıl = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbYayincilar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(48, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gbYayincilar
            // 
            this.gbYayincilar.Controls.Add(this.textBox1);
            this.gbYayincilar.Controls.Add(this.btnsıl);
            this.gbYayincilar.Controls.Add(this.btnguncelle);
            this.gbYayincilar.Controls.Add(this.btnekle);
            this.gbYayincilar.Controls.Add(this.lblAd);
            this.gbYayincilar.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbYayincilar.Location = new System.Drawing.Point(48, 39);
            this.gbYayincilar.Name = "gbYayincilar";
            this.gbYayincilar.Size = new System.Drawing.Size(705, 198);
            this.gbYayincilar.TabIndex = 2;
            this.gbYayincilar.TabStop = false;
            this.gbYayincilar.Text = "Yayıncılar";
            this.gbYayincilar.Enter += new System.EventHandler(this.gbKategori_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnsıl
            // 
            this.btnsıl.Location = new System.Drawing.Point(77, 137);
            this.btnsıl.Name = "btnsıl";
            this.btnsıl.Size = new System.Drawing.Size(160, 23);
            this.btnsıl.TabIndex = 3;
            this.btnsıl.Text = "SİL";
            this.btnsıl.UseVisualStyleBackColor = true;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(77, 108);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(160, 23);
            this.btnguncelle.TabIndex = 2;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(77, 79);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(160, 23);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
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
            // Form_Yayincilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbYayincilar);
            this.Name = "Form_Yayincilar";
            this.Text = "Form_Yayincilar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbYayincilar.ResumeLayout(false);
            this.gbYayincilar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbYayincilar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnsıl;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label lblAd;
    }
}