
namespace eParking.Desktop.Parking
{
    partial class frm_urediparking
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nazivparkinga = new System.Windows.Forms.TextBox();
            this.num_satiod = new System.Windows.Forms.NumericUpDown();
            this.btn_snimi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_parkingmjesta = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.num_mindo = new System.Windows.Forms.NumericUpDown();
            this.num_satido = new System.Windows.Forms.NumericUpDown();
            this.num_minod = new System.Windows.Forms.NumericUpDown();
            this.cmb_aktivan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_gradovi = new System.Windows.Forms.ComboBox();
            this.btn_novigrad = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ParkingMjestoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivParkingMjesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipParkingMjesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obriši = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.num_satiod)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parkingmjesta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_mindo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_satido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_minod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.Location = new System.Drawing.Point(496, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uredi parking";
            // 
            // txt_nazivparkinga
            // 
            this.txt_nazivparkinga.Location = new System.Drawing.Point(65, 138);
            this.txt_nazivparkinga.Name = "txt_nazivparkinga";
            this.txt_nazivparkinga.Size = new System.Drawing.Size(149, 22);
            this.txt_nazivparkinga.TabIndex = 1;
            this.txt_nazivparkinga.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nazivparkinga_Validating);
            // 
            // num_satiod
            // 
            this.num_satiod.Location = new System.Drawing.Point(66, 271);
            this.num_satiod.Name = "num_satiod";
            this.num_satiod.Size = new System.Drawing.Size(48, 22);
            this.num_satiod.TabIndex = 2;
            this.num_satiod.Validating += new System.ComponentModel.CancelEventHandler(this.num_satiod_Validating);
            // 
            // btn_snimi
            // 
            this.btn_snimi.Location = new System.Drawing.Point(512, 747);
            this.btn_snimi.Name = "btn_snimi";
            this.btn_snimi.Size = new System.Drawing.Size(173, 42);
            this.btn_snimi.TabIndex = 3;
            this.btn_snimi.Text = "Snimi";
            this.btn_snimi.UseVisualStyleBackColor = true;
            this.btn_snimi.Click += new System.EventHandler(this.btn_snimi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naziv parkinga:";
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(611, 128);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(554, 316);
            this.map.TabIndex = 9;
            this.map.Zoom = 0D;
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            this.map.Validating += new System.ComponentModel.CancelEventHandler(this.map_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_parkingmjesta);
            this.groupBox1.Location = new System.Drawing.Point(45, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1122, 252);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parking mjesta:";
            // 
            // dgv_parkingmjesta
            // 
            this.dgv_parkingmjesta.AllowUserToAddRows = false;
            this.dgv_parkingmjesta.AllowUserToDeleteRows = false;
            this.dgv_parkingmjesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_parkingmjesta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParkingMjestoID,
            this.NazivParkingMjesta,
            this.TipParkingMjesta,
            this.Uredi,
            this.Obriši});
            this.dgv_parkingmjesta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_parkingmjesta.Location = new System.Drawing.Point(3, 18);
            this.dgv_parkingmjesta.Name = "dgv_parkingmjesta";
            this.dgv_parkingmjesta.ReadOnly = true;
            this.dgv_parkingmjesta.RowHeadersWidth = 51;
            this.dgv_parkingmjesta.RowTemplate.Height = 24;
            this.dgv_parkingmjesta.Size = new System.Drawing.Size(1116, 231);
            this.dgv_parkingmjesta.TabIndex = 0;
            this.dgv_parkingmjesta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_parkingmjesta_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Radno vrijeme:";
            // 
            // num_mindo
            // 
            this.num_mindo.Location = new System.Drawing.Point(425, 271);
            this.num_mindo.Name = "num_mindo";
            this.num_mindo.Size = new System.Drawing.Size(48, 22);
            this.num_mindo.TabIndex = 12;
            this.num_mindo.Validating += new System.ComponentModel.CancelEventHandler(this.num_mindo_Validating);
            // 
            // num_satido
            // 
            this.num_satido.Location = new System.Drawing.Point(325, 271);
            this.num_satido.Name = "num_satido";
            this.num_satido.Size = new System.Drawing.Size(48, 22);
            this.num_satido.TabIndex = 13;
            this.num_satido.Validating += new System.ComponentModel.CancelEventHandler(this.num_satido_Validating);
            // 
            // num_minod
            // 
            this.num_minod.Location = new System.Drawing.Point(166, 271);
            this.num_minod.Name = "num_minod";
            this.num_minod.Size = new System.Drawing.Size(48, 22);
            this.num_minod.TabIndex = 14;
            this.num_minod.Validating += new System.ComponentModel.CancelEventHandler(this.num_minod_Validating);
            // 
            // cmb_aktivan
            // 
            this.cmb_aktivan.FormattingEnabled = true;
            this.cmb_aktivan.Location = new System.Drawing.Point(65, 377);
            this.cmb_aktivan.Name = "cmb_aktivan";
            this.cmb_aktivan.Size = new System.Drawing.Size(121, 24);
            this.cmb_aktivan.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Lokacija parkinga:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "(sati)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "(minute)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "(sati)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "(minute)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Od:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(388, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Do:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(62, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Aktivan:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(301, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Grad:";
            // 
            // cmb_gradovi
            // 
            this.cmb_gradovi.FormattingEnabled = true;
            this.cmb_gradovi.Location = new System.Drawing.Point(304, 377);
            this.cmb_gradovi.Name = "cmb_gradovi";
            this.cmb_gradovi.Size = new System.Drawing.Size(121, 24);
            this.cmb_gradovi.TabIndex = 26;
            // 
            // btn_novigrad
            // 
            this.btn_novigrad.Location = new System.Drawing.Point(453, 375);
            this.btn_novigrad.Name = "btn_novigrad";
            this.btn_novigrad.Size = new System.Drawing.Size(95, 27);
            this.btn_novigrad.TabIndex = 27;
            this.btn_novigrad.Text = "Novi grad";
            this.btn_novigrad.UseVisualStyleBackColor = true;
            this.btn_novigrad.Click += new System.EventHandler(this.btn_novigrad_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ParkingMjestoID
            // 
            this.ParkingMjestoID.DataPropertyName = "ParkingMjestoID";
            this.ParkingMjestoID.HeaderText = "ParkingMjestoID";
            this.ParkingMjestoID.MinimumWidth = 6;
            this.ParkingMjestoID.Name = "ParkingMjestoID";
            this.ParkingMjestoID.ReadOnly = true;
            this.ParkingMjestoID.Visible = false;
            this.ParkingMjestoID.Width = 125;
            // 
            // NazivParkingMjesta
            // 
            this.NazivParkingMjesta.DataPropertyName = "NazivParkingMjesta";
            this.NazivParkingMjesta.HeaderText = "Naziv";
            this.NazivParkingMjesta.MinimumWidth = 6;
            this.NazivParkingMjesta.Name = "NazivParkingMjesta";
            this.NazivParkingMjesta.ReadOnly = true;
            this.NazivParkingMjesta.Width = 125;
            // 
            // TipParkingMjesta
            // 
            this.TipParkingMjesta.DataPropertyName = "NazivTipaParkingMjesta";
            this.TipParkingMjesta.HeaderText = "Tip";
            this.TipParkingMjesta.MinimumWidth = 6;
            this.TipParkingMjesta.Name = "TipParkingMjesta";
            this.TipParkingMjesta.ReadOnly = true;
            this.TipParkingMjesta.Width = 125;
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
            // Obriši
            // 
            this.Obriši.HeaderText = "Obriši";
            this.Obriši.MinimumWidth = 6;
            this.Obriši.Name = "Obriši";
            this.Obriši.ReadOnly = true;
            this.Obriši.Text = "Obriši";
            this.Obriši.UseColumnTextForButtonValue = true;
            this.Obriši.Width = 125;
            // 
            // frm_urediparking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 801);
            this.Controls.Add(this.btn_novigrad);
            this.Controls.Add(this.cmb_gradovi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_aktivan);
            this.Controls.Add(this.num_minod);
            this.Controls.Add(this.num_satido);
            this.Controls.Add(this.num_mindo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_snimi);
            this.Controls.Add(this.num_satiod);
            this.Controls.Add(this.txt_nazivparkinga);
            this.Controls.Add(this.label1);
            this.Name = "frm_urediparking";
            this.Text = "frm_urediparking";
            this.Load += new System.EventHandler(this.frm_urediparking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_satiod)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parkingmjesta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_mindo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_satido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_minod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nazivparkinga;
        private System.Windows.Forms.NumericUpDown num_satiod;
        private System.Windows.Forms.Button btn_snimi;
        private System.Windows.Forms.Label label2;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_parkingmjesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_mindo;
        private System.Windows.Forms.NumericUpDown num_satido;
        private System.Windows.Forms.NumericUpDown num_minod;
        private System.Windows.Forms.ComboBox cmb_aktivan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_gradovi;
        private System.Windows.Forms.Button btn_novigrad;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParkingMjestoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivParkingMjesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipParkingMjesta;
        private System.Windows.Forms.DataGridViewButtonColumn Uredi;
        private System.Windows.Forms.DataGridViewButtonColumn Obriši;
    }
}