using Client.Helpers;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Client.GUIController
{
    internal class LoginController
    {
        internal bool Connect()
        {
            try
            {
                Communication.Instance.Connect();
                return true;
            }
            catch (SocketException)
            {
                MessageBox.Show("Greska pri povezivanju sa serverom!");
                return false;
            }
        }

        internal void Login(TextBox txtUsername, TextBox txtPassword, FrmLogin frmLogin)
        {
            if (!Validator.EmptyFieldValidation(txtUsername) | !Validator.EmptyFieldValidation(txtPassword))
                return;

            Administrator a = new Administrator
            {
                KorisnickoIme = txtUsername.Text,
                Sifra = txtPassword.Text
            };
            Administrator administrator = Communication.Instance.Login(a);

            if (administrator != null)
            {
                FrmMain frmMain = new FrmMain();
                MessageBox.Show($"Administrator {administrator.Ime} {administrator.Prezime} se uspešno prijavio!");
                frmMain.FormBorderStyle = FormBorderStyle.FixedDialog;
                frmLogin.Visible = false;
                frmMain.ShowDialog();
                frmLogin.Dispose();

            }
            else
            {
                MessageBox.Show("Wrong credentials!");
            }
        }
    }
}
