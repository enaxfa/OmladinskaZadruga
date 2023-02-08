﻿using Client.Helpers;
using Client.UserControls.Omladinac;
using Client.UserControls.Posao;
using Client.UserControls.Poslodavac;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                Communication.Instance.AddOmladinac(omladinac);
                MessageBox.Show("Uspešno ste dodali omladinca!");
                UCHelper.ResetFields(txtIme, txtPrezime, txtJMBG, txtDatumRodjenja, txtBrRacuna, txtBrTelefona);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        internal void SearchOmladinac(TextBox txtFilter, UCChangeOmladinac userControl)
        {
            
            try
            {
                Omladinac o = new Omladinac();
                o.Uslov = $"Ime like '%{txtFilter.Text}%' or Prezime like '%{txtFilter.Text}%' or JMBG like '%{txtFilter.Text}%' or BrojTelefona like '%{txtFilter.Text}%' or BrojRacuna like '%{txtFilter.Text}%' or DatumRodjenja like '%{txtFilter.Text}%'";
                List<Omladinac> omladinci = Communication.Instance.SearchOmladinac(o);
                userControl.DgvOmladinci.DataSource = omladinci;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private Omladinac omladinac;
        internal void PrikaziOmladinca(DataGridView dgvOmladinci, TextBox txtIme, TextBox txtPrezime, TextBox txtJMBG, TextBox txtBrRacuna, TextBox txtBrTelefona, TextBox txtDatumRodjenja)
        {
            if (dgvOmladinci.SelectedRows.Count == 0 || (Omladinac)dgvOmladinci.SelectedRows[0].DataBoundItem == null)
            {
                MessageBox.Show("Niste izabrali ni jednog omladinca!");
                return;
            }
            omladinac = (Omladinac)dgvOmladinci.SelectedRows[0].DataBoundItem;
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
            try
            {
                String datumRodjString = txtDatumRodjenja.Text;
                String formatDatum = "yyyy-MM-dd";
                omladinac.Ime = txtIme.Text;
                omladinac.Prezime = txtPrezime.Text;
                omladinac.JMBG = txtJMBG.Text;
                omladinac.BrojTelefona = txtBrTelefona.Text;
                omladinac.BrojRacuna = txtBrRacuna.Text;
                omladinac.DatumRodjenja = DateTime.ParseExact(datumRodjString, formatDatum, CultureInfo.InvariantCulture);
                
                Communication.Instance.UpdateOmladinac(omladinac);
                MessageBox.Show("Uspešno ste izmenili omladinca!");
                ClearTable(dgvOmladinci);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        internal void DeleteOmladinac(DataGridView dgvOmladinci, TextBox txtIme, TextBox txtPrezime, TextBox txtJMBG, TextBox txtBrRacuna, TextBox txtBrTelefona, TextBox txtDatumRodjenja)
        {
            try
            {
                Communication.Instance.DeleteOmladinac(omladinac);
                MessageBox.Show("Uspešno ste obrisali omladinca!");
                ClearTable(dgvOmladinci);
                UCHelper.ResetFields(txtIme, txtPrezime, txtJMBG, txtBrRacuna, txtBrTelefona, txtDatumRodjenja);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void ClearTable(DataGridView dgvOmladinci)
        {
            dgvOmladinci.DataSource = null;
            dgvOmladinci.Rows.Clear();

        }

        internal void AddPoslodavac(TextBox txtNaziv, TextBox txtPIB, TextBox txtAdresa, TextBox txtEmail, TextBox txtBrTelefona)
        {
            if (!UCHelper.EmptyFieldValidation(txtNaziv)  | !UCHelper.EmptyFieldValidation(txtPIB) | !UCHelper.EmptyFieldValidation(txtAdresa) | !UCHelper.EmptyFieldValidation(txtEmail) |
                 !UCHelper.EmptyFieldValidation(txtBrTelefona) | !UCHelper.AllNumberValidation(txtPIB) | !UCHelper.AllNumberValidation(txtBrTelefona)
                 | !UCHelper.EmailValidation(txtEmail))
            {
                MessageBox.Show("Podaci nisu ispravno uneti!");
                return;
            }

            try
            {
                Poslodavac poslodavac = new Poslodavac
                {
                    Naziv = txtNaziv.Text,
                    PIB = txtPIB.Text,
                    Adresa = txtAdresa.Text,
                    Email = txtEmail.Text,
                    BrojTelefona = txtBrTelefona.Text
                };
                Communication.Instance.AddPoslodavac(poslodavac);
                MessageBox.Show("Uspešno ste dodali poslodavca!");
                UCHelper.ResetFields(txtNaziv, txtPIB, txtAdresa, txtEmail, txtBrTelefona);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        internal void SearchPoslodavac(TextBox txtFilter, UCChangePoslodavac userControl)
        {
            try
            {
                Poslodavac p = new Poslodavac();
                p.Uslov = $"Naziv like '%{txtFilter.Text}%' or PIB like '%{txtFilter.Text}%' or Adresa like '%{txtFilter.Text}%' or Email like '%{txtFilter.Text}%' or BrojTelefona like '%{txtFilter.Text}%'";
                List<Poslodavac> poslodavci = Communication.Instance.SearchPoslodavac(p);
                userControl.DgvPoslodavci.DataSource = poslodavci;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private Poslodavac poslodavac;
        internal void PrikaziPoslodavca(DataGridView dgvPoslodavci, TextBox txtNaziv, TextBox txtPIB, TextBox txtAdresa, TextBox txtEmail, TextBox txtBrTelefona)
        {
            if (dgvPoslodavci.SelectedRows.Count == 0 || (Poslodavac)dgvPoslodavci.SelectedRows[0].DataBoundItem == null)
            {
                MessageBox.Show("Niste izabrali ni jednog poslodavca!");
                return;
            }
            poslodavac = (Poslodavac)dgvPoslodavci.SelectedRows[0].DataBoundItem;
            txtNaziv.Text = poslodavac.Naziv;
            txtPIB.Text = poslodavac.PIB;
            txtAdresa.Text = poslodavac.Adresa;
            txtEmail.Text = poslodavac.Email;
            txtBrTelefona.Text = poslodavac.BrojTelefona;
        }

        internal void UpdatePoslodavac(DataGridView dgvPoslodavci, TextBox txtNaziv, TextBox txtPIB, TextBox txtAdresa, TextBox txtEmail, TextBox txtBrTelefona)
        {
            if (!UCHelper.EmptyFieldValidation(txtNaziv) | !UCHelper.EmptyFieldValidation(txtPIB) | !UCHelper.EmptyFieldValidation(txtAdresa) | !UCHelper.EmptyFieldValidation(txtEmail) |
                 !UCHelper.EmptyFieldValidation(txtBrTelefona) | !UCHelper.AllNumberValidation(txtPIB) | !UCHelper.AllNumberValidation(txtBrTelefona)
                 | !UCHelper.EmailValidation(txtEmail))
            {
                MessageBox.Show("Podaci nisu ispravno uneti!");
                return;
            }
            try
            {
                poslodavac.Naziv = txtNaziv.Text;
                poslodavac.PIB = txtPIB.Text;
                poslodavac.Adresa = txtAdresa.Text;
                poslodavac.Email = txtEmail.Text;
                poslodavac.BrojTelefona = txtBrTelefona.Text;

                Communication.Instance.UpdatePoslodavac(poslodavac);
                MessageBox.Show("Uspešno ste izmenili poslodavca!");
                ClearTable(dgvPoslodavci);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        internal void DeletePoslodavac(DataGridView dgvPoslodavci, TextBox txtNaziv, TextBox txtPIB, TextBox txtAdresa, TextBox txtEmail, TextBox txtBrTelefona)
        {
            try
            {
                Communication.Instance.DeletePoslodavac(poslodavac);
                MessageBox.Show("Uspešno ste obrisali poslodavca!");
                ClearTable(dgvPoslodavci);
                UCHelper.ResetFields(txtNaziv, txtPIB, txtAdresa, txtEmail, txtBrTelefona);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void LoadComboBox(ComboBox cbPoslodavac, ComboBox cbTipPosla)
        {
            try
            {
                cbPoslodavac.DataSource = Communication.Instance.GetPoslodavci();
                cbPoslodavac.SelectedItem = null;
                cbTipPosla.DataSource = Communication.Instance.GetTipPoslova();
                cbTipPosla.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void AddPosao(TextBox txtLokacija, TextBox txtSat, TextBox txtCenaRS, TextBox txtBrOml, ComboBox cbPoslodavac, ComboBox cbTipPosla)
        {
            if (!UCHelper.EmptyFieldValidation(txtLokacija) | !UCHelper.EmptyFieldValidation(txtSat) | !UCHelper.EmptyFieldValidation(txtCenaRS) | !UCHelper.EmptyFieldValidation(txtBrOml)
                  | !UCHelper.AllNumberValidation(txtCenaRS) | !UCHelper.AllNumberValidation(txtSat) | !UCHelper.AllNumberValidation(txtBrOml) | !UCHelper.ComboBoxValidation(cbPoslodavac) | !UCHelper.ComboBoxValidation(cbTipPosla))
            {
                MessageBox.Show("Podaci nisu ispravno uneti!");
                return;
            }
            Posao posao = new Posao
            {
                Lokacija = txtLokacija.Text,
                Satnica = int.Parse(txtSat.Text),
                CenaRadnogSata = decimal.Parse(txtCenaRS.Text),
                BrojOmladinaca = int.Parse(txtBrOml.Text),
                Poslodavac = (Poslodavac)cbPoslodavac.SelectedItem,
                TipPosla = (TipPosla)cbTipPosla.SelectedItem
            };
            Communication.Instance.AddPosao(posao);
            MessageBox.Show("Uspešno ste dodali posao!");
            UCHelper.ResetFields(txtLokacija, txtSat, txtCenaRS, txtBrOml);
            UCHelper.ResetComboBox(cbPoslodavac, cbTipPosla);
        }

        internal void SearchPosao(TextBox txtFilter, UCChangePosao userControl)
        {
            
            try
            {
                Posao p = new Posao();
                p.Uslov = $"posao.lokacija like '%{txtFilter.Text}%' or posao.satnica like '%{txtFilter.Text}%' or posao.cenaradnogsata like '%{txtFilter.Text}%' or p.Naziv like '%{txtFilter.Text}%' or tp.Naziv like '%{txtFilter.Text}%'";
                List<Posao> poslovi = Communication.Instance.SearchPosao(p);
                userControl.DgvOmladinci.DataSource = poslovi;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        internal List<Omladinac> GetOmladinci()
        {
            return Communication.Instance.GetOmladinci();
        }

        internal List<Posao> GetPoslovi()
        {
            return Communication.Instance.GetPoslovi();
        }

        internal object GetPoslodavci()
        {
            return Communication.Instance.GetPoslodavci();
        }
    }
}

