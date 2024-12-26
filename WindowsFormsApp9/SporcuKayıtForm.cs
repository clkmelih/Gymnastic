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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp9
{
    public partial class SporcuKayıtForm : Form
    {
        public SporcuKayıtForm()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Data Source=MELIHVICTUS\ABSQLEXPRESS;Initial Catalog=Kayit;Integrated Security=True");
        public void verikaydet()
        {

            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();

                    string kayit = "INSERT INTO Sporcular " +
                           "(sporcu_adi, doğum_tarihi, cinsiyet, tc_kimlik, adres, tel_no, e_posta, veli_ad_soyad, veli_tckimlik, veli_no, sağlık_durumu, sağlık_sorunları) " +
                           "VALUES (@sporcu_adi, @doğum_tarihi, @cinsiyet, @tc_kimlik, @adres, @tel_no, @e_posta, @veli_ad_soyad, @veli_tckimlik, @veli_no, @sağlık_durumu, @sağlık_sorunları)";
                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@sporcu_adi", textBox1.Text);
                    komut.Parameters.AddWithValue("@doğum_tarihi", textBox2.Text);
                    komut.Parameters.AddWithValue("@cinsiyet", textBox3.Text);
                    komut.Parameters.AddWithValue("@tc_kimlik", textBox4.Text);
                    komut.Parameters.AddWithValue("@adres", textBox5.Text);
                    komut.Parameters.AddWithValue("@tel_no", textBox6.Text);
                    komut.Parameters.AddWithValue("@e_posta", textBox7.Text);
                    komut.Parameters.AddWithValue("@veli_ad_soyad", textBox8.Text);
                    komut.Parameters.AddWithValue("@veli_tckimlik", textBox9.Text);
                    komut.Parameters.AddWithValue("@veli_no", textBox10.Text);
                    komut.Parameters.AddWithValue("@sağlık_durumu", textBox11.Text);
                    komut.Parameters.AddWithValue("@sağlık_sorunları", textBox12.Text);

                    komut.ExecuteNonQuery();


                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata var" + hata.Message);
            }
            MessageBox.Show("Sporcu Kaydedildi.");
        }
        public void kayıtları_getir()
        {
            baglan.Close();
            baglan.Open();
            string getir = "Select * From Sporcular";
            SqlCommand komut = new SqlCommand(getir, baglan);

            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();

            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();

        }
        public void verigüncelle()
        {
            baglan.Close();
            baglan.Open();
            string kayıtgüncelle = ("Update Sporcular Set sporcu_adi =@ad, doğum_tarihi =@dog, cinsiyet = @cin, tc_kimlik =@tc, adres = @adres, tel_no = @no , e_posta = @e_posta, " +
                "veli_ad_soyad =@vad, veli_tckimlik = @vetc, veli_no = @veno, sağlık_durumu =@sadu, sağlık_sorunları = @saso Where uye_id=@id");
            SqlCommand komut = new SqlCommand(kayıtgüncelle, baglan);
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("@dog", textBox2.Text);
            komut.Parameters.AddWithValue("@cin", textBox3.Text);
            komut.Parameters.AddWithValue("@tc", textBox4.Text);
            komut.Parameters.AddWithValue("@adres", textBox5.Text);
            komut.Parameters.AddWithValue("@no", textBox6.Text);
            komut.Parameters.AddWithValue("@e_posta", textBox7.Text);
            komut.Parameters.AddWithValue("@vad", textBox8.Text);
            komut.Parameters.AddWithValue("@vetc", textBox9.Text);
            komut.Parameters.AddWithValue("@veno", textBox10.Text);
            komut.Parameters.AddWithValue("@sadu", textBox11.Text);
            komut.Parameters.AddWithValue("@saso", textBox12.Text);
            komut.Parameters.AddWithValue("@id", dataGridView1.Rows[i].Cells[0].Value);

            komut.ExecuteNonQuery();
            kayıtları_getir();
        }
        public void verisil(int id)
        {
            string sil = "Delete From Sporcular Where uye_id = @id";
            SqlCommand komut = new SqlCommand(sil, baglan);
            baglan.Open();
            komut.Parameters.AddWithValue("@id", id);

            komut.ExecuteNonQuery();

            baglan.Close();
        }
        public void aramayap()
        {
            string kayıt = "Select * From Sporcular Where sporcu_adi=@adsoyad";
            SqlCommand komut = new SqlCommand(kayıt, baglan);

            komut.Parameters.AddWithValue("@adsoyad", textBox13.Text);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();

        }




        private void button1_Click(object sender, EventArgs e)
        {
            verikaydet();
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            kayıtları_getir();
            MessageBox.Show("Sporcular Listelendi.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            aramayap();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow drow in dataGridView1.SelectedRows) {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                verisil(id);
                kayıtları_getir();
            }
        }
        int i = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            verigüncelle();
            MessageBox.Show("Kayıt Güncellendi.");
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            textBox9.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            textBox10.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
            textBox11.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
            textBox12.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();

        }

        private void KullanıcıKayıtForm_Load(object sender, EventArgs e)
        {

        }
    }
}
