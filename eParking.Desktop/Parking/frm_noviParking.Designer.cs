
namespace eParking.Desktop.Parking
{
    partial class frm_noviParking
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nazivparkinga = new System.Windows.Forms.TextBox();
            this.cmb_gradovi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_snimiparking = new System.Windows.Forms.Button();
            this.btn_novigrad = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.num_satiod = new System.Windows.Forms.NumericUpDown();
            this.num_minod = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.num_mindo = new System.Windows.Forms.NumericUpDown();
            this.num_satido = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_aktivan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_satiod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_minod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_mindo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_satido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(249, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novi parking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lokacija parkinga:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Naziv parkinga:";
            // 
            // txt_nazivparkinga
            // 
            this.txt_nazivparkinga.Location = new System.Drawing.Point(59, 110);
            this.txt_nazivparkinga.Name = "txt_nazivparkinga";
            this.txt_nazivparkinga.Size = new System.Drawing.Size(169, 22);
            this.txt_nazivparkinga.TabIndex = 3;
            this.txt_nazivparkinga.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nazivparkinga_Validating);
            // 
            // cmb_gradovi
            // 
            this.cmb_gradovi.FormattingEnabled = true;
            this.cmb_gradovi.Location = new System.Drawing.Point(59, 308);
            this.cmb_gradovi.Name = "cmb_gradovi";
            this.cmb_gradovi.Size = new System.Drawing.Size(169, 24);
            this.cmb_gradovi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Grad:";
            // 
            // btn_snimiparking
            // 
            this.btn_snimiparking.Location = new System.Drawing.Point(267, 798);
            this.btn_snimiparking.Name = "btn_snimiparking";
            this.btn_snimiparking.Size = new System.Drawing.Size(133, 40);
            this.btn_snimiparking.TabIndex = 6;
            this.btn_snimiparking.Text = "Snimi";
            this.btn_snimiparking.UseVisualStyleBackColor = true;
            this.btn_snimiparking.Click += new System.EventHandler(this.btn_snimiparking_Click);
            // 
            // btn_novigrad
            // 
            this.btn_novigrad.Location = new System.Drawing.Point(280, 301);
            this.btn_novigrad.Name = "btn_novigrad";
            this.btn_novigrad.Size = new System.Drawing.Size(133, 37);
            this.btn_novigrad.TabIndex = 7;
            this.btn_novigrad.Text = "Novi grad";
            this.btn_novigrad.UseVisualStyleBackColor = true;
            this.btn_novigrad.Click += new System.EventHandler(this.btn_novigrad_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(6, 471);
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
            this.map.Size = new System.Drawing.Size(630, 310);
            this.map.TabIndex = 8;
            this.map.Zoom = 0D;
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            this.map.Validating += new System.ComponentModel.CancelEventHandler(this.map_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Radno vrijeme:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Od:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Do:";
            // 
            // num_satiod
            // 
            this.num_satiod.Location = new System.Drawing.Point(59, 211);
            this.num_satiod.Name = "num_satiod";
            this.num_satiod.Size = new System.Drawing.Size(66, 22);
            this.num_satiod.TabIndex = 12;
            this.num_satiod.Validating += new System.ComponentModel.CancelEventHandler(this.num_satiod_Validating);
            // 
            // num_minod
            // 
            this.num_minod.Location = new System.Drawing.Point(174, 211);
            this.num_minod.Name = "num_minod";
            this.num_minod.Size = new System.Drawing.Size(66, 22);
            this.num_minod.TabIndex = 13;
            this.num_minod.Validating += new System.ComponentModel.CancelEventHandler(this.num_minod_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "(sati)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "(minute)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(521, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "(minute)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(403, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "(sati)";
            // 
            // num_mindo
            // 
            this.num_mindo.Location = new System.Drawing.Point(449, 213);
            this.num_mindo.Name = "num_mindo";
            this.num_mindo.Size = new System.Drawing.Size(66, 22);
            this.num_mindo.TabIndex = 17;
            this.num_mindo.Validating += new System.ComponentModel.CancelEventHandler(this.num_mindo_Validating);
            // 
            // num_satido
            // 
            this.num_satido.Location = new System.Drawing.Point(334, 213);
            this.num_satido.Name = "num_satido";
            this.num_satido.Size = new System.Drawing.Size(66, 22);
            this.num_satido.TabIndex = 16;
            this.num_satido.Validating += new System.ComponentModel.CancelEventHandler(this.num_satido_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 358);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Aktivan:";
            // 
            // cmb_aktivan
            // 
            this.cmb_aktivan.FormattingEnabled = true;
            this.cmb_aktivan.Location = new System.Drawing.Point(59, 387);
            this.cmb_aktivan.Name = "cmb_aktivan";
            this.cmb_aktivan.Size = new System.Drawing.Size(169, 24);
            this.cmb_aktivan.TabIndex = 21;
            // 
            // frm_noviParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 846);
            this.Controls.Add(this.cmb_aktivan);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.num_mindo);
            this.Controls.Add(this.num_satido);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.num_minod);
            this.Controls.Add(this.num_satiod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.map);
            this.Controls.Add(this.btn_novigrad);
            this.Controls.Add(this.btn_snimiparking);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_gradovi);
            this.Controls.Add(this.txt_nazivparkinga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_noviParking";
            this.Text = "frm_noviParking";
            this.Load += new System.EventHandler(this.frm_noviParking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_satiod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_minod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_mindo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_satido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nazivparkinga;
        private System.Windows.Forms.ComboBox cmb_gradovi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_snimiparking;
        private System.Windows.Forms.Button btn_novigrad;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown num_minod;
        private System.Windows.Forms.NumericUpDown num_satiod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown num_mindo;
        private System.Windows.Forms.NumericUpDown num_satido;
        private System.Windows.Forms.ComboBox cmb_aktivan;
        private System.Windows.Forms.Label label12;
    }
}