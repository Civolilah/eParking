
namespace eParking.Desktop.Parking
{
    partial class frm_urediparkingmjesto
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
            this.cmb_tipoviparkingmjesta = new System.Windows.Forms.ComboBox();
            this.btn_snimi = new System.Windows.Forms.Button();
            this.txt_naziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_novitip = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.Location = new System.Drawing.Point(126, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uredi parking mjesto";
            // 
            // cmb_tipoviparkingmjesta
            // 
            this.cmb_tipoviparkingmjesta.FormattingEnabled = true;
            this.cmb_tipoviparkingmjesta.Location = new System.Drawing.Point(46, 217);
            this.cmb_tipoviparkingmjesta.Name = "cmb_tipoviparkingmjesta";
            this.cmb_tipoviparkingmjesta.Size = new System.Drawing.Size(139, 24);
            this.cmb_tipoviparkingmjesta.TabIndex = 1;
            // 
            // btn_snimi
            // 
            this.btn_snimi.Location = new System.Drawing.Point(211, 308);
            this.btn_snimi.Name = "btn_snimi";
            this.btn_snimi.Size = new System.Drawing.Size(94, 34);
            this.btn_snimi.TabIndex = 2;
            this.btn_snimi.Text = "Snimi";
            this.btn_snimi.UseVisualStyleBackColor = true;
            this.btn_snimi.Click += new System.EventHandler(this.btn_snimi_Click);
            // 
            // txt_naziv
            // 
            this.txt_naziv.Location = new System.Drawing.Point(46, 134);
            this.txt_naziv.Name = "txt_naziv";
            this.txt_naziv.Size = new System.Drawing.Size(139, 22);
            this.txt_naziv.TabIndex = 3;
            this.txt_naziv.Validating += new System.ComponentModel.CancelEventHandler(this.txt_naziv_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Naziv:";
            // 
            // btn_novitip
            // 
            this.btn_novitip.Location = new System.Drawing.Point(211, 213);
            this.btn_novitip.Name = "btn_novitip";
            this.btn_novitip.Size = new System.Drawing.Size(94, 30);
            this.btn_novitip.TabIndex = 6;
            this.btn_novitip.Text = "Novi tip";
            this.btn_novitip.UseVisualStyleBackColor = true;
            this.btn_novitip.Click += new System.EventHandler(this.btn_novitip_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_urediparkingmjesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 365);
            this.Controls.Add(this.btn_novitip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_naziv);
            this.Controls.Add(this.btn_snimi);
            this.Controls.Add(this.cmb_tipoviparkingmjesta);
            this.Controls.Add(this.label1);
            this.Name = "frm_urediparkingmjesto";
            this.Text = "frm_urediparkingmjesto";
            this.Load += new System.EventHandler(this.frm_urediparkingmjesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_tipoviparkingmjesta;
        private System.Windows.Forms.Button btn_snimi;
        private System.Windows.Forms.TextBox txt_naziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_novitip;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}