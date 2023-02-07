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

        internal void Login(TextBox txtUsername, TextBox txtPassword)
        {
            //if (!UCHelper.EmptyFieldValidation(txtUsername) | !UCHelper.EmptyFieldValidation(txtPassword))
               // return;

            Administrator a = new Administrator
            {
                //KorisnickoIme = txtUsername.Text,
                // Sifra = txtPassword.Text
                KorisnickoIme = "pera",
                Sifra = "pera"
            };
            Administrator administrator = Communication.Instance.Login(a);

           if (administrator != null)
            {
                //MessageBox.Show("Uspesno ste se prijavili!");
                FormCoordinator.Instance.ShowFrmMain(administrator.Ime, administrator.Prezime);
            }
            else
            {
                MessageBox.Show("Korisnik ne postoji!");
            }
        }
    }
}
