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
    public partial class UCAddPosao : UserControl
    {
        MainController mainController = new MainController();
        public UCAddPosao()
        {
            InitializeComponent();
            mainController.LoadComboBox(cbPoslodavac, cbTipPosla);
        }
    }
}
