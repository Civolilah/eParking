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
    public partial class frm_obrisikorisnika : Form
    {
        private int _korisnikid;
        private string _korisnickoime;
        private APIService _apiService = new APIService("Korisnik");
        public frm_obrisikorisnika(int korisnikid,string korisnickoime)
        {
            _korisnikid = korisnikid;
            _korisnickoime = korisnickoime;
            InitializeComponent();
        }
        private void btn_ne_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void btn_da_Click(object sender, EventArgs e)
        {
            Data.Korisnik obj = await _apiService.IzbrisiKorisnika<Data.Korisnik>(_korisnikid);
            if (obj.NazivKorisnika == "NePostoji")
            {
                MessageBox.Show("Korisnik kojeg ste pokušali izbrisati više ne postoji u sistemu!", "Greška", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Uspješno izbrisan korisnik!", "Brisanje korisnika", MessageBoxButtons.OK);
                this.Close();
            }
        }
        private void frm_obrisikorisnika_Load(object sender, EventArgs e)
        {
            txt_korisnickoime.Text = _korisnickoime;
        }
    }
}
