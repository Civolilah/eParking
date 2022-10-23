
namespace eParking.Desktop
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.parkinziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviParkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_parkinzi = new System.Windows.Forms.DataGridView();
            this.ParkingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivParkinga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadnoVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojParkingMijesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NovoMjesto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_osvjezi = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parkinzi)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parkinziToolStripMenuItem,
            this.korisniciToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // parkinziToolStripMenuItem
            // 
            this.parkinziToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviParkingToolStripMenuItem});
            this.parkinziToolStripMenuItem.Name = "parkinziToolStripMenuItem";
            this.parkinziToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.parkinziToolStripMenuItem.Text = "Parkinzi";
            // 
            // noviParkingToolStripMenuItem
            // 
            this.noviParkingToolStripMenuItem.Name = "noviParkingToolStripMenuItem";
            this.noviParkingToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.noviParkingToolStripMenuItem.Text = "Novi parking";
            this.noviParkingToolStripMenuItem.Click += new System.EventHandler(this.noviParkingToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem1,
            this.noviKorisnikToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // pregledToolStripMenuItem1
            // 
            this.pregledToolStripMenuItem1.Name = "pregledToolStripMenuItem1";
            this.pregledToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.pregledToolStripMenuItem1.Text = "Pregled";
            this.pregledToolStripMenuItem1.Click += new System.EventHandler(this.pregledToolStripMenuItem1_Click);
            // 
            // noviKorisnikToolStripMenuItem
            // 
            this.noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            this.noviKorisnikToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.noviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            this.noviKorisnikToolStripMenuItem.Click += new System.EventHandler(this.noviKorisnikToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(317, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parking lista";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.dgv_parkinzi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 382);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parkinzi:";
            // 
            // dgv_parkinzi
            // 
            this.dgv_parkinzi.AllowUserToAddRows = false;
            this.dgv_parkinzi.AllowUserToDeleteRows = false;
            this.dgv_parkinzi.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_parkinzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_parkinzi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParkingID,
            this.NazivParkinga,
            this.Grad,
            this.RadnoVrijeme,
            this.BrojParkingMijesta,
            this.Aktivan,
            this.Uredi,
            this.NovoMjesto,
            this.Obrisi});
            this.dgv_parkinzi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_parkinzi.Location = new System.Drawing.Point(3, 30);
            this.dgv_parkinzi.Name = "dgv_parkinzi";
            this.dgv_parkinzi.ReadOnly = true;
            this.dgv_parkinzi.RowHeadersWidth = 51;
            this.dgv_parkinzi.RowTemplate.Height = 24;
            this.dgv_parkinzi.Size = new System.Drawing.Size(813, 349);
            this.dgv_parkinzi.TabIndex = 0;
            this.dgv_parkinzi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_parkinzi_CellContentClick);
            // 
            // ParkingID
            // 
            this.ParkingID.DataPropertyName = "ParkingID";
            this.ParkingID.HeaderText = "ParkingID";
            this.ParkingID.MinimumWidth = 6;
            this.ParkingID.Name = "ParkingID";
            this.ParkingID.ReadOnly = true;
            this.ParkingID.Visible = false;
            this.ParkingID.Width = 125;
            // 
            // NazivParkinga
            // 
            this.NazivParkinga.DataPropertyName = "NazivParkinga";
            this.NazivParkinga.HeaderText = "Naziv parkinga";
            this.NazivParkinga.MinimumWidth = 6;
            this.NazivParkinga.Name = "NazivParkinga";
            this.NazivParkinga.ReadOnly = true;
            this.NazivParkinga.Width = 205;
            // 
            // Grad
            // 
            this.Grad.DataPropertyName = "Grad";
            this.Grad.HeaderText = "Grad";
            this.Grad.MinimumWidth = 6;
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            this.Grad.Width = 125;
            // 
            // RadnoVrijeme
            // 
            this.RadnoVrijeme.DataPropertyName = "RadnoVrijeme";
            this.RadnoVrijeme.HeaderText = "Radno vrijeme";
            this.RadnoVrijeme.MinimumWidth = 6;
            this.RadnoVrijeme.Name = "RadnoVrijeme";
            this.RadnoVrijeme.ReadOnly = true;
            this.RadnoVrijeme.Width = 200;
            // 
            // BrojParkingMijesta
            // 
            this.BrojParkingMijesta.DataPropertyName = "BrojParkingMijesta";
            this.BrojParkingMijesta.HeaderText = "Broj parking mijesta";
            this.BrojParkingMijesta.MinimumWidth = 6;
            this.BrojParkingMijesta.Name = "BrojParkingMijesta";
            this.BrojParkingMijesta.ReadOnly = true;
            this.BrojParkingMijesta.Width = 270;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.MinimumWidth = 6;
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            this.Aktivan.Width = 125;
            // 
            // Uredi
            // 
            this.Uredi.HeaderText = "Uredi";
            this.Uredi.MinimumWidth = 6;
            this.Uredi.Name = "Uredi";
            this.Uredi.ReadOnly = true;
            this.Uredi.Text = "Uredi";
            this.Uredi.UseColumnTextForButtonValue = true;
            this.Uredi.Width = 125;
            // 
            // NovoMjesto
            // 
            this.NovoMjesto.HeaderText = "Dodaj parking mjesto";
            this.NovoMjesto.MinimumWidth = 6;
            this.NovoMjesto.Name = "NovoMjesto";
            this.NovoMjesto.ReadOnly = true;
            this.NovoMjesto.Text = "Dodaj mjesto";
            this.NovoMjesto.UseColumnTextForButtonValue = true;
            this.NovoMjesto.Width = 270;
            // 
            // Obrisi
            // 
            this.Obrisi.HeaderText = "Obriši";
            this.Obrisi.MinimumWidth = 6;
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.ReadOnly = true;
            this.Obrisi.Text = "Obriši";
            this.Obrisi.UseColumnTextForButtonValue = true;
            this.Obrisi.Width = 125;
            // 
            // btn_osvjezi
            // 
            this.btn_osvjezi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_osvjezi.Location = new System.Drawing.Point(661, 116);
            this.btn_osvjezi.Name = "btn_osvjezi";
            this.btn_osvjezi.Size = new System.Drawing.Size(170, 42);
            this.btn_osvjezi.TabIndex = 5;
            this.btn_osvjezi.Text = "Osvjezi rezultate";
            this.btn_osvjezi.UseVisualStyleBackColor = true;
            this.btn_osvjezi.Click += new System.EventHandler(this.btn_osvjezi_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.btn_osvjezi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parkinzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem parkinziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviParkingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem noviKorisnikToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_parkinzi;
        private System.Windows.Forms.Button btn_osvjezi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParkingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivParkinga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadnoVrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojParkingMijesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aktivan;
        private System.Windows.Forms.DataGridViewButtonColumn Uredi;
        private System.Windows.Forms.DataGridViewButtonColumn NovoMjesto;
        private System.Windows.Forms.DataGridViewButtonColumn Obrisi;
    }
}



