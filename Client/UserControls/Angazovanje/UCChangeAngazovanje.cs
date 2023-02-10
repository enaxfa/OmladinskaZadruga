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

namespace Client.UserControls.Angazovanje
{
    public partial class UCChangeAngazovanje : UserControl
    {
        private MainController mainController = new MainController();
        public UCChangeAngazovanje()
        {
            InitializeComponent();
            dgvAngazovanja.DataSource = mainController.GetAngazovanja();
            dtpDatumAngazovanja.MinDate = DateTime.Now;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dgvAngazovanja.DataSource = mainController.SearchAngazovanja(txtFilter);
        }

        private void dgvAngazovanja_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mainController.PrikaziAngazovanje(dgvAngazovanja,txtImeOmladinca,txtBrTelOml,txtBrRacOml,txtDatumRodj, txtPosao,txtPoslodavac,txtSatnica,txtCenaRS,txtBrOml);
            btnObrisi.Enabled = true;
            dgvOmladinci.DataSource = mainController.GetOmladinci();
        }

        
        private void btnObrisi_Click_1(object sender, EventArgs e)
        {
            mainController.DeleteAngazovanje(dgvAngazovanja);
        }

        private void dgvOmladinci_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mainController.PrikaziOmladinca(dgvOmladinci, txtImeOmladinca, txtBrTelOml, txtBrRacOml, txtDatumRodj);
            btnIzmeni.Enabled = true;
        }

        private void txtFilterOml_TextChanged(object sender, EventArgs e)
        {
            mainController.SearchOmladinac(txtFilterOml);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            mainController.UpdateAngazovanje(dgvAngazovanja, dgvOmladinci, dtpDatumAngazovanja);
        }
    }
}
