
namespace eParking.Desktop.Parking
{
    partial class frm_novoparkingmjesto
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
            this.cmb_tipparkingmjesta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nazivparkingmjesta = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(184, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo parking mjesto";
            // 
            // btn_snimi
            // 
            this.btn_snimi.Location = new System.Drawing.Point(259, 297);
            this.btn_snimi.Name = "btn_snimi";
            this.btn_snimi.Size = new System.Drawing.Size(108, 35);
            this.btn_snimi.TabIndex = 1;
            this.btn_snimi.Text = "Snimi";
            this.btn_snimi.UseVisualStyleBackColor = true;
            this.btn_snimi.Click += new System.EventHandler(this.btn_snimi_Click);
            // 
            // cmb_tipparkingmjesta
            // 
            this.cmb_tipparkingmjesta.FormattingEnabled = true;
            this.cmb_tipparkingmjesta.Location = new System.Drawing.Point(61, 201);
            this.cmb_tipparkingmjesta.Name = "cmb_tipparkingmjesta";
            this.cmb_tipparkingmjesta.Size = new System.Drawing.Size(158, 24);
            this.cmb_tipparkingmjesta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naziv parking mjesta:";
            // 
            // txt_nazivparkingmjesta
            // 
            this.txt_nazivparkingmjesta.Location = new System.Drawing.Point(61, 106);
            this.txt_nazivparkingmjesta.Name = "txt_nazivparkingmjesta";
            this.txt_nazivparkingmjesta.Size = new System.Drawing.Size(158, 22);
            this.txt_nazivparkingmjesta.TabIndex = 4;
            this.txt_nazivparkingmjesta.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nazivparkingmjesta_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tip parking mjesta:";
            // 
            // btn_novitip
            // 
            this.btn_novitip.Location = new System.Drawing.Point(228, 196);
            this.btn_novitip.Name = "btn_novitip";
            this.btn_novitip.Size = new System.Drawing.Size(84, 32);
            this.btn_novitip.TabIndex = 6;
            this.btn_novitip.Text = "Novi tip";
            this.btn_novitip.UseVisualStyleBackColor = true;
            this.btn_novitip.Click += new System.EventHandler(this.btn_novitip_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_novoparkingmjesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 344);
            this.Controls.Add(this.btn_novitip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nazivparkingmjesta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_tipparkingmjesta);
            this.Controls.Add(this.btn_snimi);
            this.Controls.Add(this.label1);
            this.Name = "frm_novoparkingmjesto";
            this.Text = "frm_novoparkingmjesto";
            this.Load += new System.EventHandler(this.frm_novoparkingmjesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_snimi;
        private System.Windows.Forms.ComboBox cmb_tipparkingmjesta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nazivparkingmjesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_novitip;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}