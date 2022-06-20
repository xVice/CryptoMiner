using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoMiner
{
    public partial class MainRoom : Form
    {
        public MainRoom()
        {
            InitializeComponent();
        }

        private void serverroom_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DesktopForm deskForm = new DesktopForm();
            deskForm.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SaveSettings.Load();
        }
    }
}
