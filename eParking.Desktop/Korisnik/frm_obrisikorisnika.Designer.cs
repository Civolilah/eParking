
namespace eParking.Desktop.Korisnik
{
    partial class frm_obrisikorisnika
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
            this.btn_da = new System.Windows.Forms.Button();
            this.txt_korisnickoime = new System.Windows.Forms.TextBox();
            this.btn_ne = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(220, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brisanje korisnika";
            // 
            // btn_da
            // 
            this.btn_da.Location = new System.Drawing.Point(201, 281);
            this.btn_da.Name = "btn_da";
            this.btn_da.Size = new System.Drawing.Size(87, 34);
            this.btn_da.TabIndex = 1;
            this.btn_da.Text = "Da!";
            this.btn_da.UseVisualStyleBackColor = true;
            this.btn_da.Click += new System.EventHandler(this.btn_da_Click);
            // 
            // txt_korisnickoime
            // 
            this.txt_korisnickoime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_korisnickoime.Location = new System.Drawing.Point(363, 159);
            this.txt_korisnickoime.Name = "txt_korisnickoime";
            this.txt_korisnickoime.ReadOnly = true;
            this.txt_korisnickoime.Size = new System.Drawing.Size(180, 30);
            this.txt_korisnickoime.TabIndex = 2;
            // 
            // btn_ne
            // 
            this.btn_ne.Location = new System.Drawing.Point(411, 281);
            this.btn_ne.Name = "btn_ne";
            this.btn_ne.Size = new System.Drawing.Size(87, 34);
            this.btn_ne.TabIndex = 3;
            this.btn_ne.Text = "Ne!";
            this.btn_ne.UseVisualStyleBackColor = true;
            this.btn_ne.Click += new System.EventHandler(this.btn_ne_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(33, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Da li ste sigurni da želite izbrisati";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(559, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "korisnika?";
            // 
            // frm_obrisikorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 343);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ne);
            this.Controls.Add(this.txt_korisnickoime);
            this.Controls.Add(this.btn_da);
            this.Controls.Add(this.label1);
            this.Name = "frm_obrisikorisnika";
            this.Text = "frm_obrisikorisnika";
            this.Load += new System.EventHandler(this.frm_obrisikorisnika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_da;
        private System.Windows.Forms.TextBox txt_korisnickoime;
        private System.Windows.Forms.Button btn_ne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}