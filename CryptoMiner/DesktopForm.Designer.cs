namespace CryptoMiner
{
    partial class DesktopForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopForm));
            this.thisPCButton = new System.Windows.Forms.PictureBox();
            this.crownContextMenuStrip1 = new ReaLTaiizor.Controls.CrownContextMenuStrip();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cryptoMinerButton = new System.Windows.Forms.PictureBox();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.cryptoWalletButton = new System.Windows.Forms.PictureBox();
            this.shutdownButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.thisPCButton)).BeginInit();
            this.crownContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cryptoMinerButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cryptoWalletButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shutdownButton)).BeginInit();
            this.SuspendLayout();
            // 
            // thisPCButton
            // 
            this.thisPCButton.BackColor = System.Drawing.Color.Transparent;
            this.thisPCButton.ContextMenuStrip = this.crownContextMenuStrip1;
            this.thisPCButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thisPCButton.Image = ((System.Drawing.Image)(resources.GetObject("thisPCButton.Image")));
            this.thisPCButton.Location = new System.Drawing.Point(12, 26);
            this.thisPCButton.Name = "thisPCButton";
            this.thisPCButton.Size = new System.Drawing.Size(71, 63);
            this.thisPCButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thisPCButton.TabIndex = 1;
            this.thisPCButton.TabStop = false;
            // 
            // crownContextMenuStrip1
            // 
            this.crownContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.crownContextMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesToolStripMenuItem});
            this.crownContextMenuStrip1.Name = "crownContextMenuStrip1";
            this.crownContextMenuStrip1.Size = new System.Drawing.Size(128, 26);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.propertiesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // cryptoMinerButton
            // 
            this.cryptoMinerButton.BackColor = System.Drawing.Color.Transparent;
            this.cryptoMinerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cryptoMinerButton.Image = ((System.Drawing.Image)(resources.GetObject("cryptoMinerButton.Image")));
            this.cryptoMinerButton.Location = new System.Drawing.Point(12, 104);
            this.cryptoMinerButton.Name = "cryptoMinerButton";
            this.cryptoMinerButton.Size = new System.Drawing.Size(71, 63);
            this.cryptoMinerButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cryptoMinerButton.TabIndex = 2;
            this.cryptoMinerButton.TabStop = false;
            this.cryptoMinerButton.DoubleClick += new System.EventHandler(this.cryptoMinerButton_DoubleClick);
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.Transparent;
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(1280, 20);
            this.dragPanel.TabIndex = 3;
            this.dragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseMove);
            // 
            // cryptoWalletButton
            // 
            this.cryptoWalletButton.BackColor = System.Drawing.Color.Transparent;
            this.cryptoWalletButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cryptoWalletButton.Image = ((System.Drawing.Image)(resources.GetObject("cryptoWalletButton.Image")));
            this.cryptoWalletButton.Location = new System.Drawing.Point(12, 181);
            this.cryptoWalletButton.Name = "cryptoWalletButton";
            this.cryptoWalletButton.Size = new System.Drawing.Size(71, 63);
            this.cryptoWalletButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cryptoWalletButton.TabIndex = 5;
            this.cryptoWalletButton.TabStop = false;
            // 
            // shutdownButton
            // 
            this.shutdownButton.BackColor = System.Drawing.Color.Transparent;
            this.shutdownButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shutdownButton.Image = ((System.Drawing.Image)(resources.GetObject("shutdownButton.Image")));
            this.shutdownButton.Location = new System.Drawing.Point(0, 696);
            this.shutdownButton.Name = "shutdownButton";
            this.shutdownButton.Size = new System.Drawing.Size(29, 24);
            this.shutdownButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shutdownButton.TabIndex = 6;
            this.shutdownButton.TabStop = false;
            this.shutdownButton.Click += new System.EventHandler(this.shutdownButton_Click);
            // 
            // DesktopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.shutdownButton);
            this.Controls.Add(this.cryptoWalletButton);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.cryptoMinerButton);
            this.Controls.Add(this.thisPCButton);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DesktopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)(this.thisPCButton)).EndInit();
            this.crownContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cryptoMinerButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cryptoWalletButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shutdownButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox thisPCButton;
        private System.Windows.Forms.PictureBox cryptoMinerButton;
        private System.Windows.Forms.Panel dragPanel;
        private ReaLTaiizor.Controls.CrownContextMenuStrip crownContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.PictureBox cryptoWalletButton;
        private System.Windows.Forms.PictureBox shutdownButton;
    }
}

