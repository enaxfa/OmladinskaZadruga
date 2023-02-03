using Client.UserControls.Omladinac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controller
{
    internal class MainController
    {
        
        internal void OpenUCAddOmladinac(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCViewOmladinac());
        }
    }
}
