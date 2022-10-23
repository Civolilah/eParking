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
    public partial class frm_novoparkingmjesto : Form
    {
        private int _id;
        private APIService _aPIService = new APIService("Parking");
        public frm_novoparkingmjesto(int id)
        {
            InitializeComponent();
            _id = id;
        }
        private void btn_novitip_Click(object sender, EventArgs e)
        {
            frm_novitipparkingmjesta model = new frm_novitipparkingmjesta();
            model.Show();
        }
        private async void frm_novoparkingmjesto_Load(object sender, EventArgs e)
        {
            var objec = await _aPIService.GetSveTipoveParkingMjesta<List<TipParkingMjesta>>();
            cmb_tipparkingmjesta.DataSource = objec;
            cmb_tipparkingmjesta.DisplayMember = "Naziv";
            cmb_tipparkingmjesta.ValueMember = "TipParkingMjestaID";
        }
        private void txt_nazivparkingmjesta_Validating(object sender, CancelEventArgs e)
        {
            if (IsValid(txt_nazivparkingmjesta.Text) == false)
            {
                errorProvider1.SetError(txt_nazivparkingmjesta, "Obavezno polje, te može da sadrži samo slova,brojeve i razmake!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_nazivparkingmjesta, null);
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
                if (item.ToString() != "" && item.ToString() != " " && !char.IsLetterOrDigit(item))
                {
                    return false;
                }
            }
            return true;
        }
        private async void btn_snimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                InsertNovoParkingMjesto model = new InsertNovoParkingMjesto {
                    NazivParkingMjesta=txt_nazivparkingmjesta.Text,
                    ParkingID=_id,
                    TipMjestaID=int.Parse(cmb_tipparkingmjesta.SelectedValue.ToString())
                };

                InsertNovoParkingMjesto back = await _aPIService.InsertParkingMjesto<InsertNovoParkingMjesto>(model);
                if (back.NazivParkingMjesta == "Postoji")
                {
                    MessageBox.Show("Parking mjesto sa ovim nazivom već postoji!", "Novo parking mjesto", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Uspješno dodano novo parking mjesto!", "Novo parking mjesto", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }
    }
}
