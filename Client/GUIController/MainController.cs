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
            if (!UCHelper.EmptyFieldValidation(txtJMBG) | !UCHelper.JMBGValidation(txtJMBG) |
                 !UCHelper.EmptyFieldValidation(txtIme) | !UCHelper.EmptyFieldValidation(txtPrezime) | !UCHelper.EmptyFieldValidation(txtBrRacuna) |
                 !UCHelper.EmptyFieldValidation(txtBrTelefona) | !UCHelper.AllNumberValidation(txtBrRacuna) | !UCHelper.AllNumberValidation(txtBrTelefona)
                 | !UCHelper.DataValidation(txtDatumRodjenja))
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
                UCHelper.ResetFields(txtIme, txtPrezime, txtJMBG, txtDatumRodjenja, txtBrRacuna, txtBrTelefona);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void SearchOmladinac(TextBox txtFilter, UCUpdateOmladinac userControl)
        {
            if (!UCHelper.EmptyFieldValidation(txtFilter))
            {
                MessageBox.Show("Unesite podatke za pretragu");
                return;
            }
            Omladinac o = new Omladinac();
            o.Uslov = $"Ime like '{txtFilter.Text}%' or Prezime like '{txtFilter.Text}%' or JMBG like '{txtFilter.Text}%'";
            List<Omladinac> omladinci = Communication.Instance.SearchOmladinac(o);
            if (omladinci.Count == 0)
                MessageBox.Show("Omladinac ne postoji");
            else userControl.DgvOmladinci.DataSource = omladinci;
        }

        internal void PrikaziOmladinca(DataGridView dgvOmladinci, TextBox txtIme, TextBox txtPrezime, TextBox txtJMBG, TextBox txtBrRacuna, TextBox txtBrTelefona, TextBox txtDatumRodjenja)
        {
            if (dgvOmladinci.SelectedRows.Count == 0 || (Omladinac)dgvOmladinci.SelectedRows[0].DataBoundItem == null)
            {
                MessageBox.Show("Niste izabrali ni jednog učesnika!");
                return;
            }
            Omladinac omladinac = (Omladinac)dgvOmladinci.SelectedRows[0].DataBoundItem;
            txtIme.Text = omladinac.Ime;
            txtPrezime.Text = omladinac.Prezime;
            txtJMBG.Text = omladinac.JMBG;
            txtBrRacuna.Text = omladinac.BrojRacuna;
            txtBrTelefona.Text = omladinac.BrojTelefona;
            txtDatumRodjenja.Text = omladinac.DatumRodjenja.ToString("yyyy-MM-dd");
        }

        internal void UpdateOmladinac(DataGridView dgvOmladinci, TextBox txtIme, TextBox txtPrezime, TextBox txtJMBG, TextBox txtBrRacuna, TextBox txtBrTelefona, TextBox txtDatumRodjenja)
        {
            if (!UCHelper.EmptyFieldValidation(txtJMBG) | !UCHelper.JMBGValidation(txtJMBG) |
                  !UCHelper.EmptyFieldValidation(txtIme) | !UCHelper.EmptyFieldValidation(txtPrezime) | !UCHelper.EmptyFieldValidation(txtBrRacuna) |
                  !UCHelper.EmptyFieldValidation(txtBrTelefona) | !UCHelper.AllNumberValidation(txtBrRacuna) | !UCHelper.AllNumberValidation(txtBrTelefona)
                  | !UCHelper.DataValidation(txtDatumRodjenja))
            {
                MessageBox.Show("Podaci nisu ispravno uneti!");
                return;
            }


            String datumRodjString = txtDatumRodjenja.Text;
            String formatDatum = "yyyy-MM-dd";
            Omladinac omladinac = new Omladinac
            {
                IDOmladinca = ((Omladinac)dgvOmladinci.SelectedRows[0].DataBoundItem).IDOmladinca,
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                JMBG = txtJMBG.Text,
                BrojTelefona = txtBrTelefona.Text,
                BrojRacuna = txtBrRacuna.Text,
                DatumRodjenja = DateTime.ParseExact(datumRodjString, formatDatum, CultureInfo.InvariantCulture)
            };
            Communication.Instance.UpdateOmladinca(omladinac);
            MessageBox.Show("Uspešno ste izmenili omladinca!");
        }
    }
}

