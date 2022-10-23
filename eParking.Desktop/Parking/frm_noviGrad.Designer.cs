
namespace eParking.Desktop.Parking
{
    partial class frm_noviGrad
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
            this.cmb_drzave = new System.Windows.Forms.ComboBox();
            this.txt_nazivgrada = new System.Windows.Forms.TextBox();
            this.btn_snimi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_novadrzava = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_skracenica = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(104, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novi grad";
            // 
            // cmb_drzave
            // 
            this.cmb_drzave.FormattingEnabled = true;
            this.cmb_drzave.Location = new System.Drawing.Point(23, 110);
            this.cmb_drzave.Name = "cmb_drzave";
            this.cmb_drzave.Size = new System.Drawing.Size(121, 24);
            this.cmb_drzave.TabIndex = 1;
            // 
            // txt_nazivgrada
            // 
            this.txt_nazivgrada.Location = new System.Drawing.Point(23, 230);
            this.txt_nazivgrada.Name = "txt_nazivgrada";
            this.txt_nazivgrada.Size = new System.Drawing.Size(140, 22);
            this.txt_nazivgrada.TabIndex = 2;
            this.txt_nazivgrada.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nazivgrada_Validating);
            // 
            // btn_snimi
            // 
            this.btn_snimi.Location = new System.Drawing.Point(130, 396);
            this.btn_snimi.Name = "btn_snimi";
            this.btn_snimi.Size = new System.Drawing.Size(91, 42);
            this.btn_snimi.TabIndex = 3;
            this.btn_snimi.Text = "Snimi";
            this.btn_snimi.UseVisualStyleBackColor = true;
            this.btn_snimi.Click += new System.EventHandler(this.btn_snimi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naziv grada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Drzava:";
            // 
            // btn_novadrzava
            // 
            this.btn_novadrzava.Location = new System.Drawing.Point(178, 105);
            this.btn_novadrzava.Name = "btn_novadrzava";
            this.btn_novadrzava.Size = new System.Drawing.Size(104, 32);
            this.btn_novadrzava.TabIndex = 6;
            this.btn_novadrzava.Text = "Nova drzava";
            this.btn_novadrzava.UseVisualStyleBackColor = true;
            this.btn_novadrzava.Click += new System.EventHandler(this.btn_novadrzava_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Skracenica:";
            // 
            // txt_skracenica
            // 
            this.txt_skracenica.Location = new System.Drawing.Point(23, 343);
            this.txt_skracenica.Name = "txt_skracenica";
            this.txt_skracenica.Size = new System.Drawing.Size(140, 22);
            this.txt_skracenica.TabIndex = 8;
            this.txt_skracenica.Validating += new System.ComponentModel.CancelEventHandler(this.txt_skracenica_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_noviGrad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.txt_skracenica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_novadrzava);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_snimi);
            this.Controls.Add(this.txt_nazivgrada);
            this.Controls.Add(this.cmb_drzave);
            this.Controls.Add(this.label1);
            this.Name = "frm_noviGrad";
            this.Text = "frm_noviGrad";
            this.Load += new System.EventHandler(this.frm_noviGrad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_drzave;
        private System.Windows.Forms.TextBox txt_nazivgrada;
        private System.Windows.Forms.Button btn_snimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_novadrzava;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_skracenica;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}