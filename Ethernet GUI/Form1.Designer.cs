namespace Ethernet_GUI
{
    partial class EthernetDEForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EthernetDEForm));
            this.DateSet = new System.Windows.Forms.DateTimePicker();
            this.EnableCheck = new System.Windows.Forms.CheckBox();
            this.DisableCheck = new System.Windows.Forms.CheckBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeSet = new System.Windows.Forms.DateTimePicker();
            this.StartButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TimerLabel = new System.Windows.Forms.Label();
            this.Shutdowncheck = new System.Windows.Forms.CheckBox();
            this.FreeGatecheck = new System.Windows.Forms.CheckBox();
            this.PBar = new System.Windows.Forms.ProgressBar();
            this.timelabel = new System.Windows.Forms.Label();
            this.FreeGate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateSet
            // 
            this.DateSet.Location = new System.Drawing.Point(12, 150);
            this.DateSet.Name = "DateSet";
            this.DateSet.Size = new System.Drawing.Size(198, 20);
            this.DateSet.TabIndex = 0;
            // 
            // EnableCheck
            // 
            this.EnableCheck.AutoSize = true;
            this.EnableCheck.Checked = true;
            this.EnableCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableCheck.Location = new System.Drawing.Point(13, 29);
            this.EnableCheck.Name = "EnableCheck";
            this.EnableCheck.Size = new System.Drawing.Size(102, 17);
            this.EnableCheck.TabIndex = 1;
            this.EnableCheck.Text = "Enable Ethernet";
            this.EnableCheck.UseVisualStyleBackColor = true;
            // 
            // DisableCheck
            // 
            this.DisableCheck.AutoSize = true;
            this.DisableCheck.Location = new System.Drawing.Point(13, 48);
            this.DisableCheck.Name = "DisableCheck";
            this.DisableCheck.Size = new System.Drawing.Size(104, 17);
            this.DisableCheck.TabIndex = 2;
            this.DisableCheck.Text = "Disable Ethernet";
            this.DisableCheck.UseVisualStyleBackColor = true;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(12, 133);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(78, 13);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "Set Date & Time";
            // 
            // TimeSet
            // 
            this.TimeSet.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeSet.Location = new System.Drawing.Point(13, 173);
            this.TimeSet.Name = "TimeSet";
            this.TimeSet.ShowUpDown = true;
            this.TimeSet.Size = new System.Drawing.Size(87, 20);
            this.TimeSet.TabIndex = 4;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(94, 196);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(112, 156);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(0, 13);
            this.TimerLabel.TabIndex = 6;
            // 
            // Shutdowncheck
            // 
            this.Shutdowncheck.AutoSize = true;
            this.Shutdowncheck.Location = new System.Drawing.Point(13, 68);
            this.Shutdowncheck.Name = "Shutdowncheck";
            this.Shutdowncheck.Size = new System.Drawing.Size(74, 17);
            this.Shutdowncheck.TabIndex = 7;
            this.Shutdowncheck.Text = "Shutdown";
            this.Shutdowncheck.UseVisualStyleBackColor = true;
            // 
            // FreeGatecheck
            // 
            this.FreeGatecheck.AutoSize = true;
            this.FreeGatecheck.Location = new System.Drawing.Point(13, 87);
            this.FreeGatecheck.Name = "FreeGatecheck";
            this.FreeGatecheck.Size = new System.Drawing.Size(70, 17);
            this.FreeGatecheck.TabIndex = 8;
            this.FreeGatecheck.Text = "FreeGate";
            this.FreeGatecheck.UseVisualStyleBackColor = true;
            // 
            // PBar
            // 
            this.PBar.Location = new System.Drawing.Point(12, 223);
            this.PBar.Name = "PBar";
            this.PBar.Size = new System.Drawing.Size(260, 27);
            this.PBar.TabIndex = 9;
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Location = new System.Drawing.Point(15, 196);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(0, 13);
            this.timelabel.TabIndex = 10;
            // 
            // FreeGate
            // 
            this.FreeGate.Location = new System.Drawing.Point(12, 109);
            this.FreeGate.Name = "FreeGate";
            this.FreeGate.Size = new System.Drawing.Size(100, 20);
            this.FreeGate.TabIndex = 11;
            this.FreeGate.Text = "fg742p.exe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Address of Freegate";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.fileToolStripMenuItem.Text = "Quit";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // EthernetDEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FreeGate);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.PBar);
            this.Controls.Add(this.FreeGatecheck);
            this.Controls.Add(this.Shutdowncheck);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TimeSet);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DisableCheck);
            this.Controls.Add(this.EnableCheck);
            this.Controls.Add(this.DateSet);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EthernetDEForm";
            this.Text = "Ethernet DEing";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateSet;
        private System.Windows.Forms.CheckBox EnableCheck;
        private System.Windows.Forms.CheckBox DisableCheck;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker TimeSet;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.CheckBox Shutdowncheck;
        private System.Windows.Forms.CheckBox FreeGatecheck;
        public System.Windows.Forms.ProgressBar PBar;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.TextBox FreeGate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

