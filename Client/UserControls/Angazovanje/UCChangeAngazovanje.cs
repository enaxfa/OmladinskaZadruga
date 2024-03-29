﻿using Client.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls.Angazovanje
{
    public partial class UCChangeAngazovanje : UserControl
    {
        private MainController mainController = new MainController();
        public UCChangeAngazovanje()
        {
            InitializeComponent();
            dgvAngazovanja.DataSource = mainController.GetAngazovanja();
            dgvOmladinci.DataSource = mainController.GetOmladinci();
            dgvAngazovanja.Columns[1].Width = 200;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dgvAngazovanja.DataSource = mainController.SearchAngazovanja(txtFilter);
        }

        private void dgvAngazovanja_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvOmladinci.ClearSelection();
            mainController.PrikaziAngazovanje(dgvAngazovanja,txtImeOmladinca,txtBrTelOml,txtBrRacOml,txtDatumRodj, txtPosao,txtPoslodavac,txtSatnica,txtCenaRS,txtBrOml,dtpDatumAngazovanja);
            
        }

        private void dgvOmladinci_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgvAngazovanja.SelectedRows.Count == 0)
            {
                MessageBox.Show("Prvo izaberite angazovanje koje menjate");
                dgvOmladinci.ClearSelection();
                return;
            }
            mainController.PrikaziOmladinca(dgvOmladinci, txtImeOmladinca, txtBrTelOml, txtBrRacOml, txtDatumRodj);
            mainController.SacuvajIzmene(dgvAngazovanja, dgvOmladinci, dtpDatumAngazovanja);
            btnIzmeni.Enabled = true;
        }

        private void txtFilterOml_TextChanged(object sender, EventArgs e)
        {
            dgvOmladinci.DataSource = mainController.SearchOmladinac(txtFilterOml);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            mainController.UpdateAngazovanje(dgvAngazovanja, dgvOmladinci, dtpDatumAngazovanja);
        }


        private void UCChangeAngazovanje_Load(object sender, EventArgs e)
        {
            dgvAngazovanja.ClearSelection();
            dgvOmladinci.ClearSelection();
        }

        private void dtpDatumAngazovanja_ValueChanged(object sender, EventArgs e)
        {
            mainController.SacuvajIzmene(dgvAngazovanja, dgvOmladinci, dtpDatumAngazovanja);
            btnIzmeni.Enabled = true;
        }
    }
}
