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
        }


        private void txtFilterPosao_TextChanged(object sender, EventArgs e)
        {
            dgvPoslovi.DataSource = mainController.SearchPosao(txtFilterPosao);
        }

        private void txtFilterOmladinac_TextChanged(object sender, EventArgs e)
        {
            dgvOmladinci.DataSource = mainController.SearchOmladinac(txtFilterOmladinac);
        }
    }
}
