using Client.Controller;
using System;
using System.Text;
using System.Windows.Forms;

namespace Client.UserControls.Omladinac
{
    public partial class UCUpdateOmladinac : UserControl
    {
        private MainController mainController = new MainController();
        public UCUpdateOmladinac()
        {
            InitializeComponent();
        }


        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            mainController.SearchOmladinac(txtFilter, this);
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            mainController.PrikaziOmladinca(dgvOmladinci, txtIme, txtPrezime, txtJMBG, txtBrRacuna, txtBrTelefona, txtDatumRodjenja);
            btnIzmeni.Enabled = true;
            btnObrisi.Enabled = true;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            mainController.UpdateOmladinac(dgvOmladinci,txtIme, txtPrezime, txtJMBG, txtBrRacuna, txtBrTelefona, txtDatumRodjenja);
        }
    }
}
