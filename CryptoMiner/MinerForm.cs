using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace CryptoMiner
{
    public partial class MinerForm : Form
    {
        public MinerForm()
        {
            InitializeComponent();
        }
        //Variables
        string welcomeString = File.ReadAllText(@"./welcomestring.txt");
        string typeWriteString;
        bool firstStart = true;
        int typeWriteIndex = 0;
        bool tutorial;

        public bool isMining;
        public double cryptoWallet;
        public List<string> miningRigStats = new List<string>();
        public double hashRate = 40;
        public double tenthCoinHashCost = 1200;
        public double hashes;
        private void MinerForm_Load(object sender, EventArgs e)
        {
            SaveSettings saveSettings = new SaveSettings();
            List<string> settings = File.ReadAllLines(@"./settings.txt").ToList();
            List<string> settings2 = new List<string>();
            foreach(string s in settings)
            {
                List<string> temp = s.Split(';').ToList();
                settings2.Add(temp[1]);
            }
            if (settings2[0] == "False") { tutorial = false; saveSettings.tutorial = "False"; }
            else { tutorial = true; saveSettings.tutorial = "True"; }
            timer1.Interval = 40;
            timer1.Start();
        }
        private void TypeWriteInConsole(string stringToWrite)
        {
            minerConsoleBox.ReadOnly = true;
            typeWriteString = stringToWrite;
            minerConsoleBox.Text = "";
            timer2.Interval = 40;
            timer2.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {          
            if(tutorial == true)
            {
                if (firstStart == true)
                {
                    
                    minerConsoleBox.Text += welcomeString[typeWriteIndex];
                    typeWriteIndex++;
                    if (typeWriteIndex == welcomeString.Length)
                    {
                        firstStart = false;
                        minerConsoleBox.ReadOnly = false;
                        typeWriteIndex = 0;
                    }
                }
                else
                {
                    minerConsoleBox.ReadOnly = false;
                }
            }
            else
            {
                minerConsoleBox.ReadOnly = false;
            }
        }

        private void minerConsoleBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                if(minerConsoleBox.Text.Contains("Miner.Start();"))
                {
                    minerConsoleBox.Text = "";
                    isMining = true;
                    TypeWriteInConsole("Miner is starting...");
                    minerTimer.Start();
                }
                else if (minerConsoleBox.Text.Contains("Miner.Stop();"))
                {
                    minerConsoleBox.Text = "";
                    isMining = false;
                    TypeWriteInConsole("Miner is stopping...");
                    minerTimer.Stop();
                }
                else if(minerConsoleBox.Text.Contains("Console.Tutorial();"))
                {
                    if (tutorial == true) { tutorial = false; }
                    else { tutorial = true; }
                    var savesettings = new SaveSettings();
                    savesettings.tutorial = this.tutorial.ToString();
                    savesettings.WriteSettingsFile();
                    TypeWriteInConsole("Intro toggled");
                }
                else if(minerConsoleBox.Text.Contains("Console.Close();"))
                {
                    MinerForm minerForm = new MinerForm();
                    SaveSettings saveSettings = new SaveSettings();
                    saveSettings.tutorial = this.tutorial.ToString();
                    saveSettings.cryptoWallet = this.cryptoWallet;
                    saveSettings.WriteSettingsFile();
                    minerConsoleBox.Text = "";
                    TypeWriteInConsole("Goodbye ;)");
                    minerTimer.Stop();
                    isMining = false;
                    this.Close();
                }
                else if (minerConsoleBox.Text.Contains("Console.Help();"))
                {
                    List<string> commandList = File.ReadLines(@"./commands.txt").ToList();
                    string commandlist = "";
                    foreach(string command in commandList)
                    {
                        commandlist += command;
                        commandlist += Environment.NewLine;
                    }
                    minerConsoleBox.Text = "";
                    isMining = false;
                    TypeWriteInConsole(commandlist);
                }
                else if(minerConsoleBox.Text.Contains("Miner.Status();"))
                {
                    minerConsoleBox.Text = "";
                    minerConsoleBox.Text = "Miner : " + tutorial.ToString();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            minerConsoleBox.Text += typeWriteString[typeWriteIndex];
            typeWriteIndex++;
            if (typeWriteIndex == typeWriteString.Length)
            {
                timer2.Stop();
                minerConsoleBox.ReadOnly = false;
                typeWriteIndex = 0;
            }
        }

        private void minerTimer_Tick(object sender, EventArgs e)
        {
            if(isMining == true)
            {
                hashes += hashRate;  
                if(hashes > tenthCoinHashCost)
                {
                    MessageBox.Show(hashes.ToString());
                    hashes = 0;
                    cryptoWallet += 0.000001;
                }
            }
        }
    }
}
