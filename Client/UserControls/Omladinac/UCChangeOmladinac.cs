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
        }


        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            mainController.SearchOmladinac(txtFilter, this);
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            mainController.PrikaziOmladinca(dgvOmladinaci, txtIme, txtPrezime, txtJMBG, txtBrRacuna, txtBrTelefona, txtDatumRodjenja);
            btnIzmeni.Enabled = true;
            btnObrisi.Enabled = true;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            mainController.UpdateOmladinac(dgvOmladinaci,txtIme, txtPrezime, txtJMBG, txtBrRacuna, txtBrTelefona, txtDatumRodjenja);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            mainController.DeleteOmladinac(dgvOmladinaci,txtIme,txtPrezime,txtJMBG,txtBrRacuna,txtBrTelefona,txtDatumRodjenja);
        }
    }
}
