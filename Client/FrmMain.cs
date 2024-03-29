﻿using Client.Controller;
using Client.GUIController;
using Client.UserControls.Omladinac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmMain : Form
    {
        private MainController mainController = new MainController();
        

        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(string ime, string prezime)
        {
            InitializeComponent();
            lblAdministrator.Text = ime + " " + prezime;
        }

       
        internal void SetPanel(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            userControl.Parent = pnlMain;
            userControl.Dock = DockStyle.Fill;
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCoordinator.Instance.OpenUCAddOmladinac();
        }

        private void izmeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCoordinator.Instance.OpenUCChangeOmladinac();
        }

        private void dodajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCoordinator.Instance.OpenUCAddPoslodavac();
        }

        private void izmeniToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCoordinator.Instance.OpenUCChangePoslodavac();
        }

        private void dodajToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormCoordinator.Instance.OpenUCAddPosao();
        }

        private void dodajToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormCoordinator.Instance.OpenUCAddAngazovanje();
        }

        private void izmeniToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormCoordinator.Instance.OpenUCChangeAngazovanje();
        }
    }
}
