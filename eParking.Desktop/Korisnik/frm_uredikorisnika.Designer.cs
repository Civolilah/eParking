
namespace eParking.Desktop.Korisnik
{
    partial class frm_uredikorisnika
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
            this.btn_snimi = new System.Windows.Forms.Button();
            this.txt_korisnickoime = new System.Windows.Forms.TextBox();
            this.cmb_uloga = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_parking = new System.Windows.Forms.ComboBox();
            this.txt_potvrdanovi = new System.Windows.Forms.TextBox();
            this.txt_staripassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_novipassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_novauloga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(118, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uredi korisnika";
            // 
            // btn_snimi
            // 
            this.btn_snimi.Location = new System.Drawing.Point(171, 575);
            this.btn_snimi.Name = "btn_snimi";
            this.btn_snimi.Size = new System.Drawing.Size(106, 38);
            this.btn_snimi.TabIndex = 1;
            this.btn_snimi.Text = "Snimi";
            this.btn_snimi.UseVisualStyleBackColor = true;
            this.btn_snimi.Click += new System.EventHandler(this.btn_snimi_Click);
            // 
            // txt_korisnickoime
            // 
            this.txt_korisnickoime.Location = new System.Drawing.Point(60, 120);
            this.txt_korisnickoime.Name = "txt_korisnickoime";
            this.txt_korisnickoime.Size = new System.Drawing.Size(136, 22);
            this.txt_korisnickoime.TabIndex = 2;
            this.txt_korisnickoime.Validating += new System.ComponentModel.CancelEventHandler(this.txt_korisnickoime_Validating);
            // 
            // cmb_uloga
            // 
            this.cmb_uloga.FormattingEnabled = true;
            this.cmb_uloga.Location = new System.Drawing.Point(60, 191);
            this.cmb_uloga.Name = "cmb_uloga";
            this.cmb_uloga.Size = new System.Drawing.Size(136, 24);
            this.cmb_uloga.TabIndex = 3;
            this.cmb_uloga.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_uloga_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Korisničko ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uloga:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parking:";
            // 
            // cmb_parking
            // 
            this.cmb_parking.FormattingEnabled = true;
            this.cmb_parking.Location = new System.Drawing.Point(60, 269);
            this.cmb_parking.Name = "cmb_parking";
            this.cmb_parking.Size = new System.Drawing.Size(136, 24);
            this.cmb_parking.TabIndex = 6;
            // 
            // txt_potvrdanovi
            // 
            this.txt_potvrdanovi.Location = new System.Drawing.Point(60, 520);
            this.txt_potvrdanovi.Name = "txt_potvrdanovi";
            this.txt_potvrdanovi.Size = new System.Drawing.Size(137, 22);
            this.txt_potvrdanovi.TabIndex = 8;
            this.txt_potvrdanovi.Validating += new System.ComponentModel.CancelEventHandler(this.txt_potvrdanovi_Validating);
            // 
            // txt_staripassword
            // 
            this.txt_staripassword.Location = new System.Drawing.Point(60, 352);
            this.txt_staripassword.Name = "txt_staripassword";
            this.txt_staripassword.PasswordChar = '*';
            this.txt_staripassword.Size = new System.Drawing.Size(136, 22);
            this.txt_staripassword.TabIndex = 9;
            this.txt_staripassword.Validating += new System.ComponentModel.CancelEventHandler(this.txt_staripassword_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stari password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Novi password:";
            // 
            // txt_novipassword
            // 
            this.txt_novipassword.Location = new System.Drawing.Point(60, 435);
            this.txt_novipassword.Name = "txt_novipassword";
            this.txt_novipassword.Size = new System.Drawing.Size(136, 22);
            this.txt_novipassword.TabIndex = 11;
            this.txt_novipassword.Validating += new System.ComponentModel.CancelEventHandler(this.txt_novipassword_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Potvrda novog passworda:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_novauloga
            // 
            this.btn_novauloga.Location = new System.Drawing.Point(217, 188);
            this.btn_novauloga.Name = "btn_novauloga";
            this.btn_novauloga.Size = new System.Drawing.Size(106, 29);
            this.btn_novauloga.TabIndex = 14;
            this.btn_novauloga.Text = "Nova uloga";
            this.btn_novauloga.UseVisualStyleBackColor = true;
            this.btn_novauloga.Click += new System.EventHandler(this.btn_novauloga_Click);
            // 
            // frm_uredikorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 625);
            this.Controls.Add(this.btn_novauloga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_novipassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_staripassword);
            this.Controls.Add(this.txt_potvrdanovi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_parking);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_uloga);
            this.Controls.Add(this.txt_korisnickoime);
            this.Controls.Add(this.btn_snimi);
            this.Controls.Add(this.label1);
            this.Name = "frm_uredikorisnika";
            this.Text = "frm_uredikorisnika";
            this.Load += new System.EventHandler(this.frm_uredikorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_snimi;
        private System.Windows.Forms.TextBox txt_korisnickoime;
        private System.Windows.Forms.ComboBox cmb_uloga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_parking;
        private System.Windows.Forms.TextBox txt_potvrdanovi;
        private System.Windows.Forms.TextBox txt_staripassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_novipassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_novauloga;
    }
}