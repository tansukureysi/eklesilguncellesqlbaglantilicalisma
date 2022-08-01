using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace eklesilgüncelle
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-B7T40IKF\\SQLEXPRESS01; Initial Catalog=ürünler; Integrated Security=True");


        void temizle()
        {
            textBox1.Text="";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox2.Focus();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.ürünTableAdapter.Fill(this.ürünlerDataSet.ürün);

        }

        private void eklebutton_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            
            SqlCommand ekle = new SqlCommand("insert into urun (id, ürün, kategori, adet) values (@id,@urun,@kategori,@adet)", baglanti);
            ekle.Parameters.AddWithValue("@id", textBox1.Text);
            ekle.Parameters.AddWithValue("@urun", textBox2.Text);
            ekle.Parameters.AddWithValue("@kategori", textBox3.Text);
            ekle.Parameters.AddWithValue("@adet", textBox4.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();


            MessageBox.Show("Ürün bilgisi eklendi.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
          
        }

        private void silbutton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
           
            SqlCommand sil = new SqlCommand("Delete from urun where id=@id", baglanti)
;           sil.Parameters.AddWithValue("@id", textBox1.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ürün kaydı silindi.");
        }

        private void güncellebutton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("update urun set ürün=@urun, kategori=@kategori, adet=@adet where id=@id ", baglanti);
            guncelle.Parameters.AddWithValue("@id", textBox1.Text);
            guncelle.Parameters.AddWithValue("@urun", textBox2.Text);
            guncelle.Parameters.AddWithValue("@kategori", textBox3.Text);
            guncelle.Parameters.AddWithValue("@adet", textBox4.Text);
           
            guncelle.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ürün güncellemesi tamamlandı.");
        }
    }
}
