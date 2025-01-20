namespace PersonelTakip
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPozisyon = new System.Windows.Forms.Button();
            this.btnDepartman = new System.Windows.Forms.Button();
            this.btnIzin = new System.Windows.Forms.Button();
            this.btnMaas = new System.Windows.Forms.Button();
            this.btnIs = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPozisyon
            // 
            this.btnPozisyon.BackColor = System.Drawing.Color.Purple;
            this.btnPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPozisyon.Image = global::PersonelTakip.Properties.Resources.medal1;
            this.btnPozisyon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPozisyon.Location = new System.Drawing.Point(480, 135);
            this.btnPozisyon.Name = "btnPozisyon";
            this.btnPozisyon.Size = new System.Drawing.Size(146, 112);
            this.btnPozisyon.TabIndex = 5;
            this.btnPozisyon.Text = "Pozisyon İşlemleri";
            this.btnPozisyon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPozisyon.UseVisualStyleBackColor = false;
            this.btnPozisyon.Click += new System.EventHandler(this.btnPozisyon_Click);
            // 
            // btnDepartman
            // 
            this.btnDepartman.BackColor = System.Drawing.Color.Violet;
            this.btnDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartman.Image = global::PersonelTakip.Properties.Resources.workspace1;
            this.btnDepartman.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDepartman.Location = new System.Drawing.Point(311, 135);
            this.btnDepartman.Name = "btnDepartman";
            this.btnDepartman.Size = new System.Drawing.Size(146, 112);
            this.btnDepartman.TabIndex = 4;
            this.btnDepartman.Text = "Departman İşlemleri";
            this.btnDepartman.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartman.UseVisualStyleBackColor = false;
            this.btnDepartman.Click += new System.EventHandler(this.btnDepartman_Click);
            // 
            // btnIzin
            // 
            this.btnIzin.BackColor = System.Drawing.Color.Honeydew;
            this.btnIzin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzin.Image = global::PersonelTakip.Properties.Resources.traveler_with_a_suitcase1;
            this.btnIzin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIzin.Location = new System.Drawing.Point(142, 135);
            this.btnIzin.Name = "btnIzin";
            this.btnIzin.Size = new System.Drawing.Size(146, 112);
            this.btnIzin.TabIndex = 3;
            this.btnIzin.Text = "İzin İşlemleri";
            this.btnIzin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIzin.UseVisualStyleBackColor = false;
            this.btnIzin.Click += new System.EventHandler(this.btnIzin_Click);
            // 
            // btnMaas
            // 
            this.btnMaas.BackColor = System.Drawing.Color.SpringGreen;
            this.btnMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaas.Image = global::PersonelTakip.Properties.Resources.give_money;
            this.btnMaas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaas.Location = new System.Drawing.Point(480, 12);
            this.btnMaas.Name = "btnMaas";
            this.btnMaas.Size = new System.Drawing.Size(146, 112);
            this.btnMaas.TabIndex = 2;
            this.btnMaas.Text = "Maaş";
            this.btnMaas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaas.UseVisualStyleBackColor = false;
            this.btnMaas.Click += new System.EventHandler(this.btnMaas_Click);
            // 
            // btnIs
            // 
            this.btnIs.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIs.Image = global::PersonelTakip.Properties.Resources.workspace1;
            this.btnIs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIs.Location = new System.Drawing.Point(311, 12);
            this.btnIs.Name = "btnIs";
            this.btnIs.Size = new System.Drawing.Size(146, 112);
            this.btnIs.TabIndex = 1;
            this.btnIs.Text = "İşler";
            this.btnIs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIs.UseVisualStyleBackColor = false;
            this.btnIs.Click += new System.EventHandler(this.btnIs_Click);
            // 
            // btnPersonel
            // 
            this.btnPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel.Image = global::PersonelTakip.Properties.Resources.management;
            this.btnPersonel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPersonel.Location = new System.Drawing.Point(142, 12);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(146, 112);
            this.btnPersonel.TabIndex = 0;
            this.btnPersonel.Text = "Personel İşlemleri";
            this.btnPersonel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonel.UseVisualStyleBackColor = false;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Gold;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.Image = global::PersonelTakip.Properties.Resources.logout;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogOut.Location = new System.Drawing.Point(224, 258);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(146, 112);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Image = global::PersonelTakip.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(402, 258);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(146, 112);
            this.btnExit.TabIndex = 7;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnPozisyon);
            this.Controls.Add(this.btnDepartman);
            this.Controls.Add(this.btnIzin);
            this.Controls.Add(this.btnMaas);
            this.Controls.Add(this.btnIs);
            this.Controls.Add(this.btnPersonel);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Takip";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnIs;
        private System.Windows.Forms.Button btnMaas;
        private System.Windows.Forms.Button btnIzin;
        private System.Windows.Forms.Button btnDepartman;
        private System.Windows.Forms.Button btnPozisyon;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnExit;
    }
}