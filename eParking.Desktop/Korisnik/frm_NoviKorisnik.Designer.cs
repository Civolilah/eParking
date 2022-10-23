
namespace eParking.Desktop.Korisnik
{
    partial class frm_NoviKorisnik
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
            this.txt_nazivkorisnika = new System.Windows.Forms.TextBox();
            this.cmb_uloge = new System.Windows.Forms.ComboBox();
            this.btn_snimi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_loznika = new System.Windows.Forms.TextBox();
            this.txt_potvrdaloznike = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_parking = new System.Windows.Forms.ComboBox();
            this.btn_novauloga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.Location = new System.Drawing.Point(131, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novi korisnik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lozinka:";
            // 
            // txt_nazivkorisnika
            // 
            this.txt_nazivkorisnika.Location = new System.Drawing.Point(42, 123);
            this.txt_nazivkorisnika.Name = "txt_nazivkorisnika";
            this.txt_nazivkorisnika.Size = new System.Drawing.Size(169, 22);
            this.txt_nazivkorisnika.TabIndex = 2;
            this.txt_nazivkorisnika.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nazivkorisnika_Validating);
            // 
            // cmb_uloge
            // 
            this.cmb_uloge.FormattingEnabled = true;
            this.cmb_uloge.Location = new System.Drawing.Point(42, 209);
            this.cmb_uloge.Name = "cmb_uloge";
            this.cmb_uloge.Size = new System.Drawing.Size(146, 24);
            this.cmb_uloge.TabIndex = 3;
            this.cmb_uloge.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_uloge_Validating);
            // 
            // btn_snimi
            // 
            this.btn_snimi.Location = new System.Drawing.Point(157, 526);
            this.btn_snimi.Name = "btn_snimi";
            this.btn_snimi.Size = new System.Drawing.Size(126, 42);
            this.btn_snimi.TabIndex = 4;
            this.btn_snimi.Text = "Snimi korisnika";
            this.btn_snimi.UseVisualStyleBackColor = true;
            this.btn_snimi.Click += new System.EventHandler(this.btn_snimi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uloga:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Korisnicko ime:";
            // 
            // txt_loznika
            // 
            this.txt_loznika.Location = new System.Drawing.Point(42, 392);
            this.txt_loznika.Name = "txt_loznika";
            this.txt_loznika.Size = new System.Drawing.Size(169, 22);
            this.txt_loznika.TabIndex = 7;
            this.txt_loznika.Validating += new System.ComponentModel.CancelEventHandler(this.txt_loznika_Validating);
            // 
            // txt_potvrdaloznike
            // 
            this.txt_potvrdaloznike.Location = new System.Drawing.Point(42, 480);
            this.txt_potvrdaloznike.Name = "txt_potvrdaloznike";
            this.txt_potvrdaloznike.Size = new System.Drawing.Size(169, 22);
            this.txt_potvrdaloznike.TabIndex = 8;
            this.txt_potvrdaloznike.Validating += new System.ComponentModel.CancelEventHandler(this.txt_potvrdaloznike_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Potvrda lozinke:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Parking:";
            // 
            // cmb_parking
            // 
            this.cmb_parking.FormattingEnabled = true;
            this.cmb_parking.Location = new System.Drawing.Point(43, 299);
            this.cmb_parking.Name = "cmb_parking";
            this.cmb_parking.Size = new System.Drawing.Size(146, 24);
            this.cmb_parking.TabIndex = 11;
            // 
            // btn_novauloga
            // 
            this.btn_novauloga.Location = new System.Drawing.Point(228, 204);
            this.btn_novauloga.Name = "btn_novauloga";
            this.btn_novauloga.Size = new System.Drawing.Size(96, 33);
            this.btn_novauloga.TabIndex = 12;
            this.btn_novauloga.Text = "Nova uloga";
            this.btn_novauloga.UseVisualStyleBackColor = true;
            this.btn_novauloga.Click += new System.EventHandler(this.btn_novauloga_Click);
            // 
            // frm_NoviKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 580);
            this.Controls.Add(this.btn_novauloga);
            this.Controls.Add(this.cmb_parking);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_potvrdaloznike);
            this.Controls.Add(this.txt_loznika);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_snimi);
            this.Controls.Add(this.cmb_uloge);
            this.Controls.Add(this.txt_nazivkorisnika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_NoviKorisnik";
            this.Text = "frm_NoviKorisnik";
            this.Load += new System.EventHandler(this.frm_NoviKorisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nazivkorisnika;
        private System.Windows.Forms.ComboBox cmb_uloge;
        private System.Windows.Forms.Button btn_snimi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_loznika;
        private System.Windows.Forms.TextBox txt_potvrdaloznike;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmb_parking;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_novauloga;
    }
}