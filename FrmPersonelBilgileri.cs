using BLL;
using DAL;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.CodeDom;
using System.Diagnostics.Contracts;

namespace PersonelTakip
{
    public partial class FrmPersonelBilgileri : Form
    {
        public FrmPersonelBilgileri()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece sayı girilmesini sağlayan kod
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece sayı girilmesini sağlayan kod
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        PersonelDTO dto = new PersonelDTO();
        public PersonelDetayDTO detay = new PersonelDetayDTO();
        public bool isUpdate = false;
        string resim2 = "";
        private void FrmPersonelBilgileri_Load(object sender, EventArgs e)
        {
            dto = PersonelBLL.GetAll();
            cmbDepartman.DataSource = dto.Departmanlar;
            cmbDepartman.DisplayMember = "DepartmanAd";
            cmbDepartman.ValueMember = "ID";
            cmbDepartman.SelectedIndex = -1;

            cmbPozisyon.DataSource = dto.Pozisyonlar;
            cmbPozisyon.DisplayMember = "PozisyonAd";
            cmbPozisyon.ValueMember = "ID";
            cmbPozisyon.SelectedIndex = -1;

            if (dto.Departmanlar.Count > 0)
            {
                combofull = true;
            }

            if (isUpdate)
            {
                txtAd.Text = detay.Ad;
                txtAdress.Text = detay.Adres;
                txtMaas.Text = detay.Maas.ToString();
                txtPassword.Text = detay.password;
                txtSoyad.Text = detay.Soyad;
                txtUserNo.Text = detay.UserNo.ToString();
                chbIsAdmin.Checked = detay.isAdmin;
                cmbDepartman.SelectedValue = detay.DepartmanID;
                cmbPozisyon.SelectedValue = detay.PozisyonID;
                resim2 = Application.StartupPath + "\\resimler\\" + detay.Resim;
                txtResim.Text = resim2;
               // pictureBox1.Load(resim2);

                if(!UserStatic.isAdmin)
                {
                    txtAd.Enabled = false;
                    txtSoyad.Enabled = false;
                    txtMaas.Enabled = false;
                    txtUserNo.Enabled = false;
                    chbIsAdmin.Enabled = false;
                    cmbDepartman.Enabled = false;
                    cmbPozisyon.Enabled = false; 
                }
            }

        }
        string resimad = "";
        bool combofull = false;
        private void cmbDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull == true)
            {
                int departmanID = Convert.ToInt32(cmbDepartman.SelectedValue);
                cmbPozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == departmanID).ToList();
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                txtResim.Text = openFileDialog1.FileName;
                resimad = Guid.NewGuid().ToString(); // Benzersiz karakter dizini oluşturur
                resimad += openFileDialog1.SafeFileName;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "")
                MessageBox.Show("User No Boş");
            else if (PersonelBLL.isUnique(Convert.ToInt32(txtUserNo.Text)))
            {
                MessageBox.Show("Lütfen User No Değiştirin Aynısını Kullanan Bir Personel Mevcut");
            }
            else if (txtAd.Text.Trim() == "")
                MessageBox.Show("Ad Boş");
            else if (txtSoyad.Text.Trim() == "")
                MessageBox.Show("Soyad Boş");
            else if (txtResim.Text.Trim() == "")
                MessageBox.Show("Resim Boş");
            else if (txtMaas.Text.Trim() == "")
                MessageBox.Show("Maaş Boş");

            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Şifre Boş");
            }
            else if (cmbDepartman.SelectedIndex == -1)
                MessageBox.Show("Departman Boş");
            else if (cmbPozisyon.SelectedIndex == -1)
                MessageBox.Show("Pozisyon Boş");
            else
            {
                if (isUpdate)
                {
                    DialogResult result = MessageBox.Show("Emin misin?", "Dikkat", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        PersonelDetayDTO pr = new PersonelDetayDTO();
                        pr.PersonelID = detay.PersonelID;
                        pr.UserNo = Convert.ToInt32(txtUserNo.Text);
                        pr.Ad = txtAd.Text;
                        pr.Soyad = txtSoyad.Text;
                        pr.Maas = Convert.ToInt32(txtMaas.Text);
                        pr.isAdmin = chbIsAdmin.Checked;
                        pr.password = txtPassword.Text;
                        pr.PozisyonID = Convert.ToInt32(cmbPozisyon.SelectedValue);
                        pr.DepartmanID = Convert.ToInt32(cmbDepartman.SelectedValue);
                        pr.DogumTarihi = dateTimePicker1.Value;
                        pr.Adres = txtAdress.Text;
                        if (resim2 != txtResim.Text)
                        {
                            pr.Resim = resimad;
                            if (File.Exists(resim2))
                                File.Delete(resim2);
                            File.Copy(txtResim.Text, @"resimler\\" + resimad);
                        }
                        else
                            pr.Resim = detay.Resim;
                        PersonelBLL.PersonelGuncelle(pr);
                        MessageBox.Show("Güncellendi");
                        this.Close();
                    }
                }
                else
                {
                    PERSONEL pr = new PERSONEL();
                    pr.UserNo = Convert.ToInt32(txtUserNo.Text);
                    pr.Ad = txtAd.Text;
                    pr.Soyad = txtSoyad.Text;
                    pr.Maas = Convert.ToInt32(txtMaas.Text);
                    pr.isAdmin = chbIsAdmin.Checked;
                    pr.Password = txtPassword.Text;
                    pr.PozisyonID = Convert.ToInt32(cmbPozisyon.SelectedValue);
                    pr.DepartmanID = Convert.ToInt32(cmbDepartman.SelectedValue);
                    pr.DogumGunu = dateTimePicker1.Value;
                    pr.Adres = txtAdress.Text;
                    pr.Resim = resimad;

                    PersonelBLL.PersonelEkle(pr);
                    File.Copy(txtResim.Text, @"resimler\\" + resimad);

                    txtUserNo.Clear();
                    txtAd.Clear();
                    txtSoyad.Clear();
                    txtMaas.Clear();
                    chbIsAdmin.Checked = false;
                    txtPassword.Clear();

                    cmbDepartman.SelectedIndex = -1;
                    cmbPozisyon.DataSource = dto.Pozisyonlar;
                    cmbPozisyon.SelectedIndex = -1;

                    dateTimePicker1.Value = DateTime.Today;
                    txtAdress.Clear();
                    resimad = "";

                    MessageBox.Show("Personel Eklendi");
                }
            }
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "")
                MessageBox.Show("User No Boş");
            else if (PersonelBLL.isUnique(Convert.ToInt32(txtUserNo.Text)))
            {
                MessageBox.Show("Lütfen User No Değiştirin Aynısını Kullanan Bir Personel Mevcut");
            }
            else
            {
                MessageBox.Show("Bu User No kullanılabilir");
            }
        }
    }
}
