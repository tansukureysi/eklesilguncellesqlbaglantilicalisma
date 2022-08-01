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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-B7T40IKF\\SQLEXPRESS01; Initial Catalog=ürünler; Integrated Security=True");
        SqlDataReader get;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void girisbutton_Click(object sender, EventArgs e)
        {
            //sql den giriş bilgilerini kontrol ettiriyorum
            string ss = "SELECT* FROM giris WHERE kullanıcı = @kullanıcı AND şifre=@şifre";
            SqlCommand check = new SqlCommand(ss, baglanti);
            check.Parameters.AddWithValue("@kullanıcı", textBox1.Text);
            check.Parameters.AddWithValue("@şifre", textBox1.Text);
            baglanti.Open();
            get = check.ExecuteReader();
            baglanti.Close();

            if (textBox1.Text == "kureysi" && textBox2.Text == "123")
            {
                
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!");
            }
        }
    }
}
