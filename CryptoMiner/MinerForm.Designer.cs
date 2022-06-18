namespace CryptoMiner
{
    partial class MinerForm
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
            this.components = new System.ComponentModel.Container();
            this.minerConsoleBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.minerTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // minerConsoleBox
            // 
            this.minerConsoleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.minerConsoleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minerConsoleBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minerConsoleBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.minerConsoleBox.Location = new System.Drawing.Point(12, 12);
            this.minerConsoleBox.Multiline = true;
            this.minerConsoleBox.Name = "minerConsoleBox";
            this.minerConsoleBox.ReadOnly = true;
            this.minerConsoleBox.Size = new System.Drawing.Size(776, 426);
            this.minerConsoleBox.TabIndex = 0;
            this.minerConsoleBox.TextChanged += new System.EventHandler(this.minerConsoleBox_TextChanged);
            this.minerConsoleBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minerConsoleBox_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // minerTimer
            // 
            this.minerTimer.Interval = 1000;
            this.minerTimer.Tick += new System.EventHandler(this.minerTimer_Tick);
            // 
            // MinerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.minerConsoleBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MinerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MinerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox minerConsoleBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer minerTimer;
    }
}