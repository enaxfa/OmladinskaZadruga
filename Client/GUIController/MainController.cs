using Client.Helpers;
using Client.UserControls.Omladinac;
using Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Client.Controller
{
    internal class MainController
    {
        internal void AddOmladinca(TextBox txtJMBG, TextBox txtIme, TextBox txtPrezime, TextBox txtBrTelefona, TextBox txtBrRacuna, TextBox txtDatumRodjenja)
        {
            if (!Validator.EmptyFieldValidation(txtJMBG) | !Validator.JMBGValidation(txtJMBG) |
                 !Validator.EmptyFieldValidation(txtIme) | !Validator.EmptyFieldValidation(txtPrezime) | !Validator.EmptyFieldValidation(txtBrRacuna) |
                 !Validator.EmptyFieldValidation(txtBrTelefona) | !Validator.AllNumberValidation(txtBrRacuna) | !Validator.AllNumberValidation(txtBrTelefona)
                 | !Validator.DataValidation(txtDatumRodjenja))
            {
                MessageBox.Show("Podaci nisu ispravno uneti!");
                return;
            }

            try
            {
                String datumRodjString = txtDatumRodjenja.Text;
                String formatDatum = "yyyy-MM-dd";
                Omladinac omladinac = new Omladinac
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    JMBG = txtJMBG.Text,
                    BrojTelefona = txtBrTelefona.Text,
                    BrojRacuna = txtBrRacuna.Text,
                    DatumRodjenja = DateTime.ParseExact(datumRodjString, formatDatum, CultureInfo.InvariantCulture)
                };
                Communication.Instance.AddOmladinca(omladinac);
                MessageBox.Show("Uspešno ste sačuvali omladinca!");
                txtJMBG.Text = "";
                txtIme.Text = "";
                txtPrezime.Text = "";
                txtBrTelefona.Text = "";
                txtBrRacuna.Text = "";
                txtDatumRodjenja.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

