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
    public partial class frm_novaDrzava : Form
    {
        APIService _apiService=new APIService("Parking");
        public frm_novaDrzava()
        {
            InitializeComponent();
        }

        private void txt_nazivDrzave_Validating(object sender, CancelEventArgs e)
        {
            if (IsValid(txt_nazivDrzave.Text) == false)
            {
                errorProvider1.SetError(txt_nazivDrzave, "Obavezno polje, te može da sadrži samo slova!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_nazivDrzave, null);
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
            if (Content == null || Content==" " || Content=="")
                return false;
            foreach (var item in Content)
            {
                if (char.IsLetter(item) == false && item.ToString()!=" ")
                    return false;
            }
            return true;
        }

        private async void btn_snimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                InsertDrzavaRequest model = new InsertDrzavaRequest();
                model.NazivDrzave = txt_nazivDrzave.Text;
                model.Skracenica = txt_skracenica.Text;
                
                await _apiService.InsertDrzava<InsertDrzavaRequest>(model);
                MessageBox.Show("Uspješno dodana nova država!", "Nova država", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
