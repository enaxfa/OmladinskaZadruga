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

namespace Client.UserControls.Omladinac
{
    public partial class UCUpdateOmladinac : UserControl
    {
        private MainController mainController = new MainController();
        public UCUpdateOmladinac()
        {
            InitializeComponent();
        }

        internal void SetDataGridView(List<Common.Omladinac> omladinci)
        {
            dgvOmladinci.DataSource = omladinci;
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            mainController.SearchOmladinac(txtFilter.Text, this);
        }
    }
}
