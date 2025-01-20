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
    public partial class FrmIsListesi : Form
    {
        public FrmIsListesi()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece sayı girilmesini sağlayan kod
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmIsListesi_Load(object sender, EventArgs e)
        {
            //  pnlForAdmin.Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmIsBilgileri frm = new FrmIsBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;// Kapatıldığı zaman tekrar gözükmesi için
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            FrmIsBilgileri frm = new FrmIsBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;// Kapatıldığı zaman tekrar gözükmesi için
        }
    }
}
