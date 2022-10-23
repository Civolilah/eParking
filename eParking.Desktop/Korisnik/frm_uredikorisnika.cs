using eParking.Data;
using eParking.Data.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eParking.Desktop.Korisnik
{
    public partial class frm_uredikorisnika : Form
    {
        private APIService _apiService = new APIService("Korisnik");
        private int _korisnikID;
        private List<Data.Parking> ListaParkingaMain;
        public frm_uredikorisnika(int korisnikid)
        {
            _korisnikID = korisnikid;
            InitializeComponent();
        }
        private async void frm_uredikorisnika_Load(object sender, EventArgs e)
        {
            cmb_uloga.DataSource = await _apiService.GetUloge<List<Uloge>>();
            cmb_uloga.DisplayMember = "Naziv";
            cmb_uloga.ValueMember = "UlogaID";

            ListaParkingaMain = await _apiService.GetParkinge<List<Data.Parking>>();
            cmb_parking.DataSource = ListaParkingaMain;
            cmb_parking.DisplayMember = "Naziv";
            cmb_parking.ValueMember = "ParkingID";

            UrediKorisnikaVM model= await _apiService.GetUrediKorisnika<UrediKorisnikaVM>(_korisnikID);
            if (model.KorisnickoIme == "NePostoji")
            {
                MessageBox.Show("Korisnik čije detalje želite da izmijenite više ne postoji u sistemu!", "Greška", MessageBoxButtons.OK);
                this.Close();
            }
            txt_korisnickoime.Text = model.KorisnickoIme;
            
        }   
        private void cmb_uloga_Validating(object sender, CancelEventArgs e)
        {
            if (cmb_uloga.Text != "Administrator" && ListaParkingaMain.Count == 0)
            {
                errorProvider1.SetError(cmb_uloga, "Nema nijedan parking u sistemu koji biste dodijelili novom korisniku!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cmb_uloga, null);
            }
        }
        private void btn_novauloga_Click(object sender, EventArgs e)
        {
            frm_novauloga nova = new frm_novauloga();
            nova.Show();
        }
        private async void txt_korisnickoime_Validating(object sender, CancelEventArgs e)
        {
            if (Validation(txt_korisnickoime.Text) == false)
            {
                errorProvider1.SetError(txt_korisnickoime, "Obavezno polje, maksimalan broj karaktera je 20 te polje moze da sadrzi slova ili brojeve!");
                e.Cancel = true;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txt_korisnickoime.Text) && !string.IsNullOrEmpty(txt_korisnickoime.Text))
                {
                    if (await _apiService.IsUnique<bool>(txt_korisnickoime.Text) == true)
                    {
                        errorProvider1.SetError(txt_korisnickoime, "Naziv korisnika mora biti jedinstven!");
                        e.Cancel = true;
                    }
                    errorProvider1.SetError(txt_korisnickoime, null);
                }
            }
        }
        private void txt_staripassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_staripassword.Text))
            {
                errorProvider1.SetError(txt_staripassword, "Obavezno polje, molimo potvrdite stari password!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_staripassword, null);
            }
        }
        private void txt_novipassword_Validating(object sender, CancelEventArgs e)
        {
            if (ValidationPassword(txt_novipassword.Text) == false)
            {
                errorProvider1.SetError(txt_novipassword, "Obavezno polje, maksimalan broj karaktera je 20 te polje mora da sadrzi barem jedno veliko slovo te moze da sadrzi mala slova ili brojeve!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_novipassword, null);
            }
        }
        private void txt_potvrdanovi_Validating(object sender, CancelEventArgs e)
        {
            if (txt_novipassword.Text != txt_potvrdanovi.Text)
            {
                errorProvider1.SetError(txt_potvrdanovi, "Nova lozinka i potvrda lozinke nisu isti!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_potvrdanovi, null);
            }
        }
        private bool Validation(string pretraga)
        {
            bool isAlphaBet = false;
            bool isnumberBet = false;
            if (string.IsNullOrEmpty(pretraga))
                return false;
            if (pretraga.Length > 20)
                return false;
            for (int i = 0; i < pretraga.Length; i++)
            {
                isAlphaBet = Regex.IsMatch(pretraga[i].ToString(), "[a-zA-Z]", RegexOptions.IgnoreCase);
                isnumberBet = Regex.IsMatch(pretraga[i].ToString(), "[0-9]", RegexOptions.IgnoreCase);
                if (isAlphaBet == false && isnumberBet == false)
                    return false;
            }
            return true;
        }
        private bool ValidationPassword(string pretraga)
        {
            if(!string.IsNullOrEmpty(pretraga))
            {
                bool isAlphaBet = false;
                bool isnumberBet = false;
                if (ImaVeliko(pretraga) == false)
                    return false;
                if (string.IsNullOrEmpty(pretraga))
                    return false;
                if (pretraga.Length > 20)
                    return false;
                for (int i = 0; i < pretraga.Length; i++)
                {
                    isAlphaBet = Regex.IsMatch(pretraga[i].ToString(), "[a-zA-Z]", RegexOptions.IgnoreCase);
                    isnumberBet = Regex.IsMatch(pretraga[i].ToString(), "[0-9]", RegexOptions.IgnoreCase);
                    if (isAlphaBet == false && isnumberBet == false)
                        return false;
                }
            }
            return true;
        }
        private bool ImaVeliko(string pretraga)
        {
            bool isvelikoslovo = false;
            for (int i = 0; i < pretraga.Length; i++)
            {
                if (pretraga[i] >= 'A' && pretraga[i] <= 'Z')
                    isvelikoslovo = true;
                if (isvelikoslovo)
                    return true;
            }

            return false;
        }
        private async void btn_snimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                UrediKorisnikaRequest model = new UrediKorisnikaRequest
                {
                    KorisnickoIme=txt_korisnickoime.Text,
                    KorisnikID=_korisnikID,
                    NoviPassoword=txt_novipassword.Text,
                    ParkingID=int.Parse(cmb_parking.SelectedValue.ToString()),
                    UlogaID= int.Parse(cmb_uloga.SelectedValue.ToString()),
                    StariPassword=txt_staripassword.Text
                };
                
                UrediKorisnikaRequest mod=await _apiService.UrediKorisnika<UrediKorisnikaRequest>(model);
                if (mod.StariPassword == "Stari")
                {
                    MessageBox.Show("Stari password nije ispravan!", "Greška", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Uspješno izmjenjeni detalji korisnika!", "Uredi korisnika", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }
    }
}
