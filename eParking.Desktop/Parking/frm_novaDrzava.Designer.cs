
namespace eParking.Desktop.Parking
{
    partial class frm_novaDrzava
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
            this.txt_nazivDrzave = new System.Windows.Forms.TextBox();
            this.btn_snimi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_skracenica = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(73, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nova drzava";
            // 
            // txt_nazivDrzave
            // 
            this.txt_nazivDrzave.Location = new System.Drawing.Point(31, 159);
            this.txt_nazivDrzave.Name = "txt_nazivDrzave";
            this.txt_nazivDrzave.Size = new System.Drawing.Size(169, 22);
            this.txt_nazivDrzave.TabIndex = 1;
            this.txt_nazivDrzave.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nazivDrzave_Validating);
            // 
            // btn_snimi
            // 
            this.btn_snimi.Location = new System.Drawing.Point(105, 354);
            this.btn_snimi.Name = "btn_snimi";
            this.btn_snimi.Size = new System.Drawing.Size(95, 33);
            this.btn_snimi.TabIndex = 2;
            this.btn_snimi.Text = "Snimi";
            this.btn_snimi.UseVisualStyleBackColor = true;
            this.btn_snimi.Click += new System.EventHandler(this.btn_snimi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naziv drzave:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Skracenica:";
            // 
            // txt_skracenica
            // 
            this.txt_skracenica.Location = new System.Drawing.Point(31, 266);
            this.txt_skracenica.Name = "txt_skracenica";
            this.txt_skracenica.Size = new System.Drawing.Size(128, 22);
            this.txt_skracenica.TabIndex = 5;
            this.txt_skracenica.Validating += new System.ComponentModel.CancelEventHandler(this.txt_skracenica_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_novaDrzava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 407);
            this.Controls.Add(this.txt_skracenica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_snimi);
            this.Controls.Add(this.txt_nazivDrzave);
            this.Controls.Add(this.label1);
            this.Name = "frm_novaDrzava";
            this.Text = "frm_novaDrzava";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nazivDrzave;
        private System.Windows.Forms.Button btn_snimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_skracenica;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}