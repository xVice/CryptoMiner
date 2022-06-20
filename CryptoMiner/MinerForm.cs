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
using CryptoMiner.ConsoleCommands;
using CryptoMiner.ConsoleCommands.Commands;

namespace CryptoMiner
{
    public partial class MinerForm : Form
    {
        public MinerForm()
        {
            InitializeComponent();
        }
        //Variables
        string welcomeString = "Moino servus";  //File.ReadAllText(@"./welcomestring.txt");
        string typeWriteString;
        bool firstStart = true;
        int typeWriteIndex = 0;
        bool tutorial;

        public double cryptoWallet;

        public Wallet.Wallet wallet = new Wallet.Wallet();
        public Miner.Miner miner;

        public List<string> miningRigStats = new List<string>();
        public double hashRate = 40;
        public double tenthCoinHashCost = 1200;
        public double hashes;
        private void MinerForm_Load(object sender, EventArgs e)
        {
            CommandManager.LoadDefaultCommands();
            miner = new Miner.Miner(wallet, 40);
            tutorial = SaveSettings._settings.tutorialFinished;
            cryptoWallet = SaveSettings._settings.cryptoWallet;
            timer1.Interval = 40;
            timer1.Start();
        }

        public void TypeWriteInConsole(string stringToWrite)
        {
            minerConsoleBox.ReadOnly = true;
            typeWriteString = stringToWrite;
            minerConsoleBox.Text = "";
            timer2.Interval = 40;
            timer2.Start();
        }

        public void Clear()
        {
            minerConsoleBox.Text = null;
        }

        public void SetText(string text)
        {
            minerConsoleBox.Text = text;
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
                if(CommandManager.GetCommandByName(minerConsoleBox.Text) != null)
                {
                    CommandManager.VerifyCommand(CommandManager.GetCommandByName(minerConsoleBox.Text), this);
                    minerConsoleBox.Text = "";
                }
                else
                {
                    TypeWriteInConsole("The Command " + minerConsoleBox.Text + " was not found!");
                }

                /*
                if (minerConsoleBox.Text.Contains("Miner.Start();"))
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
                    SaveSettings._settings.tutorialFinished = this.tutorial;
                    SaveSettings.Save();
                    TypeWriteInConsole("Intro toggled");
                }
                else if(minerConsoleBox.Text.Contains("Console.Close();"))
                {
                    MinerForm minerForm = new MinerForm();
                    SaveSettings._settings.tutorialFinished = this.tutorial;
                    SaveSettings._settings.cryptoWallet = this.cryptoWallet;
                    SaveSettings.Save();
                    minerConsoleBox.Text = "";
                    TypeWriteInConsole("Goodbye ;)");
                    minerTimer.Stop();
                    isMining = false;
                    this.Close();
                }
                */
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
    }
}
