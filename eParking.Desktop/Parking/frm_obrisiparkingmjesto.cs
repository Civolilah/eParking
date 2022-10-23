using eParking.Data.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eParking.Desktop.Parking
{
    public partial class frm_obrisiparkingmjesto : Form
    {
        private int _idparkingmjesta;
        private string _nazivparkingmjesta;
        private APIService _apiService = new APIService("Parking");
        public frm_obrisiparkingmjesto(int  id,string naziv)
        {
            InitializeComponent();
            _idparkingmjesta = id;
            _nazivparkingmjesta = naziv;
        }
        private void btn_ne_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_obrisiparkingmjesto_Load(object sender, EventArgs e)
        {
            txt_nazivparkingmjesta.Text = _nazivparkingmjesta;
        }
        private async void btn_da_Click(object sender, EventArgs e)
        {
            DeleteParkingMjestoRequest model = await _apiService.IzbrisiParkingMjesto<DeleteParkingMjestoRequest>(_idparkingmjesta);
            if (model.Naziv == "NePostoji")
            {
                MessageBox.Show("Parking mjesto koje ste željeli izbrisati više ne postoji u sistemu!", "Greška", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Uspješno ste izbrisali parking mjesto!", "Brisanje parking mjesta", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
