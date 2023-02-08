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
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            mainController.AddPosao(txtLokacija, txtSat, txtCenaRS, txtBrOml, cbPoslodavac, cbTipPosla);
        }

        private void UCAddPosao_Load(object sender, EventArgs e)
        {
            mainController.LoadComboBox(cbPoslodavac, cbTipPosla);
        }
    }
}
