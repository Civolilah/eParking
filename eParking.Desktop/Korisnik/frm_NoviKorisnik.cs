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
using eParking.Data;
using eParking.Data.Requests;

namespace eParking.Desktop.Korisnik
{
    public partial class frm_NoviKorisnik : Form
    {
        private readonly APIService _apiService = new APIService("Korisnik");
        private List<Data.Parking> ListaParkingaMain;
        public frm_NoviKorisnik()
        {
            InitializeComponent();
        }
        private async void frm_NoviKorisnik_Load(object sender, EventArgs e)
        {
            cmb_uloge.DataSource = await _apiService.GetUloge<List<Uloge>>();
            cmb_uloge.DisplayMember = "Naziv";
            cmb_uloge.ValueMember = "UlogaID";

            ListaParkingaMain = await _apiService.GetParkinge<List<Data.Parking>>();
            cmb_parking.DataSource = ListaParkingaMain;
            cmb_parking.DisplayMember = "Naziv";
            cmb_parking.ValueMember = "ParkingID";
        }
        private async void btn_snimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                InsertNoviKorisnikRequest novi = new InsertNoviKorisnikRequest
                {
                    KorisnickoIme=txt_nazivkorisnika.Text,
                    Lozinka=txt_loznika.Text,
                    ParkingID=int.Parse(cmb_parking.SelectedValue.ToString()),
                    UlogaID= int.Parse(cmb_uloge.SelectedValue.ToString())
                };

                InsertNoviKorisnikRequest ret=await _apiService.InsertKorisnika<InsertNoviKorisnikRequest>(novi);
                if (ret.KorisnickoIme != "Postoji")
                {
                    MessageBox.Show("Uspješno dodan novi korisnik!", "Novi korisnik", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Korisnik sa ovakvim korisničkim imenom već postoji!", "Greška", MessageBoxButtons.OK);
                }
            }
        }
        private async void txt_nazivkorisnika_Validating(object sender, CancelEventArgs e)
        {
            if (Validation(txt_nazivkorisnika.Text) == false)
            {
                errorProvider1.SetError(txt_nazivkorisnika, "Obavezno polje, maksimalan broj karaktera je 20 te polje moze da sadrzi slova ili brojeve!");
                e.Cancel = true;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txt_nazivkorisnika.Text) && !string.IsNullOrEmpty(txt_nazivkorisnika.Text))
                {
                    if (await _apiService.IsUnique<bool>(txt_nazivkorisnika.Text) == true)
                    {
                        errorProvider1.SetError(txt_nazivkorisnika, "Naziv korisnika mora biti jedinstven!");
                        e.Cancel = true;
                    }
                    errorProvider1.SetError(txt_nazivkorisnika, null);
                }
            }
        }
        private void txt_loznika_Validating(object sender, CancelEventArgs e)
        {
            if (ValidationPassword(txt_loznika.Text) == false)
            {
                errorProvider1.SetError(txt_loznika, "Obavezno polje, maksimalan broj karaktera je 20 te polje mora da sadrzi barem jedno veliko slovo te moze da sadrzi mala slova ili brojeve!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_loznika, null);
            }
        }
        private void txt_potvrdaloznike_Validating(object sender, CancelEventArgs e)
        {
            if (txt_loznika.Text != txt_potvrdaloznike.Text)
            {
                errorProvider1.SetError(txt_potvrdaloznike, "Lozinka i potvrda lozinke nisu isti!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_potvrdaloznike, null);
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
            if (!string.IsNullOrEmpty(pretraga))
            {
                bool isAlphaBet = false;
                bool isnumberBet = false;
                if (ImaVeliko(pretraga) == false)
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
        private void cmb_uloge_Validating(object sender, CancelEventArgs e)
        {
            if (cmb_uloge.Text!="Administrator"&& ListaParkingaMain.Count==0)
            {
                errorProvider1.SetError(cmb_uloge, "Nema nijedan parking u sistemu koji biste dodijelili novom korisniku!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cmb_uloge, null);
            }
        }
        private void btn_novauloga_Click(object sender, EventArgs e)
        {
            frm_novauloga nova = new frm_novauloga();
            nova.Show();
        }
    }
}
