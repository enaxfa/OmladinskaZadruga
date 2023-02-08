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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Client.UserControls.Poslodavac
{
    public partial class UCChangePoslodavac : UserControl
    {
        private MainController mainController = new MainController();
        public UCChangePoslodavac()
        {
            InitializeComponent();
            dgvPoslodavci.DataSource = mainController.GetPoslodavci();
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            mainController.PrikaziPoslodavca(dgvPoslodavci, txtNaziv, txtPIB, txtAdresa, txtEmail, txtBrTelefona);
            btnIzmeni.Enabled = true;
            btnObrisi.Enabled = true;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            mainController.UpdatePoslodavac(dgvPoslodavci, txtNaziv, txtPIB, txtAdresa, txtEmail, txtBrTelefona);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            mainController.DeletePoslodavac(dgvPoslodavci, txtNaziv, txtPIB, txtAdresa, txtEmail, txtBrTelefona);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dgvPoslodavci.DataSource = mainController.SearchPoslodavac(txtFilter, this);
        }
    }
}
