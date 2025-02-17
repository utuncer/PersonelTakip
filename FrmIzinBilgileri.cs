using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DTO;

namespace PersonelTakip
{
    public partial class FrmIzinBilgileri : Form
    {
        public FrmIzinBilgileri()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        TimeSpan sure = new TimeSpan();
        private void FrmIzinBilgileri_Load(object sender, EventArgs e)
        {
            textUserNo.Text = UserStatic.UserNo.ToString();
        }

        private void dpBaslama_ValueChanged(object sender, EventArgs e)
        {
            sure = dpBitis.Value.Date - dpBaslama.Value.Date;
            txtSure.Text = sure.TotalDays.ToString();
        }

        private void dpBitis_ValueChanged(object sender, EventArgs e)
        {
            sure = dpBitis.Value.Date - dpBaslama.Value.Date;
            txtSure.Text = sure.TotalDays.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtSure.Text.Trim() == "")
                MessageBox.Show("Süre Boş");
            else if (Convert.ToInt32(txtSure.Text) <= 0)
                MessageBox.Show("İzin Süresi Geçersiz");
            else if (txtAciklama.Text.Trim() == "")
                MessageBox.Show("Lütfen Açıklama Giriniz");
            else
            {
                IZIN iz = new IZIN();
                iz.PersonelID = UserStatic.PersonelID;
                iz.IzinDurumID = 1;
                iz.IzınBaslamaTarihi = dpBaslama.Value;
                iz.IzınBitisTarihi = dpBitis.Value;
                iz.Sure = Convert.ToInt32(sure.TotalDays);
                iz.Aciklama = txtAciklama.Text;
                IzinBLL.IzinEkle(iz);
                MessageBox.Show("İzin Eklendi");
                dpBaslama.Value = DateTime.Today;
                dpBitis.Value = DateTime.Today;
                txtSure.Clear();
                txtAciklama.Clear();
            }
        }
    }
}
