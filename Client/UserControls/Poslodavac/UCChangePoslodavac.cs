using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls.Poslodavac
{
    public partial class UCChangePoslodavac : UserControl
    {
        public UCChangePoslodavac()
        {
            InitializeComponent();
            pnlDetails.Controls.Add(pnlDetails);
        }
    }
}
