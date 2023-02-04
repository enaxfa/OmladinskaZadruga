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
    public partial class UCAddOmladinac : UserControl
    {
        public UCAddOmladinac()
        {
            InitializeComponent();
            dtpDatumRodjenja.MaxDate = DateTime.Now;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

        }
    }
}
