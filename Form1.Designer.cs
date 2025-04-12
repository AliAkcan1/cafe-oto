namespace StokTakipApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgvUrunler;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(30, 30);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.PlaceholderText = "Ürün Adı";
            this.txtUrunAdi.Size = new System.Drawing.Size(150, 23);
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(30, 60);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.PlaceholderText = "Kategori";
            this.txtKategori.Size = new System.Drawing.Size(150, 23);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(30, 90);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.PlaceholderText = "Miktar";
            this.txtMiktar.Size = new System.Drawing.Size(150, 23);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(30, 120);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.PlaceholderText = "Fiyat";
            this.txtFiyat.Size = new System.Drawing.Size(150, 23);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(200, 30);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(200, 60);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 23);
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(200, 90);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 23);
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(30, 160);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.RowTemplate.Height = 25;
            this.dgvUrunler.Size = new System.Drawing.Size(440, 200);
            this.dgvUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellClick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvUrunler);
            this.Name = "Form1";
            this.Text = "Stok Takip";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
