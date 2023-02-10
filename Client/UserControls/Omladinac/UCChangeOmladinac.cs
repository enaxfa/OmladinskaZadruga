using Client.Controller;
using System;
using System.Text;
using System.Windows.Forms;

namespace Client.UserControls.Omladinac
{
    public partial class UCChangeOmladinac : UserControl
    {
        private MainController mainController = new MainController();
        public UCChangeOmladinac()
        {
            InitializeComponent();
            dgvOmladinci.DataSource = mainController.GetOmladinci();
        }


        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            mainController.UpdateOmladinac(dgvOmladinci,txtIme, txtPrezime, txtJMBG, txtBrRacuna, txtBrTelefona, txtDatumRodjenja);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            mainController.DeleteOmladinac(dgvOmladinci,txtIme,txtPrezime,txtJMBG,txtBrRacuna,txtBrTelefona,txtDatumRodjenja);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dgvOmladinci.DataSource = mainController.SearchOmladinac(txtFilter);
        }


        private void dgvOmladinci_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mainController.PrikaziOmladinca(dgvOmladinci, txtIme, txtPrezime, txtJMBG, txtBrRacuna, txtBrTelefona, txtDatumRodjenja);
            btnIzmeni.Enabled = true;
            btnObrisi.Enabled = true;
        }
    }
}
