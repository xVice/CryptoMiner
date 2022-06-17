using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoMiner
{
    public partial class ComputerStatsForm : Form
    {
        public ComputerStatsForm()
        {
            InitializeComponent();
        }
        //Variables
        [DllImport("user32")]
        private static extern bool ReleaseCapture();
        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);

        string processorName;
        string installedRAM;
        string systemType;
        List<string> installedGPUs = new List<string>();

        private void dragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 161, 2, 0);
            }
        }

        private void ComputerStatsForm_Load(object sender, EventArgs e)
        {
            gpusListBox.SelectedIndex = -1;
            processorNameLabel.Text = processorName;
            installedRAMLabel.Text = installedRAM;
            systemTypeLabel.Text = systemType;
            foreach(string line in installedGPUs)
            {
                gpusListBox.Items.Add(line);
            }
        }
    }
}
