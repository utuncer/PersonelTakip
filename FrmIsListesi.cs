using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DTO;
using BLL;

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
        IsDTO dto = new IsDTO();
        bool combofull = false;
        IsDetayDTO detay = new IsDetayDTO();
        private void FrmIsListesi_Load(object sender, EventArgs e)
        {
            MessageBox.Show(UserStatic.PersonelID.ToString() + " " + UserStatic.UserNo.ToString() + " " + UserStatic.isAdmin.ToString());
            //  pnlForAdmin.Visible = false;
            Doldur();
        }

        void Doldur()
        {
            dto = IsBLL.GetAll();
            dataGridView1.DataSource = dto.Isler;
            dataGridView1.Columns[0].HeaderText = "Başlık";
            dataGridView1.Columns[1].HeaderText = "User No";
            dataGridView1.Columns[2].HeaderText = "Ad";
            dataGridView1.Columns[3].HeaderText = "Soyad";
            dataGridView1.Columns[4].HeaderText = "Departman";
            dataGridView1.Columns[5].HeaderText = "Pozisyon";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;

            cmbDepartman.DataSource = dto.Departmanlar;
            cmbDepartman.DisplayMember = "DepartmanAd";
            cmbDepartman.ValueMember = "ID";
            cmbDepartman.SelectedIndex = -1;
            if (dto.Departmanlar.Count > 0)
                combofull = true;
            cmbPozisyon.DataSource = dto.Pozisyonlar;
            cmbPozisyon.DisplayMember = "PozisyonAd";
            cmbPozisyon.ValueMember = "ID";
            cmbPozisyon.SelectedIndex = -1;
            cmbIsDurum.DataSource = dto.Durumlar;
            cmbIsDurum.DisplayMember = "DurumAd";
            cmbIsDurum.ValueMember = "ID";
            cmbIsDurum.SelectedIndex = -1;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmIsBilgileri frm = new FrmIsBilgileri();
            this.Hide();
            frm.isUpdate = true;
            frm.ShowDialog();
            this.Visible = true;// Kapatıldığı zaman tekrar gözükmesi için
            combofull = false;
            Doldur();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            FrmIsBilgileri frm = new FrmIsBilgileri();
            this.Hide();
            frm.isUpdate = true;
            frm.detay = detay;
            frm.ShowDialog();
            this.Visible = true;// Kapatıldığı zaman tekrar gözükmesi için
            combofull = false;
            Doldur();
            Temizle();
        }

        private void cmbDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                int departmanID = Convert.ToInt32(cmbDepartman.SelectedValue);
                cmbPozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == departmanID).ToList();
            }
        }
        List<IsDetayDTO> listt = new List<IsDetayDTO>();
        private void btnAra_Click(object sender, EventArgs e)
        {
            listt = dto.Isler;
            if (txtUserNo.Text.Trim() != "")
                listt = listt.Where(x => x.UserNo == Convert.ToInt32(txtUserNo.Text)).ToList();
            if (txtAd.Text.Trim() != "")
                listt = listt.Where(x => x.Ad.Contains(txtAd.Text)).ToList();
            if (txtSoyad.Text.Trim() != "")
                listt = listt.Where(x => x.Soyad.Contains(txtSoyad.Text)).ToList();
            if (cmbDepartman.SelectedIndex != -1)
                listt = listt.Where(x => x.DepartmanID == Convert.ToInt32(cmbDepartman.SelectedValue)).ToList();
            if (cmbPozisyon.SelectedIndex != -1)
                listt = listt.Where(x => x.PozisyonID == Convert.ToInt32(cmbPozisyon.SelectedValue)).ToList();
            if (cmbIsDurum.SelectedIndex != -1)
                listt = listt.Where(x => x.IsDurumID == Convert.ToInt32(cmbIsDurum.SelectedValue)).ToList();
            if (rbBaslamaTarihi.Checked)
                listt = listt.Where(x => x.IsBaslamaTarihi >= Convert.ToDateTime(dpBaslama.Value) && x.IsBaslamaTarihi < Convert.ToDateTime(dpBitis.Value)).ToList();
            if (rbTeslimTarihi.Checked)
                listt = listt.Where(x => x.IsBitisTarihi >= Convert.ToDateTime(dpBaslama.Value) && x.IsBitisTarihi < Convert.ToDateTime(dpBitis.Value)).ToList();

            dataGridView1.DataSource = listt;
        }
        void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtUserNo.Clear();
            cmbDepartman.SelectedIndex = -1;
            cmbPozisyon.DataSource = dto.Pozisyonlar;
            cmbPozisyon.SelectedIndex = -1;
            cmbIsDurum.SelectedIndex = -1;
            dpBaslama.Value = DateTime.Today;
            dpBitis.Value = DateTime.Today;
            dataGridView1.DataSource = dto.Isler;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detay.IsID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[14].Value);
            detay.UserNo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            detay.PersonelID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            detay.IsDurumID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[11].Value);
            detay.Baslik = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            detay.Icerik = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            detay.Ad = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            detay.Soyad = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            detay.IsBaslamaTarihi = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
            detay.IsBitisTarihi = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[13].Value);
        }
    }
}
