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

namespace eParking.Desktop
{
    public partial class MainRadnikForm : Form
    {
        private string _UserName;
        private APIService _parkingService = new APIService("Parking");
        public MainRadnikForm(string UserName)
        {
            _UserName = UserName;
            InitializeComponent();
        }
        private async void MainRadnikForm_Load(object sender, EventArgs e)
        {
            RadnikMainRequest model = await _parkingService.GetParking<RadnikMainRequest>(_UserName);
            txt_nazivparkinga.Text = model.NazivParkinga;

            dgv_parkingmjesta.AutoGenerateColumns = false;
            dgv_parkingmjesta.DataSource = model.ListaParkingMijesta;
        }
        private async void dgv_parkingmjesta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                DataGridViewRow red = dgv_parkingmjesta.Rows[e.RowIndex];
                string idd = red.Cells[0].Value.ToString();
                int id = int.Parse(idd);
                ParkingMjestoStatusRequest model = new ParkingMjestoStatusRequest
                {
                    ParkingMjestoID = id
                };
                await _parkingService.SlobodnoMjesto<ParkingMjestoStatusRequest>(model);
                RadnikMainRequest model1 = await _parkingService.GetParking<RadnikMainRequest>(_UserName);
                dgv_parkingmjesta.AutoGenerateColumns = false;
                dgv_parkingmjesta.DataSource = model1.ListaParkingMijesta;
            }

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                DataGridViewRow red = dgv_parkingmjesta.Rows[e.RowIndex];
                string idd = red.Cells[0].Value.ToString();
                int id = int.Parse(idd);
                ParkingMjestoStatusRequest model = new ParkingMjestoStatusRequest
                {
                    ParkingMjestoID = id
                };
                await _parkingService.ZauzetoMjesto<ParkingMjestoStatusRequest>(model);
                RadnikMainRequest model1 = await _parkingService.GetParking<RadnikMainRequest>(_UserName);
                dgv_parkingmjesta.AutoGenerateColumns = false;
                dgv_parkingmjesta.DataSource = model1.ListaParkingMijesta;
            }
        }
    }
}
