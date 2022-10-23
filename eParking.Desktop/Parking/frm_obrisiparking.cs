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
    public partial class frm_obrisiparking : Form
    {
        private DeleteParkingRequest _model;
        private APIService _apiService = new APIService("Parking");
        public frm_obrisiparking(DeleteParkingRequest model)
        {
            InitializeComponent();
            _model = model;
        }
        private void btn_ne_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void btn_da_Click(object sender, EventArgs e)
        {
            DeleteParkingRequest model = await _apiService.IzbrisiParking<DeleteParkingRequest>(_model.ParkingID);
            if (model.NazivParkinga == "NePostoji")
            {
                MessageBox.Show("Parking koji ste željeli izbrisati više ne postoji u sistemu!", "Brisanje parkinga", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Uspješno ste izbrisali parking!", "Brisanje parkinga", MessageBoxButtons.OK);
                this.Close();
            }
        }
        private void frm_obrisiparking_Load(object sender, EventArgs e)
        {
            txt_nazivparkinga.Text = _model.NazivParkinga;
        }
    }
}
