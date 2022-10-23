using eParking.Data;
using eParking.Data.Requests;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
    public partial class frm_urediparking : Form
    {
        private APIService _parkingService = new APIService("Parking");
        private int _parkingid;
        private GMapMarker marker;
        private GMapOverlay markers;
        private string StrLat;
        private string StrLng;
        private int numberofmarkers = 1;
        public frm_urediparking(int id)
        {
            _parkingid = id;
            InitializeComponent();
        }
        private void btn_novigrad_Click(object sender, EventArgs e)
        {
            frm_noviGrad nova = new frm_noviGrad();
            nova.Show();
        }
        private async void frm_urediparking_Load(object sender, EventArgs e)
        {
            UrediParkingRequest model = await _parkingService.UrediParking<UrediParkingRequest>(_parkingid);
            if(model.NazivParkinga== "NePostoji!")
            {
                MessageBox.Show("Ovaj parking više ne postoji u sistemu!", "Greška", MessageBoxButtons.OK);
                this.Close();
            }
            cmb_gradovi.DataSource = await _parkingService.GetGradove<List<Grad>>();
            cmb_gradovi.DisplayMember = "Naziv";
            cmb_gradovi.ValueMember = "GradID";

            cmb_aktivan.Items.Add("Aktivan");
            cmb_aktivan.Items.Add("Neaktivan");
            if (model.Aktivan == true)
            {
                cmb_aktivan.SelectedIndex = 0;
            }
            else
            {
                cmb_aktivan.SelectedIndex = 1;
            }
            txt_nazivparkinga.Text = model.NazivParkinga;
            num_satiod.Value = model.RadnoVrijemeOD.Hour;
            num_satido.Value= model.RadnoVrijemeDO.Hour;
            num_minod.Value = model.RadnoVrijemeOD.Minute;
            num_mindo.Value = model.RadnoVrijemeDO.Minute;

            map.MapProvider = GMapProviders.GoogleMap;
            StrLat = model.Lat;
            StrLng = model.Lang;
            map.Position = new PointLatLng(double.Parse(model.Lat), double.Parse(model.Lang));
            PointLatLng point = new PointLatLng(double.Parse(model.Lat), double.Parse(model.Lang));
            map.MinZoom = 1;
            map.MaxZoom = 100;
            map.Zoom = 7;
            map.DragButton = MouseButtons.Right;
            marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);
            markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);

            dgv_parkingmjesta.AutoGenerateColumns = false;
            dgv_parkingmjesta.DataSource = model.ListaParkingMijesta;
        }
        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (numberofmarkers == 0)
                {
                    var tacka = map.FromLocalToLatLng(e.X, e.Y);
                    double lat = tacka.Lat;
                    double lang = tacka.Lng;
                    StrLat = lat.ToString();
                    StrLng = lang.ToString();

                    PointLatLng point = new PointLatLng(lat, lang);
                    marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);
                    markers = new GMapOverlay("markers");
                    markers.Markers.Add(marker);
                    map.Overlays.Add(markers);
                    var objecc = map.Overlays.Where(a => a.Markers.Count > 1).FirstOrDefault();
                    numberofmarkers++;
                }
                else
                {
                    map.Overlays.Remove(markers);
                    numberofmarkers--;
                }
            }
        }
        private void txt_nazivparkinga_Validating(object sender, CancelEventArgs e)
        {
            if (IsValid(txt_nazivparkinga.Text) == false)
            {
                errorProvider1.SetError(txt_nazivparkinga, "Obavezno polje, te može da sadrži samo slova i razmake!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_nazivparkinga, null);
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
        private void num_satiod_Validating(object sender, CancelEventArgs e)
        {
            if (((int)num_satiod.Value) >= 24 || ((int)num_satiod.Value) < 0)
            {
                errorProvider1.SetError(num_satiod, "Obavezno polje, ovo polje ne može biti vece od 24, jednako tome ili negativno!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(num_satiod, null);
            }

            DateTime Current = DateTime.Now;

            DateTime Start = new DateTime(Current.Year, Current.Month, Current.Day, ((int)num_satiod.Value), ((int)num_minod.Value), 0);
            DateTime End = new DateTime(Current.Year, Current.Month, Current.Day, ((int)num_satido.Value), ((int)num_mindo.Value), 0);

            if (Start >= End)
            {
                errorProvider1.SetError(num_satiod, "Startno vrijeme parkinga mora biti manje od zavrsnog!");
                e.Cancel = true;
            }
            else
            {
                string diff = (Start - End).TotalMinutes.ToString();

                if ((int.Parse(diff) * -1) < 240)
                {
                    errorProvider1.SetError(num_satiod, "Parking najmanje mora da radi 4 sata!");
                    e.Cancel = true;
                }
            }
        }
        private void num_minod_Validating(object sender, CancelEventArgs e)
        {
            if (((int)num_minod.Value) > 59 || ((int)num_minod.Value) < 0)
            {
                errorProvider1.SetError(num_minod, "Obavezno polje, ovo polje ne može biti vece od 59 ili negativno!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(num_minod, null);
            }

            DateTime Current = DateTime.Now;

            DateTime Start = new DateTime(Current.Year, Current.Month, Current.Day, ((int)num_satiod.Value), ((int)num_minod.Value), 0);
            DateTime End = new DateTime(Current.Year, Current.Month, Current.Day, ((int)num_satido.Value), ((int)num_mindo.Value), 0);

            if (Start >= End)
            {
                errorProvider1.SetError(num_minod, "Startno vrijeme parkinga mora biti manje od zavrsnog!");
                e.Cancel = true;
            }
            else
            {
                string diff = (Start - End).TotalMinutes.ToString();

                if ((int.Parse(diff) * -1) < 240)
                {
                    errorProvider1.SetError(num_minod, "Parking najmanje mora da radi 4 sata!");
                    e.Cancel = true;
                }
            }
        }
        private void num_satido_Validating(object sender, CancelEventArgs e)
        {
            if (((int)num_satido.Value) >= 24 || ((int)num_satido.Value) < 0)
            {
                errorProvider1.SetError(num_satido, "Obavezno polje, ovo polje ne može biti vece od 24, jednako tome ili negativno!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(num_satido, null);
            }

            DateTime Current = DateTime.Now;

            DateTime Start = new DateTime(Current.Year, Current.Month, Current.Day, ((int)num_satiod.Value), ((int)num_minod.Value), 0);
            DateTime End = new DateTime(Current.Year, Current.Month, Current.Day, ((int)num_satido.Value), ((int)num_mindo.Value), 0);

            if (Start >= End)
            {
                errorProvider1.SetError(num_satido, "Startno vrijeme parkinga mora biti manje od zavrsnog!");
                e.Cancel = true;
            }
            else
            {
                string diff = (Start - End).TotalMinutes.ToString();

                if ((int.Parse(diff) * -1) < 240)
                {
                    errorProvider1.SetError(num_satido, "Parking najmanje mora da radi 4 sata!");
                    e.Cancel = true;
                }
            }
        }
        private void num_mindo_Validating(object sender, CancelEventArgs e)
        {
            if (((int)num_mindo.Value) > 59 || ((int)num_mindo.Value) < 0)
            {
                errorProvider1.SetError(num_mindo, "Obavezno polje, ovo polje ne može biti vece od 59 ili negativno!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(num_mindo, null);
            }

            DateTime Current = DateTime.Now;

            DateTime Start = new DateTime(Current.Year, Current.Month, Current.Day, ((int)num_satiod.Value), ((int)num_minod.Value), 0);
            DateTime End = new DateTime(Current.Year, Current.Month, Current.Day, ((int)num_satido.Value), ((int)num_mindo.Value), 0);

            if (Start >= End)
            {
                errorProvider1.SetError(num_mindo, "Startno vrijeme parkinga mora biti manje od zavrsnog!");
                e.Cancel = true;
            }
            else
            {
                string diff = (Start - End).TotalMinutes.ToString();

                if ((int.Parse(diff) * -1) < 240)
                {
                    errorProvider1.SetError(num_mindo, "Parking najmanje mora da radi 4 sata!");
                    e.Cancel = true;
                }
            }
        }
        private void map_Validating(object sender, CancelEventArgs e)
        {
            var overl = map.Overlays.Select(a => a.Markers.Count).FirstOrDefault();
            if (overl != 1)
            {
                errorProvider1.SetError(map, "Obavezno polje, te može da sadrži samo jednu zabilježenu odrednicu na kojoj se nalazi parking!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(map, null);
            }
        }
        private async void btn_snimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                bool akt = false;
                if (cmb_aktivan.Text == "Aktivan")
                {
                    akt = true;
                }
                NoviParkingRequest model = new NoviParkingRequest
                {
                    ParkingID=_parkingid,
                    GradID = int.Parse(cmb_gradovi.SelectedValue.ToString()),
                    Lat = StrLat,
                    Lng = StrLng,
                    NazivParkinga = txt_nazivparkinga.Text,
                    RadnoVrijemeOD = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Month, ((int)num_satiod.Value), ((int)num_minod.Value), 0),
                    RadnoVrijemeDO = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Month, ((int)num_satido.Value), ((int)num_mindo.Value), 0),
                    Aktivan = akt
                };
                await _parkingService.IzmijeniParking<NoviParkingRequest>(model);
                MessageBox.Show("Uspješno izmijenjeni podaci o parkingu!", "Izmjena parkinga", MessageBoxButtons.OK);
                this.Close();
            }
        }
        private void dgv_parkingmjesta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                DataGridViewRow red = dgv_parkingmjesta.Rows[e.RowIndex];
                string idd = red.Cells[0].Value.ToString();
                int id = int.Parse(idd);
                frm_urediparkingmjesto nova = new frm_urediparkingmjesto(id);
                nova.Show();
            }

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                DataGridViewRow red = dgv_parkingmjesta.Rows[e.RowIndex];
                string idd = red.Cells[0].Value.ToString();
                int id = int.Parse(idd);
                frm_obrisiparkingmjesto nova = new frm_obrisiparkingmjesto(id, red.Cells[1].Value.ToString());
                nova.Show();
            }
        }
    }
}
