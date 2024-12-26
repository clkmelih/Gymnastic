using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApp9
{
    public partial class ProgramFormu : Form
    {
        public ProgramFormu()
        {
            InitializeComponent();
        }

        private void ProgramFormu_Load(object sender, EventArgs e)
        {
            kayıtları_getir();

            ListBox[] listBoxes = { MiniklerGrubu, lstCocuklar, lstGencler, lstGenclik, lstYetişkinler };

            // Tüm grupları temizle
            foreach (var listBox in listBoxes)
                listBox.Items.Clear();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["sporcu_adi"].Value == null || row.Cells["doğum_tarihi"].Value == null)
                    continue;

                string sporcuAdi = row.Cells["sporcu_adi"].Value.ToString();
                DateTime dogumTarihi = Convert.ToDateTime(row.Cells["doğum_tarihi"].Value);
                int yas = CalculateAge(dogumTarihi);

                // Yaş gruplarına göre sınıflandırma
                if (yas >= 3 && yas <= 6)
                    MiniklerGrubu.Items.Add($"{sporcuAdi} - {yas} Yaş");
                else if (yas >= 7 && yas <= 10)
                    lstCocuklar.Items.Add($"{sporcuAdi} - {yas} Yaş");
                else if (yas >= 11 && yas <= 14)
                    lstGencler.Items.Add($"{sporcuAdi} - {yas} Yaş");
                else if (yas >= 15 && yas <= 18)
                    lstGenclik.Items.Add($"{sporcuAdi} - {yas} Yaş");
                else if (yas > 18)
                    lstYetişkinler.Items.Add($"{sporcuAdi} - {yas} Yaş");
            }

        }

        SqlConnection baglan = new SqlConnection(@"Data Source=MELIHVICTUS\ABSQLEXPRESS;Initial Catalog=Kayit;Integrated Security=True");

       
        public void kayıtları_getir()
        {
            baglan.Open();
            string getir = "Select * From Sporcular";
            SqlCommand komut = new SqlCommand(getir, baglan);

            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();

            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();

        }


        private int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.Date < birthDate.Date.AddYears(age)) age--;
            return age;
        }

       

        private void lstGencler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstCocuklar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
