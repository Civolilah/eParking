using eParking.Data;
using eParking.Data.Requests;
using eParking.Desktop.Korisnik;
using eParking.Desktop.Parking;
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
    public partial class MainForm : Form
    {
        private APIService _apiService = new APIService("Parking");
        private int childFormNumber = 0;

        public MainForm()
        {
            InitializeComponent();
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();

            }
        }
        private void noviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NoviKorisnik nova = new frm_NoviKorisnik();
            nova.Show();
        }
        private void noviParkingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_noviParking nova = new frm_noviParking();
            nova.Show();
        }
        private async void MainForm_Load(object sender, EventArgs e)
        {
            dgv_parkinzi.AutoGenerateColumns = false;
            dgv_parkinzi.DataSource = await _apiService.GetSveParkinge<List<PriviewSveParkinge>>();
        }
        private void dgv_parkinzi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                DataGridViewRow red = dgv_parkinzi.Rows[e.RowIndex];
                string idd = red.Cells[0].Value.ToString();
                int id = int.Parse(idd);
                frm_urediparking nova = new frm_urediparking(id);
                nova.Show();
            }

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                DataGridViewRow red = dgv_parkinzi.Rows[e.RowIndex];
                string idd = red.Cells[0].Value.ToString();
                int id = int.Parse(idd);
                frm_novoparkingmjesto nova = new frm_novoparkingmjesto(id);
                nova.Show();
            }

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 8)
            {
                DataGridViewRow red = dgv_parkinzi.Rows[e.RowIndex];
                DeleteParkingRequest model = new DeleteParkingRequest();
                string idd = red.Cells[0].Value.ToString();
                int id = int.Parse(idd);
                model.ParkingID = id;
                model.NazivParkinga= red.Cells[1].Value.ToString();
                frm_obrisiparking nova = new frm_obrisiparking(model);
                nova.Show();
            }
        }
        private async void btn_osvjezi_Click(object sender, EventArgs e)
        {
            dgv_parkinzi.AutoGenerateColumns = false;
            dgv_parkinzi.DataSource = await _apiService.GetSveParkinge<List<PriviewSveParkinge>>();
        }

        private void pregledToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_pregledkorisnika nova = new frm_pregledkorisnika();
            nova.Show();
        }
    }
}
