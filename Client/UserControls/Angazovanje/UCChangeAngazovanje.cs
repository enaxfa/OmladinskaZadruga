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
        }

        
    }
}
