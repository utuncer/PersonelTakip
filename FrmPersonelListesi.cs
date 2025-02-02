﻿using System;
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
    public partial class FrmPersonelListesi : Form
    {
        public FrmPersonelListesi()
        {
            InitializeComponent();
        }

        private void textUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece sayı girilmesini sağlayan kod
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmPersonelBilgileri frm = new FrmPersonelBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true; //Kapandığında bu formun tekrar görünmesi için
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            FrmPersonelBilgileri frm = new FrmPersonelBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
