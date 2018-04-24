namespace PixARK_Server_Starter
{
    partial class serverStarter
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
            this.installServerButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverInstallLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.stopServerButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.launchServerButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.serverNameTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.serverPasswordTxt = new System.Windows.Forms.TextBox();
            this.serverPassEnabled = new System.Windows.Forms.CheckBox();
            this.adminPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cubePort = new System.Windows.Forms.NumericUpDown();
            this.rconPort = new System.Windows.Forms.NumericUpDown();
            this.queryPort = new System.Windows.Forms.NumericUpDown();
            this.gamePort = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gameUserSettingsBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cubePort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rconPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePort)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Controls";
            // 
            // installServerButton
            // 
            this.installServerButton.Location = new System.Drawing.Point(104, 8);
            this.installServerButton.Name = "installServerButton";
            this.installServerButton.Size = new System.Drawing.Size(79, 23);
            this.installServerButton.TabIndex = 1;
            this.installServerButton.Text = "Install Server";
            this.installServerButton.UseVisualStyleBackColor = true;
            this.installServerButton.Click += new System.EventHandler(this.installServerButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1148, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverInstallLocationToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // serverInstallLocationToolStripMenuItem
            // 
            this.serverInstallLocationToolStripMenuItem.Name = "serverInstallLocationToolStripMenuItem";
            this.serverInstallLocationToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.serverInstallLocationToolStripMenuItem.Text = "Change Server Install Location";
            this.serverInstallLocationToolStripMenuItem.Click += new System.EventHandler(this.serverInstallLocationToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1148, 585);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.stopServerButton);
            this.tabPage1.Controls.Add(this.updateButton);
            this.tabPage1.Controls.Add(this.launchServerButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.installServerButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1140, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // stopServerButton
            // 
            this.stopServerButton.Location = new System.Drawing.Point(360, 8);
            this.stopServerButton.Name = "stopServerButton";
            this.stopServerButton.Size = new System.Drawing.Size(75, 23);
            this.stopServerButton.TabIndex = 6;
            this.stopServerButton.Text = "Stop Server";
            this.stopServerButton.UseVisualStyleBackColor = true;
            this.stopServerButton.Click += new System.EventHandler(this.stopServerButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(189, 8);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(84, 23);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update Server";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // launchServerButton
            // 
            this.launchServerButton.Location = new System.Drawing.Point(279, 8);
            this.launchServerButton.Name = "launchServerButton";
            this.launchServerButton.Size = new System.Drawing.Size(75, 23);
            this.launchServerButton.TabIndex = 4;
            this.launchServerButton.Text = "Start Server";
            this.launchServerButton.UseVisualStyleBackColor = true;
            this.launchServerButton.Click += new System.EventHandler(this.launchServerButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.serverNameTxt);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.serverPasswordTxt);
            this.tabPage2.Controls.Add(this.serverPassEnabled);
            this.tabPage2.Controls.Add(this.adminPass);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cubePort);
            this.tabPage2.Controls.Add(this.rconPort);
            this.tabPage2.Controls.Add(this.queryPort);
            this.tabPage2.Controls.Add(this.gamePort);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1140, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Server Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // serverNameTxt
            // 
            this.serverNameTxt.Location = new System.Drawing.Point(125, 145);
            this.serverNameTxt.Name = "serverNameTxt";
            this.serverNameTxt.Size = new System.Drawing.Size(100, 20);
            this.serverNameTxt.TabIndex = 13;
            this.serverNameTxt.TextChanged += new System.EventHandler(this.serverNameTxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Server Name:";
            // 
            // serverPasswordTxt
            // 
            this.serverPasswordTxt.Location = new System.Drawing.Point(159, 193);
            this.serverPasswordTxt.Name = "serverPasswordTxt";
            this.serverPasswordTxt.Size = new System.Drawing.Size(100, 20);
            this.serverPasswordTxt.TabIndex = 11;
            this.serverPasswordTxt.TextChanged += new System.EventHandler(this.serverPasswordTxt_TextChanged);
            // 
            // serverPassEnabled
            // 
            this.serverPassEnabled.AutoSize = true;
            this.serverPassEnabled.Location = new System.Drawing.Point(11, 195);
            this.serverPassEnabled.Name = "serverPassEnabled";
            this.serverPassEnabled.Size = new System.Drawing.Size(142, 17);
            this.serverPassEnabled.TabIndex = 10;
            this.serverPassEnabled.Text = "Server Password On/Off";
            this.serverPassEnabled.UseVisualStyleBackColor = true;
            this.serverPassEnabled.CheckedChanged += new System.EventHandler(this.serverPassEnabled_CheckedChanged);
            // 
            // adminPass
            // 
            this.adminPass.Location = new System.Drawing.Point(125, 168);
            this.adminPass.Name = "adminPass";
            this.adminPass.Size = new System.Drawing.Size(100, 20);
            this.adminPass.TabIndex = 9;
            this.adminPass.TextChanged += new System.EventHandler(this.adminPass_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Admin Password:";
            // 
            // cubePort
            // 
            this.cubePort.Location = new System.Drawing.Point(74, 93);
            this.cubePort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.cubePort.Name = "cubePort";
            this.cubePort.Size = new System.Drawing.Size(56, 20);
            this.cubePort.TabIndex = 7;
            this.cubePort.Value = new decimal(new int[] {
            1111,
            0,
            0,
            0});
            // 
            // rconPort
            // 
            this.rconPort.Location = new System.Drawing.Point(74, 67);
            this.rconPort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.rconPort.Name = "rconPort";
            this.rconPort.Size = new System.Drawing.Size(56, 20);
            this.rconPort.TabIndex = 6;
            this.rconPort.Value = new decimal(new int[] {
            1111,
            0,
            0,
            0});
            // 
            // queryPort
            // 
            this.queryPort.Location = new System.Drawing.Point(74, 43);
            this.queryPort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.queryPort.Name = "queryPort";
            this.queryPort.Size = new System.Drawing.Size(56, 20);
            this.queryPort.TabIndex = 5;
            this.queryPort.Value = new decimal(new int[] {
            1111,
            0,
            0,
            0});
            // 
            // gamePort
            // 
            this.gamePort.Location = new System.Drawing.Point(74, 19);
            this.gamePort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.gamePort.Name = "gamePort";
            this.gamePort.Size = new System.Drawing.Size(56, 20);
            this.gamePort.TabIndex = 4;
            this.gamePort.Value = new decimal(new int[] {
            11111,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cube Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "RCON Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Query Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Game Port:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gameUserSettingsBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1140, 559);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GameUserSettings.ini";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gameUserSettingsBox
            // 
            this.gameUserSettingsBox.Location = new System.Drawing.Point(18, 37);
            this.gameUserSettingsBox.Name = "gameUserSettingsBox";
            this.gameUserSettingsBox.Size = new System.Drawing.Size(622, 379);
            this.gameUserSettingsBox.TabIndex = 0;
            this.gameUserSettingsBox.Text = "";
            // 
            // serverStarter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 607);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "serverStarter";
            this.Text = "PixARK Server Starter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cubePort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rconPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePort)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button installServerButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverInstallLocationToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown gamePort;
        private System.Windows.Forms.NumericUpDown queryPort;
        private System.Windows.Forms.NumericUpDown rconPort;
        private System.Windows.Forms.NumericUpDown cubePort;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox gameUserSettingsBox;
        private System.Windows.Forms.TextBox adminPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox serverPasswordTxt;
        private System.Windows.Forms.CheckBox serverPassEnabled;
        private System.Windows.Forms.Button launchServerButton;
        private System.Windows.Forms.Button stopServerButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox serverNameTxt;
        private System.Windows.Forms.Label label8;
    }
}

