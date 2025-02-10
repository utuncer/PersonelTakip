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

namespace PersonelTakip
{
    public partial class FrmPozisyonBilgileri : Form
    {
        public FrmPozisyonBilgileri()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<DEPARTMAN> departmanlar = new List<DEPARTMAN>();
        private void FrmPozisyonBilgileri_Load(object sender, EventArgs e)
        {
            departmanlar = DAL.DAO.DepartmanDAO.DepartmanGetir();
            cmbDepartman.DataSource = departmanlar;
            cmbDepartman.DisplayMember = "DepartmanAd";
            cmbDepartman.ValueMember = "ID";
            cmbDepartman.SelectedIndex = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtPozisyonAd.Text.Trim() == "")
            {
                MessageBox.Show("Pozisyon Adı Giriniz");
            }
            else if (cmbDepartman.SelectedIndex == -1)
            {
                MessageBox.Show("Departman Seçiniz");
            }
            else
            {
                POZISYON pz = new POZISYON();
                pz.PozisyonAd = txtPozisyonAd.Text;
                pz.DepartmanID = Convert.ToInt32(cmbDepartman.SelectedValue);
                PozisyonBLL.PozisyonEkle(pz);
                MessageBox.Show("Pozisyon Eklendi");
                txtPozisyonAd.Clear();
                cmbDepartman.SelectedIndex = -1;
            }

        }
    }
}
