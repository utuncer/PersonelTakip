using BLL;
using DAL;
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
    public partial class FrmDepartmanListesi : Form
    {
        public FrmDepartmanListesi()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            // Bu şekilde uygulamdadn çıkmadan bi önceki sayfaya dönebiliriz
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmDepartmanBilgileri frm = new FrmDepartmanBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            liste = DepartmanBLL.DepartmanGetir();
            dataGridView1.DataSource = liste; //Eklendikten sonra listenin tekrar sıralanmasını sağlar
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            FrmDepartmanBilgileri frm = new FrmDepartmanBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
            List<DEPARTMAN> liste = new List<DEPARTMAN>();
        private void FrmDepartmanListesi_Load(object sender, EventArgs e)
        {

            liste = DepartmanBLL.DepartmanGetir();
            dataGridView1.DataSource= liste;

            // dataGridView1.Columns[0].HeaderText = "Departman ID"; // ID kısmı genellikle kullanıcıya gösterilmez
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Departman Adı";
        }
    }
}
