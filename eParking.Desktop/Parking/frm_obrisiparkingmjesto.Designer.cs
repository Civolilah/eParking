
namespace eParking.Desktop.Parking
{
    partial class frm_obrisiparkingmjesto
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
            this.txt_nazivparkingmjesta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.Location = new System.Drawing.Point(221, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brisanje parking mjesta";
            // 
            // btn_da
            // 
            this.btn_da.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_da.Location = new System.Drawing.Point(184, 241);
            this.btn_da.Name = "btn_da";
            this.btn_da.Size = new System.Drawing.Size(101, 34);
            this.btn_da.TabIndex = 1;
            this.btn_da.Text = "Da!";
            this.btn_da.UseVisualStyleBackColor = true;
            this.btn_da.Click += new System.EventHandler(this.btn_da_Click);
            // 
            // txt_nazivparkingmjesta
            // 
            this.txt_nazivparkingmjesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nazivparkingmjesta.Location = new System.Drawing.Point(356, 137);
            this.txt_nazivparkingmjesta.Name = "txt_nazivparkingmjesta";
            this.txt_nazivparkingmjesta.ReadOnly = true;
            this.txt_nazivparkingmjesta.Size = new System.Drawing.Size(200, 30);
            this.txt_nazivparkingmjesta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(23, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Da li ste sigurno da želite izbrisati";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(562, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "parking mjesto?";
            // 
            // btn_ne
            // 
            this.btn_ne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_ne.Location = new System.Drawing.Point(464, 241);
            this.btn_ne.Name = "btn_ne";
            this.btn_ne.Size = new System.Drawing.Size(101, 34);
            this.btn_ne.TabIndex = 5;
            this.btn_ne.Text = "Ne!";
            this.btn_ne.UseVisualStyleBackColor = true;
            this.btn_ne.Click += new System.EventHandler(this.btn_ne_Click);
            // 
            // frm_obrisiparkingmjesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 303);
            this.Controls.Add(this.btn_ne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nazivparkingmjesta);
            this.Controls.Add(this.btn_da);
            this.Controls.Add(this.label1);
            this.Name = "frm_obrisiparkingmjesto";
            this.Text = "frm_obrisiparkingmjesto";
            this.Load += new System.EventHandler(this.frm_obrisiparkingmjesto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_da;
        private System.Windows.Forms.TextBox txt_nazivparkingmjesta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ne;
    }
}