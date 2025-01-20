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
    public partial class FrmIzinListesi : Form
    {
        public FrmIzinListesi()
        {
            InitializeComponent();
        }

        private void textUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmIzinBilgileri frm = new FrmIzinBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            FrmIzinBilgileri frm = new FrmIzinBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
