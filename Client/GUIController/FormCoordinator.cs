﻿using Client.Controller;
using Client.UserControls.Angazovanje;
using Client.UserControls.Omladinac;
using Client.UserControls.Posao;
using Client.UserControls.Poslodavac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUIController
{
    internal class FormCoordinator
    {
        private FrmMain frmMain;
        private FrmLogin frmLogin;
        private static FormCoordinator instance;
        public static FormCoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormCoordinator();
                }
                return instance;
            }
        }
        private FormCoordinator()
        {
            frmLogin = new FrmLogin();
        }

        
        internal void ShowFrmMain(String ime, String prezime)
        {
            frmMain = new FrmMain(ime, prezime);
            frmMain.FormBorderStyle = FormBorderStyle.FixedDialog;
            frmLogin.Visible = false;
            frmMain.ShowDialog();
            frmLogin.Dispose();
        }

        internal void ShowFrmLogin()
        {
            frmLogin.AutoSize = true;
            Application.Run(frmLogin);
        }

        internal void OpenUCAddOmladinac()
        {
            frmMain.SetPanel(new UCAddOmladinac());
        }

        internal void OpenUCChangeOmladinac()
        {
            frmMain.SetPanel(new UCChangeOmladinac());
        }

        internal void OpenUCAddPoslodavac()
        {
            frmMain.SetPanel(new UCAddPoslodavac());
        }

        internal void OpenUCChangePoslodavac()
        {
            frmMain.SetPanel(new UCChangePoslodavac());
        }

        internal void OpenUCAddPosao()
        {
            frmMain.SetPanel(new UCAddPosao());
            
        }

        internal void OpenUCAddAngazovanje()
        {
            frmMain.SetPanel(new UCAddAngazovanje());
        }

        internal void OpenUCChangeAngazovanje()
        {
            frmMain.SetPanel(new UCChangeAngazovanje());
        }
    }
}
