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

namespace eParking.Desktop.Korisnik
{
    public partial class frm_login : Form
    {
        private APIService _apiService = new APIService("Korisnik");
        public frm_login()
        {
            InitializeComponent();
        }

        private async void btn_potvrdi_Click(object sender, EventArgs e)
        {
            APIService.Username = txt_korisnickoime.ToString();
            APIService.Password = txt_lozinka.ToString();
            try
            {
                var obj=await _apiService.GetKorisnika<InsertNoviKorisnikRequest>(txt_korisnickoime.Text);
                if (obj != null)
                {
                    if (obj.UlogaID == 1)
                    {
                        MainForm nova = new MainForm();
                        nova.Show();
                    }
                    else
                    {
                        MainRadnikForm nova = new MainRadnikForm(txt_korisnickoime.Text);
                        nova.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vaši pristupni podaci nisu validni!", "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
