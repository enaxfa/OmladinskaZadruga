using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server server;
        public FrmServer()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            server = new Server();
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            txtStanjeServera.Text = "Server nije pokrenut";
            txtStanjeServera.BackColor = Color.LightCoral;
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            try
            {
                server.Connect();
                Thread nitServer = new Thread(server.Listen);
                nitServer.IsBackground = true;
                nitServer.Start();
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
                txtStanjeServera.Text = "Server je pokrenut";
                txtStanjeServera.BackColor = Color.LightGreen;
            }
            catch (SocketException ex)
            {

                MessageBox.Show("Neuspesno pokretanje servera!" + ex.Message);
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            server.Stop();
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            txtStanjeServera.Text = "Server nije pokrenut";
            txtStanjeServera.BackColor = Color.LightCoral;
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
