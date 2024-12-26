using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class AnaEkranForm : Form
    {
        public AnaEkranForm()
        {
            InitializeComponent();
        }

        private void sporcuKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SporcuKayıtForm x = new SporcuKayıtForm();
            x.Show();
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ProgramFormu x = new ProgramFormu();
            x.Show();
        }

        private void AnaEkranForm_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 saniye
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Gün, tarih ve saati güncelle
            string gun = DateTime.Now.ToString("dddd"); // Gün adı
            string tarih = DateTime.Now.ToString("dd MMMM yyyy"); // Güncel tarih
            string saat = DateTime.Now.ToString("HH:mm:ss"); // Saat

            lblGunTarihSaat.Text = $"{gun}, {tarih} - {saat}";
        }

       
    }
}
