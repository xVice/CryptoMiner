namespace CryptoMiner
{
    partial class ComputerStatsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.processorNameLabel = new System.Windows.Forms.Label();
            this.installedRAMLabel = new System.Windows.Forms.Label();
            this.systemTypeLabel = new System.Windows.Forms.Label();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.gpusListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Processor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Installed RAM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Systemtype";
            // 
            // processorNameLabel
            // 
            this.processorNameLabel.AutoSize = true;
            this.processorNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processorNameLabel.ForeColor = System.Drawing.Color.White;
            this.processorNameLabel.Location = new System.Drawing.Point(152, 25);
            this.processorNameLabel.Name = "processorNameLabel";
            this.processorNameLabel.Size = new System.Drawing.Size(115, 19);
            this.processorNameLabel.TabIndex = 3;
            this.processorNameLabel.Text = "ProcessorName";
            // 
            // installedRAMLabel
            // 
            this.installedRAMLabel.AutoSize = true;
            this.installedRAMLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installedRAMLabel.ForeColor = System.Drawing.Color.White;
            this.installedRAMLabel.Location = new System.Drawing.Point(152, 50);
            this.installedRAMLabel.Name = "installedRAMLabel";
            this.installedRAMLabel.Size = new System.Drawing.Size(97, 19);
            this.installedRAMLabel.TabIndex = 4;
            this.installedRAMLabel.Text = "InstalledRAM";
            // 
            // systemTypeLabel
            // 
            this.systemTypeLabel.AutoSize = true;
            this.systemTypeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemTypeLabel.ForeColor = System.Drawing.Color.White;
            this.systemTypeLabel.Location = new System.Drawing.Point(152, 74);
            this.systemTypeLabel.Name = "systemTypeLabel";
            this.systemTypeLabel.Size = new System.Drawing.Size(88, 19);
            this.systemTypeLabel.TabIndex = 5;
            this.systemTypeLabel.Text = "SystemType";
            // 
            // dragPanel
            // 
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(287, 22);
            this.dragPanel.TabIndex = 6;
            this.dragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Installed GPUs";
            // 
            // gpusListBox
            // 
            this.gpusListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gpusListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gpusListBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpusListBox.ForeColor = System.Drawing.Color.White;
            this.gpusListBox.FormattingEnabled = true;
            this.gpusListBox.ItemHeight = 19;
            this.gpusListBox.Location = new System.Drawing.Point(129, 107);
            this.gpusListBox.Name = "gpusListBox";
            this.gpusListBox.Size = new System.Drawing.Size(147, 323);
            this.gpusListBox.TabIndex = 8;
            // 
            // ComputerStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(288, 455);
            this.Controls.Add(this.gpusListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.systemTypeLabel);
            this.Controls.Add(this.installedRAMLabel);
            this.Controls.Add(this.processorNameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComputerStatsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ComputerStatsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label processorNameLabel;
        private System.Windows.Forms.Label installedRAMLabel;
        private System.Windows.Forms.Label systemTypeLabel;
        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox gpusListBox;
    }
}