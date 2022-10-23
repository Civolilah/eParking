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
    public partial class frm_novauloga : Form
    {
        private APIService _apiService = new APIService("Korisnik");
        public frm_novauloga()
        {
            InitializeComponent();
        }
        private void txt_nazivuloge_Validating(object sender, CancelEventArgs e)
        {
            if (Validation(txt_nazivuloge.Text) == false)
            {
                errorProvider1.SetError(txt_nazivuloge, "Obavezno polje, maksimalan broj karaktera je 20 te polje moze da sadrzi slova!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_nazivuloge, null);
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
                if (isAlphaBet == false)
                    return false;
            }
            return true;
        }
        private async void btn_snimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                InsertNovaUlogaRequest model = new InsertNovaUlogaRequest
                {
                    NazivUloge = txt_nazivuloge.Text
                };

                await _apiService.InsertNovaUloga<InsertNovaUlogaRequest>(model);
                MessageBox.Show("Uspješno dodana nova uloga!", "Nova uloga", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
