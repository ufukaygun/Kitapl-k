namespace Kitaplık.WinFormUI
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
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnYazarlar = new System.Windows.Forms.Button();
            this.btnYayıncılar = new System.Windows.Forms.Button();
            this.Adı = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ISBN = new System.Windows.Forms.Label();
            this.Yazar = new System.Windows.Forms.Label();
            this.Kategori = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAdı = new System.Windows.Forms.ComboBox();
            this.cmbISBN = new System.Windows.Forms.ComboBox();
            this.cmbYazar = new System.Windows.Forms.ComboBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.cmbYayınevi = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(12, 42);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(75, 23);
            this.btnKategori.TabIndex = 0;
            this.btnKategori.Text = "Kategoriler";
            this.btnKategori.UseVisualStyleBackColor = true;
            // 
            // btnYazarlar
            // 
            this.btnYazarlar.Location = new System.Drawing.Point(115, 42);
            this.btnYazarlar.Name = "btnYazarlar";
            this.btnYazarlar.Size = new System.Drawing.Size(75, 23);
            this.btnYazarlar.TabIndex = 1;
            this.btnYazarlar.Text = "Yazarlar";
            this.btnYazarlar.UseVisualStyleBackColor = true;
            // 
            // btnYayıncılar
            // 
            this.btnYayıncılar.Location = new System.Drawing.Point(207, 42);
            this.btnYayıncılar.Name = "btnYayıncılar";
            this.btnYayıncılar.Size = new System.Drawing.Size(75, 23);
            this.btnYayıncılar.TabIndex = 2;
            this.btnYayıncılar.Text = "Yayıncılar";
            this.btnYayıncılar.UseVisualStyleBackColor = true;
            // 
            // Adı
            // 
            this.Adı.AutoSize = true;
            this.Adı.Location = new System.Drawing.Point(27, 28);
            this.Adı.Name = "Adı";
            this.Adı.Size = new System.Drawing.Size(22, 13);
            this.Adı.TabIndex = 3;
            this.Adı.Text = "Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.cmbYayınevi);
            this.groupBox1.Controls.Add(this.cmbKategori);
            this.groupBox1.Controls.Add(this.cmbYazar);
            this.groupBox1.Controls.Add(this.cmbISBN);
            this.groupBox1.Controls.Add(this.cmbAdı);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Kategori);
            this.groupBox1.Controls.Add(this.Yazar);
            this.groupBox1.Controls.Add(this.ISBN);
            this.groupBox1.Controls.Add(this.Adı);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 220);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitaplar";
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Location = new System.Drawing.Point(24, 77);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(32, 13);
            this.ISBN.TabIndex = 4;
            this.ISBN.Text = "ISBN";
            // 
            // Yazar
            // 
            this.Yazar.AutoSize = true;
            this.Yazar.Location = new System.Drawing.Point(313, 16);
            this.Yazar.Name = "Yazar";
            this.Yazar.Size = new System.Drawing.Size(37, 13);
            this.Yazar.TabIndex = 5;
            this.Yazar.Text = "Yazar:";
            // 
            // Kategori
            // 
            this.Kategori.AutoSize = true;
            this.Kategori.Location = new System.Drawing.Point(313, 47);
            this.Kategori.Name = "Kategori";
            this.Kategori.Size = new System.Drawing.Size(46, 13);
            this.Kategori.TabIndex = 6;
            this.Kategori.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Yayınevi";
            // 
            // cmbAdı
            // 
            this.cmbAdı.FormattingEnabled = true;
            this.cmbAdı.Location = new System.Drawing.Point(79, 25);
            this.cmbAdı.Name = "cmbAdı";
            this.cmbAdı.Size = new System.Drawing.Size(121, 21);
            this.cmbAdı.TabIndex = 8;
            // 
            // cmbISBN
            // 
            this.cmbISBN.FormattingEnabled = true;
            this.cmbISBN.Location = new System.Drawing.Point(79, 69);
            this.cmbISBN.Name = "cmbISBN";
            this.cmbISBN.Size = new System.Drawing.Size(121, 21);
            this.cmbISBN.TabIndex = 9;
            // 
            // cmbYazar
            // 
            this.cmbYazar.FormattingEnabled = true;
            this.cmbYazar.Location = new System.Drawing.Point(371, 16);
            this.cmbYazar.Name = "cmbYazar";
            this.cmbYazar.Size = new System.Drawing.Size(121, 21);
            this.cmbYazar.TabIndex = 10;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(371, 44);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 11;
            // 
            // cmbYayınevi
            // 
            this.cmbYayınevi.FormattingEnabled = true;
            this.cmbYayınevi.Location = new System.Drawing.Point(371, 69);
            this.cmbYayınevi.Name = "cmbYayınevi";
            this.cmbYayınevi.Size = new System.Drawing.Size(121, 21);
            this.cmbYayınevi.TabIndex = 12;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(27, 115);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(743, 36);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(27, 157);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(743, 46);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(39, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 117);
            this.panel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 114);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnYayıncılar);
            this.Controls.Add(this.btnYazarlar);
            this.Controls.Add(this.btnKategori);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnYazarlar;
        private System.Windows.Forms.Button btnYayıncılar;
        private System.Windows.Forms.Label Adı;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cmbYayınevi;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox cmbYazar;
        private System.Windows.Forms.ComboBox cmbISBN;
        private System.Windows.Forms.ComboBox cmbAdı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Kategori;
        private System.Windows.Forms.Label Yazar;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

