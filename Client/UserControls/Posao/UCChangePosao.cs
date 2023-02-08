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
    public partial class UCChangePosao : UserControl
    {
        private MainController mainController = new MainController();
        public UCChangePosao()
        {
            InitializeComponent();
            dgvPoslovi.DataSource = mainController.GetPoslovi();
        }


        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            mainController.SearchPosao(txtFilter, this);
        }
    }
}
