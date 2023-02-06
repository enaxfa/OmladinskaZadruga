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
            mainController.SearchOmladinac(txtFilter.Text, this);
        }
    }
}
