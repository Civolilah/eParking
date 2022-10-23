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
    public partial class frm_urediparkingmjesto : Form
    {
        private APIService _aPIService = new APIService("Parking");
        private int _parkingmjestoid;
        public frm_urediparkingmjesto(int id)
        {
            InitializeComponent();
            _parkingmjestoid = id;
        }
        private void btn_novitip_Click(object sender, EventArgs e)
        {
            frm_novitipparkingmjesta model = new frm_novitipparkingmjesta();
            model.Show();
        }
        private async void frm_urediparkingmjesto_Load(object sender, EventArgs e)
        {
            var objec = await _aPIService.GetSveTipoveParkingMjesta<List<TipParkingMjesta>>();
            cmb_tipoviparkingmjesta.DataSource = objec;
            cmb_tipoviparkingmjesta.DisplayMember = "Naziv";
            cmb_tipoviparkingmjesta.ValueMember = "TipParkingMjestaID";

            var naziv= await _aPIService.GetUrediParkingMjesto<UrediParkingMjestoRequest>(_parkingmjestoid);
            if (naziv.NazivParkingMjesta == "NePostoji")
            {
                MessageBox.Show("Parking mjesto koje ste željeli urediti više ne postoji u sistemu!", "Greška", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                txt_naziv.Text = naziv.NazivParkingMjesta;
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
                InsertNovoParkingMjesto model = new InsertNovoParkingMjesto
                {
                    NazivParkingMjesta = txt_naziv.Text,
                    ParkingID = _parkingmjestoid,
                    TipMjestaID = int.Parse(cmb_tipoviparkingmjesta.SelectedValue.ToString())
                };

                InsertNovoParkingMjesto back = await _aPIService.UrediParkingMjesto<InsertNovoParkingMjesto>(model);
                if (back.NazivParkingMjesta == "NePostoji")
                {
                    MessageBox.Show("Ovo parking mjesto više ne postoji u sistemu!", "Greška", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Uspješno izmjenjene postavke parking mjesta!", "Uredi parking mjesto", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }
        private void txt_naziv_Validating(object sender, CancelEventArgs e)
        {
            if (IsValid(txt_naziv.Text) == false)
            {
                errorProvider1.SetError(txt_naziv, "Obavezno polje, te može da sadrži samo slova,brojeve i razmake!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_naziv, null);
            }
        }
    }
}
