using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StokTakipApp
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Server=localhost;Database=StokTakip;Trusted_Connection=True;");
        SqlDataAdapter da;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            da = new SqlDataAdapter("SELECT * FROM Urunler", con);
            dt = new DataTable();
            da.Fill(dt);
            dgvUrunler.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Urunler (UrunAdi, Kategori, Miktar, Fiyat) VALUES (@adi, @kategori, @miktar, @fiyat)", con);
            cmd.Parameters.AddWithValue("@adi", txtUrunAdi.Text);
            cmd.Parameters.AddWithValue("@kategori", txtKategori.Text);
            cmd.Parameters.AddWithValue("@miktar", txtMiktar.Text);
            cmd.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Urunler SET UrunAdi=@adi, Kategori=@kategori, Miktar=@miktar, Fiyat=@fiyat WHERE Id=@id", con);
            cmd.Parameters.AddWithValue("@adi", txtUrunAdi.Text);
            cmd.Parameters.AddWithValue("@kategori", txtKategori.Text);
            cmd.Parameters.AddWithValue("@miktar", txtMiktar.Text);
            cmd.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
            cmd.Parameters.AddWithValue("@id", dgvUrunler.CurrentRow.Cells[0].Value);
            cmd.ExecuteNonQuery();
            con.Close();
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Urunler WHERE Id=@id", con);
            cmd.Parameters.AddWithValue("@id", dgvUrunler.CurrentRow.Cells[0].Value);
            cmd.ExecuteNonQuery();
            con.Close();
            Listele();
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Text = dgvUrunler.CurrentRow.Cells[1].Value.ToString();
            txtKategori.Text = dgvUrunler.CurrentRow.Cells[2].Value.ToString();
            txtMiktar.Text = dgvUrunler.CurrentRow.Cells[3].Value.ToString();
            txtFiyat.Text = dgvUrunler.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
            {
                e.Handled = true;
            }
        }
    }
} 
