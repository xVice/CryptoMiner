using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoMiner
{
    public partial class DesktopForm : Form
    {
        public DesktopForm()
        {
            InitializeComponent();
        }

        //Variables
        [DllImport("user32")]
        private static extern bool ReleaseCapture();
        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);
        private void dragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 161, 2, 0);
            }
        }

        private void cryptoMinerButton_DoubleClick(object sender, EventArgs e)
        {
            MinerForm minerform = new MinerForm();
            minerform.Show();           
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComputerStatsForm computerStatsForm = new ComputerStatsForm();
            computerStatsForm.Show();
        }

        private void shutdownButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cryptoMinerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
