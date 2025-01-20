using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            FrmPersonelListesi frm = new FrmPersonelListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;// Kapatıldığı zaman tekrar gözükmesi için
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIs_Click(object sender, EventArgs e)
        {
            FrmIsListesi frm = new FrmIsListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;// Kapatıldığı zaman tekrar gözükmesi için
        }

        private void btnMaas_Click(object sender, EventArgs e)
        {
            FrmMaasListesi frm = new FrmMaasListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;// Kapatıldığı zaman tekrar gözükmesi için
        }

        private void btnIzin_Click(object sender, EventArgs e)
        {
            FrmIzinListesi frm = new FrmIzinListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnDepartman_Click(object sender, EventArgs e)
        {
            FrmDepartmanListesi frm = new FrmDepartmanListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnPozisyon_Click(object sender, EventArgs e)
        {
            FrmPozisyonListesi frm = new FrmPozisyonListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Uygulama kapatıldığında yani x işaretine basıldığında çalışan komut
            Application.Exit();
        }
    }
}
