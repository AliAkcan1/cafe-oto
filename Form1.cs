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
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Urunler", con);
                dt = new DataTable();
                da.Fill(dt);
                dgvUrunler.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Urunler (UrunAdi, Kategori, Miktar, Fiyat) VALUES (@adi, @kategori, @miktar, @fiyat)", con))
                {
                    cmd.Parameters.AddWithValue("@adi", txtUrunAdi.Text);
                    cmd.Parameters.AddWithValue("@kategori", txtKategori.Text);
                    cmd.Parameters.AddWithValue("@miktar", Convert.ToInt32(txtMiktar.Text));
                    cmd.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(txtFiyat.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                con.Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE Urunler SET UrunAdi=@adi, Kategori=@kategori, Miktar=@miktar, Fiyat=@fiyat WHERE Id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@adi", txtUrunAdi.Text);
                    cmd.Parameters.AddWithValue("@kategori", txtKategori.Text);
                    cmd.Parameters.AddWithValue("@miktar", Convert.ToInt32(txtMiktar.Text));
                    cmd.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(txtFiyat.Text));
                    cmd.Parameters.AddWithValue("@id", dgvUrunler.CurrentRow.Cells[0].Value);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                con.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Urunler WHERE Id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@id", dgvUrunler.CurrentRow.Cells[0].Value);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                con.Close();
            }
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUrunler.Rows[e.RowIndex];
                txtUrunAdi.Text = row.Cells[1].Value.ToString();
                txtKategori.Text = row.Cells[2].Value.ToString();
                txtMiktar.Text = row.Cells[3].Value.ToString();
                txtFiyat.Text = row.Cells[4].Value.ToString();
            }
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == ',' && txt.Text.Contains(","))
                e.Handled = true;
        }

        void Temizle()
        {
            txtUrunAdi.Clear();
            txtKategori.Clear();
            txtMiktar.Clear();
            txtFiyat.Clear();
        }
    }
}
