﻿using Client.Controller;
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
        private MainController mainController;
        private LoginController loginController;
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
            mainController = new MainController();
            loginController = new LoginController();
            
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

    }
}