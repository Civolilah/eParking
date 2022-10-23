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
    public partial class frm_novitipparkingmjesta : Form
    {
        private APIService _apiService = new APIService("Parking");
        public frm_novitipparkingmjesta()
        {
            InitializeComponent();
        }

        private async void btn_snimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                InsertTipParkingMjestaResponse provjera = await _apiService.InsertTipParkingMjesta<InsertTipParkingMjestaResponse>(txt_naziv.Text);
                if (provjera.Response == "Postoji")
                {
                    MessageBox.Show("Ovaj tip parking mjesta već postoji!", "Novi tip", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Uspješno dodan novi tip parking mjesta!", "Novi tip", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private bool IsValid(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }
            foreach (var item in text)
            {
                if(item.ToString()!="" && item.ToString()!=" " && !char.IsLetter(item))
                {
                    return false;
                }
            }
            return true;
        }

        private void txt_naziv_Validating(object sender, CancelEventArgs e)
        {
            if (IsValid(txt_naziv.Text) == false)
            {
                errorProvider1.SetError(txt_naziv, "Obavezno polje, te može da sadrži samo slova i razmake!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_naziv, null);
            }
        }
    }
}
