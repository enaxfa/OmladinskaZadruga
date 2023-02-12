using Client.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls.Posao
{
    public partial class UCAddAngazovanje : UserControl
    {
        private MainController mainController = new MainController();
        public UCAddAngazovanje()
        {
            InitializeComponent();
            dgvPoslovi.DataSource = mainController.GetPoslovi();
            dgvOmladinci.DataSource = mainController.GetOmladinci();
            dtpDatumAngazovanja.MinDate = System.DateTime.Now;
        }


        private void txtFilterPosao_TextChanged(object sender, EventArgs e)
        {
            dgvPoslovi.DataSource = mainController.SearchPosao(txtFilterPosao);
        }

        private void txtFilterOmladinac_TextChanged(object sender, EventArgs e)
        {
            dgvOmladinci.DataSource = mainController.SearchOmladinac(txtFilterOmladinac);
        }

        private void dgvPoslovi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label4.Visible = true;
            lblBrOml.Visible = true;
            lblBrOml.Text = mainController.VratiBrojOmladinacaZaPosao(dgvPoslovi);
        }

        private void dgvOmladinci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblBrOml.Text = mainController.VratiBrojPreostalihOmladinaca(dgvOmladinci);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            mainController.AddAngazovanje(dgvPoslovi, dgvOmladinci, dtpDatumAngazovanja, lblBrOml);
        }

        private void UCAddAngazovanje_Load(object sender, EventArgs e)
        {
            dgvOmladinci.ClearSelection();
            dgvPoslovi.ClearSelection();
        }
    }
}
