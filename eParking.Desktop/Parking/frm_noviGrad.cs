using eParking.Data;
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
    public partial class frm_noviGrad : Form
    {
        private readonly APIService _apiService = new APIService("Parking");
        public frm_noviGrad()
        {
            InitializeComponent();
        }
        private void btn_novadrzava_Click(object sender, EventArgs e)
        {
            frm_novaDrzava nova = new frm_novaDrzava();
            nova.Show();
        }
        private async void frm_noviGrad_Load(object sender, EventArgs e)
        {
            cmb_drzave.DataSource = await _apiService.GetDrzave<List<Drzava>>();
            cmb_drzave.ValueMember = "DrzavaID";
            cmb_drzave.DisplayMember = "Naziv";
        }
        private void txt_nazivgrada_Validating(object sender, CancelEventArgs e)
        {
            if (IsValid(txt_nazivgrada.Text) == false)
            {
                errorProvider1.SetError(txt_nazivgrada, "Obavezno polje, te može da sadrži samo slova!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_nazivgrada, null);
            }
        }
        private void txt_skracenica_Validating(object sender, CancelEventArgs e)
        {
            if (IsValid(txt_skracenica.Text) == false)
            {
                errorProvider1.SetError(txt_skracenica, "Obavezno polje, te može da sadrži samo slova!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_skracenica, null);
            }
        }
        bool IsValid(string Content)
        {
            if (string.IsNullOrEmpty(Content))
                return false;
            foreach (var item in Content)
            {
                if (char.IsLetter(item) == false && item.ToString() != " ")
                    return false;
            }
            return true;
        }
        private async void btn_snimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                InsertGradRequest model = new InsertGradRequest
                {
                    NazivGrada = txt_nazivgrada.Text,
                    Skracenica = txt_skracenica.Text,
                    DrzavaID=int.Parse(cmb_drzave.SelectedValue.ToString())
                };

                await _apiService.InsertGrad<InsertGradRequest>(model);
                MessageBox.Show("Uspješno dodan novi grad!", "Novi grad", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
