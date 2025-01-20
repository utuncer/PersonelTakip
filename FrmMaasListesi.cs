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
    public partial class FrmMaasListesi : Form
    {
        public FrmMaasListesi()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmMaasBilgileri frm = new FrmMaasBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;// Kapatıldığı zaman tekrar gözükmesi için
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            FrmMaasBilgileri frm = new FrmMaasBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;// Kapatıldığı zaman tekrar gözükmesi için
        }
    }
}
