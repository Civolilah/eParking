
namespace eParking.Desktop.Korisnik
{
    partial class frm_pregledkorisnika
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_osvjezi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_korisnici = new System.Windows.Forms.DataGridView();
            this.KorisnikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisničkoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obriši = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_korisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(297, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregled korisnika";
            // 
            // btn_osvjezi
            // 
            this.btn_osvjezi.Location = new System.Drawing.Point(702, 124);
            this.btn_osvjezi.Name = "btn_osvjezi";
            this.btn_osvjezi.Size = new System.Drawing.Size(104, 30);
            this.btn_osvjezi.TabIndex = 1;
            this.btn_osvjezi.Text = "Osvježi";
            this.btn_osvjezi.UseVisualStyleBackColor = true;
            this.btn_osvjezi.Click += new System.EventHandler(this.btn_osvjezi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_korisnici);
            this.groupBox1.Location = new System.Drawing.Point(30, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 262);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korisnici";
            // 
            // dgv_korisnici
            // 
            this.dgv_korisnici.AllowUserToAddRows = false;
            this.dgv_korisnici.AllowUserToDeleteRows = false;
            this.dgv_korisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_korisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KorisnikID,
            this.KorisničkoIme,
            this.Uloga,
            this.Uredi,
            this.Obriši});
            this.dgv_korisnici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_korisnici.Location = new System.Drawing.Point(3, 18);
            this.dgv_korisnici.Name = "dgv_korisnici";
            this.dgv_korisnici.ReadOnly = true;
            this.dgv_korisnici.RowHeadersWidth = 51;
            this.dgv_korisnici.RowTemplate.Height = 24;
            this.dgv_korisnici.Size = new System.Drawing.Size(770, 241);
            this.dgv_korisnici.TabIndex = 0;
            this.dgv_korisnici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_korisnici_CellContentClick);
            // 
            // KorisnikID
            // 
            this.KorisnikID.DataPropertyName = "KorisnikID";
            this.KorisnikID.HeaderText = "KorisnikID";
            this.KorisnikID.MinimumWidth = 6;
            this.KorisnikID.Name = "KorisnikID";
            this.KorisnikID.ReadOnly = true;
            this.KorisnikID.Visible = false;
            this.KorisnikID.Width = 125;
            // 
            // KorisničkoIme
            // 
            this.KorisničkoIme.DataPropertyName = "NazivKorisnika";
            this.KorisničkoIme.HeaderText = "Korisničko ime";
            this.KorisničkoIme.MinimumWidth = 6;
            this.KorisničkoIme.Name = "KorisničkoIme";
            this.KorisničkoIme.ReadOnly = true;
            this.KorisničkoIme.Width = 150;
            // 
            // Uloga
            // 
            this.Uloga.DataPropertyName = "Uloga";
            this.Uloga.HeaderText = "Uloga";
            this.Uloga.MinimumWidth = 6;
            this.Uloga.Name = "Uloga";
            this.Uloga.ReadOnly = true;
            this.Uloga.Width = 125;
            // 
            // Uredi
            // 
            this.Uredi.HeaderText = "Uredi";
            this.Uredi.MinimumWidth = 6;
            this.Uredi.Name = "Uredi";
            this.Uredi.ReadOnly = true;
            this.Uredi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Uredi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Uredi.Text = "Uredi";
            this.Uredi.UseColumnTextForButtonValue = true;
            this.Uredi.Width = 125;
            // 
            // Obriši
            // 
            this.Obriši.HeaderText = "Obriši";
            this.Obriši.MinimumWidth = 6;
            this.Obriši.Name = "Obriši";
            this.Obriši.ReadOnly = true;
            this.Obriši.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Obriši.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Obriši.Text = "Obriši";
            this.Obriši.UseColumnTextForButtonValue = true;
            this.Obriši.Width = 125;
            // 
            // frm_pregledkorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_osvjezi);
            this.Controls.Add(this.label1);
            this.Name = "frm_pregledkorisnika";
            this.Text = "frm_pregledkorisnika";
            this.Load += new System.EventHandler(this.frm_pregledkorisnika_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_korisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_osvjezi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_korisnici;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisničkoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uloga;
        private System.Windows.Forms.DataGridViewButtonColumn Uredi;
        private System.Windows.Forms.DataGridViewButtonColumn Obriši;
    }
}