using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eParking.Desktop.Korisnik
{
    public partial class frm_pregledkorisnika : Form
    {
        private APIService _apiService = new APIService("Korisnik");
        public frm_pregledkorisnika()
        {
            InitializeComponent();
        }

        private async void frm_pregledkorisnika_Load(object sender, EventArgs e)
        {
            dgv_korisnici.AutoGenerateColumns = false;
            dgv_korisnici.DataSource = await _apiService.GetSveKorisnike<List<Data.Korisnik>>();
        }

        private async void btn_osvjezi_Click(object sender, EventArgs e)
        {
            dgv_korisnici.AutoGenerateColumns = false;
            dgv_korisnici.DataSource = await _apiService.GetSveKorisnike<List<Data.Korisnik>>();
        }

        private void dgv_korisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                DataGridViewRow red = dgv_korisnici.Rows[e.RowIndex];
                string idd = red.Cells[0].Value.ToString();
                int id = int.Parse(idd);
                frm_uredikorisnika nova = new frm_uredikorisnika(id);
                nova.Show();
            }

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                DataGridViewRow red = dgv_korisnici.Rows[e.RowIndex];
                string idd = red.Cells[0].Value.ToString();
                int id = int.Parse(idd);
                frm_obrisikorisnika nova = new frm_obrisikorisnika(id, red.Cells[1].Value.ToString());
                nova.Show();
            }
        }
    }
}
