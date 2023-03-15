using Client.Helpers;
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
                MessageBox.Show("Uspešno ste sacuvali omladinca!");
                UCHelper.ResetFields(txtIme, txtPrezime, txtJMBG, txtDatumRodjenja, txtBrRacuna, txtBrTelefona);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        internal List<Omladinac> SearchOmladinac(TextBox txtFilter)
        {
            
            try
            {
                Omladinac o = new Omladinac();
                o.Uslov = $"Ime like '%{txtFilter.Text}%' or Prezime like '%{txtFilter.Text}%' or JMBG like '%{txtFilter.Text}%' or BrojTelefona like '%{txtFilter.Text}%' or BrojRacuna like '%{txtFilter.Text}%' or DatumRodjenja like '%{txtFilter.Text}%'";
                return Communication.Instance.SearchOmladinac(o);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
            
        }

        internal void PrikaziOmladinca(DataGridView dgvOmladinci, TextBox txtIme, TextBox txtPrezime, TextBox txtJMBG, TextBox txtBrRacuna, TextBox txtBrTelefona, TextBox txtDatumRodjenja)
        {
            if (dgvOmladinci.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali ni jednog omladinca!");
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
            try
            {
                String datumRodjString = txtDatumRodjenja.Text;
                String formatDatum = "yyyy-MM-dd";
                Omladinac omladinac = (Omladinac)dgvOmladinci.SelectedRows[0].DataBoundItem;
                omladinac.Ime = txtIme.Text;
                omladinac.Prezime = txtPrezime.Text;
                omladinac.JMBG = txtJMBG.Text;
                omladinac.BrojTelefona = txtBrTelefona.Text;
                omladinac.BrojRacuna = txtBrRacuna.Text;
                omladinac.DatumRodjenja = DateTime.ParseExact(datumRodjString, formatDatum, CultureInfo.InvariantCulture);
                
                Communication.Instance.UpdateOmladinac(omladinac);
                MessageBox.Show("Uspešno ste izmenili omladinca!");
                dgvOmladinci.DataSource = GetOmladinci();
                dgvOmladinci.ClearSelection();
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
                Omladinac omladinac = (Omladinac)dgvOmladinci.SelectedRows[0].DataBoundItem;
                Communication.Instance.DeleteOmladinac(omladinac);
                MessageBox.Show("Uspešno ste obrisali omladinca!");
                dgvOmladinci.DataSource = GetOmladinci();
                dgvOmladinci.ClearSelection();
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
                    Kontakt = txtBrTelefona.Text
                };
                Communication.Instance.AddPoslodavac(poslodavac);
                MessageBox.Show("Uspešno ste sacuvali poslodavca!");
                UCHelper.ResetFields(txtNaziv, txtPIB, txtAdresa, txtEmail, txtBrTelefona);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        internal List<Poslodavac> SearchPoslodavac(TextBox txtFilter)
        {
            try
            {
                Poslodavac p = new Poslodavac();
                p.Uslov = $"Naziv like '%{txtFilter.Text}%' or PIB like '%{txtFilter.Text}%' or Adresa like '%{txtFilter.Text}%' or Email like '%{txtFilter.Text}%' or BrojTelefona like '%{txtFilter.Text}%'";
                return Communication.Instance.SearchPoslodavac(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        
        internal void PrikaziPoslodavca(DataGridView dgvPoslodavci, TextBox txtNaziv, TextBox txtPIB, TextBox txtAdresa, TextBox txtEmail, TextBox txtBrTelefona)
        {
            if (dgvPoslodavci.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali ni jednog poslodavca!");
                return;
            }
            Poslodavac poslodavac = (Poslodavac)dgvPoslodavci.SelectedRows[0].DataBoundItem;
            txtNaziv.Text = poslodavac.Naziv;
            txtPIB.Text = poslodavac.PIB;
            txtAdresa.Text = poslodavac.Adresa;
            txtEmail.Text = poslodavac.Email;
            txtBrTelefona.Text = poslodavac.Kontakt;
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
                Poslodavac poslodavac = (Poslodavac)dgvPoslodavci.SelectedRows[0].DataBoundItem;
                poslodavac.Naziv = txtNaziv.Text;
                poslodavac.PIB = txtPIB.Text;
                poslodavac.Adresa = txtAdresa.Text;
                poslodavac.Email = txtEmail.Text;
                poslodavac.Kontakt = txtBrTelefona.Text;

                Communication.Instance.UpdatePoslodavac(poslodavac);
                dgvPoslodavci.DataSource = GetPoslodavci();
                dgvPoslodavci.ClearSelection();
                MessageBox.Show("Uspešno ste izmenili poslodavca!");

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
                Poslodavac poslodavac = (Poslodavac)dgvPoslodavci.SelectedRows[0].DataBoundItem;
                Communication.Instance.DeletePoslodavac(poslodavac);
                dgvPoslodavci.DataSource = GetPoslodavci();
                dgvPoslodavci.ClearSelection();
                MessageBox.Show("Uspešno ste obrisali poslodavca!");
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
                cbPoslodavac.SelectedIndex = -1;
                cbPoslodavac.Text = "Izaberite poslodavca";
                cbTipPosla.DataSource = Communication.Instance.GetTipPoslova();
                cbTipPosla.SelectedIndex = -1;
                cbTipPosla.Text = "Izaberite tip posla";
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
            try
            {
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
                LoadComboBox(cbPoslodavac, cbTipPosla);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        internal List<Posao> SearchPosao(TextBox txtFilter)
        {
            
            try
            {
                Posao p = new Posao();
                p.Uslov = $"posao.lokacija like '%{txtFilter.Text}%' or posao.satnica like '%{txtFilter.Text}%' or posao.cenaradnogsata like '%{txtFilter.Text}%'" +
                    $" or posao.brojomladinaca like '%{txtFilter.Text}%' or p.Naziv like '%{txtFilter.Text}%' or tp.Naziv like '%{txtFilter.Text}%'";
                return Communication.Instance.SearchPosao(p);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
            
        }

        internal List<Omladinac> GetOmladinci()
        {
            try
            {
                return Communication.Instance.GetOmladinci();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }

        internal List<Posao> GetPoslovi()
        {
            try
            {
                return Communication.Instance.GetPoslovi();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }

        internal List<Poslodavac> GetPoslodavci()
        {
            try
            {
                return Communication.Instance.GetPoslodavci();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }
        }

        private int brojOmladinaca;
        internal string VratiBrojOmladinacaZaPosao(DataGridView dgvPoslovi, DataGridView dgvOmladinci)
        {
            Posao posao = (Posao)dgvPoslovi.SelectedRows[0].DataBoundItem;
            brojOmladinaca = posao.BrojOmladinaca;
            if (dgvOmladinci.SelectedRows.Count > 0)
                return VratiBrojPreostalihOmladinaca(dgvOmladinci);
            return brojOmladinaca.ToString();
        }

        internal string VratiBrojPreostalihOmladinaca(DataGridView dgvOmladinci)
        {
            int brojPreostalihOmladinaca = brojOmladinaca - dgvOmladinci.SelectedRows.Count;
            if (brojPreostalihOmladinaca < 0)
                return "/";
            return brojPreostalihOmladinaca.ToString();
        }

        internal void AddAngazovanje(DataGridView dgvPoslovi, DataGridView dgvOmladinci, DateTimePicker dtpDatumAngazovanja, Label lblBrOml)
        {
            if (dgvPoslovi.SelectedRows.Count == 0 | dgvOmladinci.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali posao ili omladince!");
                return;
            }
            if(dgvPoslovi.SelectedRows.Count > 1)
            {
                MessageBox.Show("Izaberite samo jedan posao za koji unosite angazovanje");
                return;
            }
            if(lblBrOml.Text == "/")
            {
                MessageBox.Show("Izabrali ste vise omladinaca nego sto je potrebno za ovaj posao");
                return;
            }
            try
            {
                String datum = dtpDatumAngazovanja.Value.Date.ToString("yyyy-MM-dd");
                List<Omladinac> omladinci = new List<Omladinac>();
                foreach (DataGridViewRow row in dgvOmladinci.SelectedRows)
                    omladinci.Add((Omladinac)row.DataBoundItem);
                Posao posao = (Posao)dgvPoslovi.SelectedRows[0].DataBoundItem;
                List<Angazovanje> angazovanja = new List<Angazovanje>();
                foreach (Omladinac o in omladinci)
                {
                    Angazovanje a = new Angazovanje
                    {
                        Posao = posao,
                        Omladinac = o,
                        DatumAngazovanja = Convert.ToDateTime(datum)
                    };
                    angazovanja.Add(a);
                }
                Communication.Instance.AddAngazovanja(angazovanja);
                posao.BrojOmladinaca -= omladinci.Count;
                Communication.Instance.UpdatePosao(posao);
                dgvOmladinci.ClearSelection();
                dgvPoslovi.ClearSelection();
                MessageBox.Show("Uspesno ste sacuvali angazovanja");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        internal List<Angazovanje> GetAngazovanja()
        {
            try
            {
                return Communication.Instance.GetAngazovanja();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }

        internal List<Angazovanje> SearchAngazovanja(TextBox txtFilter)
        {
            try
            {
                Angazovanje a = new Angazovanje();
                a.Uslov = $"o.ime like '%{txtFilter.Text}%' or o.prezime like '%{txtFilter.Text}%' or p.naziv like '%{txtFilter.Text}%'" +
                    $" or tp.naziv like '%{txtFilter.Text}%' or a.datum like '%{txtFilter.Text}%'";
                return Communication.Instance.SearchAngazovanje(a);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }

       

        internal void PrikaziAngazovanje(DataGridView dgvAngazovanja, TextBox txtImeOmladinca, TextBox txtBrTelOml, TextBox txtBrRacOml, TextBox txtDatumRodj, TextBox txtPosao, TextBox txtPoslodavac, TextBox txtSatnica, TextBox txtCenaRS, TextBox txtBrOml, DateTimePicker dtpDatumAngazovanja)
        {
            if (dgvAngazovanja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali ni jedno angazovanje!");
                return;
            }
            Angazovanje angazovanje = (Angazovanje)dgvAngazovanja.SelectedRows[0].DataBoundItem;
            txtImeOmladinca.Text = angazovanje.Omladinac.ToString();
            txtBrTelOml.Text = angazovanje.Omladinac.BrojTelefona;
            txtBrRacOml.Text = angazovanje.Omladinac.BrojRacuna;
            txtDatumRodj.Text = angazovanje.Omladinac.DatumRodjenja.ToString("yyyy-MM-dd");
            txtPosao.Text = angazovanje.Posao.TipPosla.Naziv;
            txtPoslodavac.Text = angazovanje.Posao.Poslodavac.Naziv;
            txtSatnica.Text = angazovanje.Posao.Satnica.ToString();
            txtCenaRS.Text = angazovanje.Posao.CenaRadnogSata.ToString();
            txtBrOml.Text = angazovanje.Posao.BrojOmladinaca.ToString();
            dtpDatumAngazovanja.Value = angazovanje.DatumAngazovanja;
        }


        internal void PrikaziOmladinca(DataGridView dgvOmladinci, TextBox txtImeOmladinca, TextBox txtBrTelOml, TextBox txtBrRacOml, TextBox txtDatumRodj)
        {
            if (dgvOmladinci.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali ni jednog omladinca!");
                return;
            }
            Omladinac omladinac = (Omladinac)dgvOmladinci.SelectedRows[0].DataBoundItem;
            txtImeOmladinca.Text = omladinac.ToString();
            txtBrTelOml.Text = omladinac.BrojTelefona;
            txtBrRacOml.Text = omladinac.BrojRacuna;
            txtDatumRodj.Text = omladinac.DatumRodjenja.ToString("yyyy-MM-dd");
        }

        internal void UpdateAngazovanje(DataGridView dgvAngazovanja, DataGridView dgvOmladinci, DateTimePicker dtpDatumAngazovanja)
        {
            
            if (dgvAngazovanja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati angazovanje koje menjate!");
                return;
            }
            if (dgvOmladinci.SelectedRows.Count > 1)
            {
                MessageBox.Show("Izaberite samo jednog omladinca!");
                return;
            }
            if (dgvAngazovanja.SelectedRows.Count > 1)
            {
                MessageBox.Show("Izaberite samo jedno angazovanje!");
                return;
            }
            try
            {
                Angazovanje angazovanje = (Angazovanje)dgvAngazovanja.SelectedRows[0].DataBoundItem;
                if(dgvOmladinci.SelectedRows.Count == 1)
                    angazovanje.Omladinac = (Omladinac)dgvOmladinci.SelectedRows[0].DataBoundItem;
                String datum = dtpDatumAngazovanja.Value.Date.ToString("yyyy-MM-dd");
                angazovanje.DatumAngazovanja = Convert.ToDateTime(datum);
                Communication.Instance.UpdateAngazovanje(angazovanje);
                dgvAngazovanja.DataSource = Communication.Instance.GetAngazovanja();
                dgvOmladinci.ClearSelection();
                dgvAngazovanja.ClearSelection();
                MessageBox.Show("Uspesno ste sacuvali angazovanje");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

