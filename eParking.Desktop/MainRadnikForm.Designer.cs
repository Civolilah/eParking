
namespace eParking.Desktop
{
    partial class MainRadnikForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_parkingmjesta = new System.Windows.Forms.DataGridView();
            this.ParkingMjestoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivParkingMjesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slobodno = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Zauzeto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_nazivparkinga = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parkingmjesta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_parkingmjesta);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.Location = new System.Drawing.Point(29, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(914, 481);
            this.groupBox1.TabIndex = 1;
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
            this.Tip,
            this.Status,
            this.Slobodno,
            this.Zauzeto});
            this.dgv_parkingmjesta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_parkingmjesta.Location = new System.Drawing.Point(3, 30);
            this.dgv_parkingmjesta.Name = "dgv_parkingmjesta";
            this.dgv_parkingmjesta.ReadOnly = true;
            this.dgv_parkingmjesta.RowHeadersWidth = 51;
            this.dgv_parkingmjesta.RowTemplate.Height = 24;
            this.dgv_parkingmjesta.Size = new System.Drawing.Size(908, 448);
            this.dgv_parkingmjesta.TabIndex = 0;
            this.dgv_parkingmjesta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_parkingmjesta_CellContentClick);
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
            this.NazivParkingMjesta.DataPropertyName = "Naziv";
            this.NazivParkingMjesta.HeaderText = "Naziv";
            this.NazivParkingMjesta.MinimumWidth = 6;
            this.NazivParkingMjesta.Name = "NazivParkingMjesta";
            this.NazivParkingMjesta.ReadOnly = true;
            this.NazivParkingMjesta.Width = 125;
            // 
            // Tip
            // 
            this.Tip.DataPropertyName = "Tip";
            this.Tip.HeaderText = "Tip";
            this.Tip.MinimumWidth = 6;
            this.Tip.Name = "Tip";
            this.Tip.ReadOnly = true;
            this.Tip.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // Slobodno
            // 
            this.Slobodno.HeaderText = "Slobodno";
            this.Slobodno.MinimumWidth = 6;
            this.Slobodno.Name = "Slobodno";
            this.Slobodno.ReadOnly = true;
            this.Slobodno.Text = "Slobodno";
            this.Slobodno.UseColumnTextForButtonValue = true;
            this.Slobodno.Width = 125;
            // 
            // Zauzeto
            // 
            this.Zauzeto.HeaderText = "Zauzeto";
            this.Zauzeto.MinimumWidth = 6;
            this.Zauzeto.Name = "Zauzeto";
            this.Zauzeto.ReadOnly = true;
            this.Zauzeto.Text = "Zauzeto";
            this.Zauzeto.UseColumnTextForButtonValue = true;
            this.Zauzeto.Width = 125;
            // 
            // txt_nazivparkinga
            // 
            this.txt_nazivparkinga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nazivparkinga.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_nazivparkinga.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txt_nazivparkinga.Location = new System.Drawing.Point(354, 28);
            this.txt_nazivparkinga.Name = "txt_nazivparkinga";
            this.txt_nazivparkinga.ReadOnly = true;
            this.txt_nazivparkinga.Size = new System.Drawing.Size(248, 31);
            this.txt_nazivparkinga.TabIndex = 0;
            this.txt_nazivparkinga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainRadnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 652);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_nazivparkinga);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Name = "MainRadnikForm";
            this.Text = "MainRadnikForm";
            this.Load += new System.EventHandler(this.MainRadnikForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parkingmjesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_parkingmjesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParkingMjestoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivParkingMjesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Slobodno;
        private System.Windows.Forms.DataGridViewButtonColumn Zauzeto;
        private System.Windows.Forms.TextBox txt_nazivparkinga;
    }
}