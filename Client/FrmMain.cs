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

namespace Client
{
    public partial class FrmMain : Form
    {
        private MainController mainController = new MainController();
        public FrmMain()
        {
            InitializeComponent();
        }

        internal void SetPanel(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            userControl.Parent = pnlMain;
            userControl.Dock = DockStyle.Fill;
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCAddOmladinac(this);
        }
    }
}
