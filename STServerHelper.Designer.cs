namespace ST
{
    partial class STServerHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STServerHelper));
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.startBtn = new Telerik.WinControls.UI.RadButton();
            this.stopBtn = new Telerik.WinControls.UI.RadButton();
            this.portBtn = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.updatesBtn = new Telerik.WinControls.UI.RadButton();
            this.txtToken = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.tokenEnabled = new Telerik.WinControls.UI.RadToggleSwitch();
            this.premiumEnabled = new Telerik.WinControls.UI.RadToggleSwitch();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.logsBtn = new Telerik.WinControls.UI.RadButton();
            this.copy2Btn = new Telerik.WinControls.UI.RadButton();
            this.copyBtn = new Telerik.WinControls.UI.RadButton();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.restartEnabled = new Telerik.WinControls.UI.RadToggleSwitch();
            this.LocalIP = new Telerik.WinControls.UI.RadLabel();
            this.PublicIP = new Telerik.WinControls.UI.RadLabel();
            this.LogsFolderBtn = new Telerik.WinControls.UI.RadButton();
            this.collapsibleConsole = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.consoleBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.customPort = new Telerik.WinControls.UI.RadLabel();
            this.portTxt = new Telerik.WinControls.UI.RadTextBox();
            this.portEnabled = new Telerik.WinControls.UI.RadToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.startBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenEnabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.premiumEnabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copy2Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartEnabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocalIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublicIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogsFolderBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapsibleConsole)).BeginInit();
            this.collapsibleConsole.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consoleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portEnabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(12, 25);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(89, 48);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.ThemeName = "VisualStudio2012Dark";
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(111, 25);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(93, 48);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "Stop";
            this.stopBtn.ThemeName = "VisualStudio2012Dark";
            this.stopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // portBtn
            // 
            this.portBtn.Location = new System.Drawing.Point(12, 250);
            this.portBtn.Name = "portBtn";
            this.portBtn.Size = new System.Drawing.Size(165, 32);
            this.portBtn.TabIndex = 1;
            this.portBtn.Text = "Check Port is open";
            this.portBtn.ThemeName = "VisualStudio2012Dark";
            this.portBtn.Click += new System.EventHandler(this.PortBtn_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(12, 299);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(62, 21);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Public IP:";
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(183, 299);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(56, 21);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Local IP:";
            this.radLabel2.ThemeName = "VisualStudio2012Dark";
            // 
            // updatesBtn
            // 
            this.updatesBtn.Location = new System.Drawing.Point(183, 250);
            this.updatesBtn.Name = "updatesBtn";
            this.updatesBtn.Size = new System.Drawing.Size(175, 32);
            this.updatesBtn.TabIndex = 2;
            this.updatesBtn.Text = "Check for Server Updates";
            this.updatesBtn.ThemeName = "VisualStudio2012Dark";
            this.updatesBtn.Click += new System.EventHandler(this.UpdatesBtn_Click);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(12, 117);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(272, 24);
            this.txtToken.TabIndex = 6;
            this.txtToken.ThemeName = "VisualStudio2012Dark";
            this.txtToken.TextChanged += new System.EventHandler(this.TxtToken_TextChanged);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel3.Location = new System.Drawing.Point(12, 90);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(88, 21);
            this.radLabel3.TabIndex = 7;
            this.radLabel3.Text = "Server Token:";
            this.radLabel3.ThemeName = "VisualStudio2012Dark";
            // 
            // tokenEnabled
            // 
            this.tokenEnabled.Location = new System.Drawing.Point(290, 117);
            this.tokenEnabled.Name = "tokenEnabled";
            this.tokenEnabled.OffText = "DISABLED";
            this.tokenEnabled.OnText = "ENABLED";
            this.tokenEnabled.Size = new System.Drawing.Size(68, 24);
            this.tokenEnabled.TabIndex = 8;
            this.tokenEnabled.Tag = "-token";
            this.tokenEnabled.ThemeName = "VisualStudio2012Dark";
            this.tokenEnabled.ThumbTickness = 15;
            this.tokenEnabled.Value = false;
            // 
            // premiumEnabled
            // 
            this.premiumEnabled.Location = new System.Drawing.Point(290, 87);
            this.premiumEnabled.Name = "premiumEnabled";
            this.premiumEnabled.OffText = "DISABLED";
            this.premiumEnabled.OnText = "ENABLED";
            this.premiumEnabled.Size = new System.Drawing.Size(68, 24);
            this.premiumEnabled.TabIndex = 9;
            this.premiumEnabled.Tag = "-premium";
            this.premiumEnabled.ThemeName = "VisualStudio2012Dark";
            this.premiumEnabled.ThumbTickness = 15;
            this.premiumEnabled.Value = false;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel4.Location = new System.Drawing.Point(165, 90);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(119, 21);
            this.radLabel4.TabIndex = 8;
            this.radLabel4.Text = "Premium Tick rate:";
            this.radLabel4.ThemeName = "VisualStudio2012Dark";
            // 
            // logsBtn
            // 
            this.logsBtn.Location = new System.Drawing.Point(183, 211);
            this.logsBtn.Name = "logsBtn";
            this.logsBtn.Size = new System.Drawing.Size(175, 32);
            this.logsBtn.TabIndex = 3;
            this.logsBtn.Text = "Open Latest Server Log";
            this.logsBtn.ThemeName = "VisualStudio2012Dark";
            this.logsBtn.Click += new System.EventHandler(this.LogsBtn_Click);
            // 
            // copy2Btn
            // 
            this.copy2Btn.Location = new System.Drawing.Point(12, 329);
            this.copy2Btn.Name = "copy2Btn";
            this.copy2Btn.Size = new System.Drawing.Size(165, 24);
            this.copy2Btn.TabIndex = 2;
            this.copy2Btn.Text = "Copy to clipboard";
            this.copy2Btn.ThemeName = "VisualStudio2012Dark";
            this.copy2Btn.Click += new System.EventHandler(this.Copy2Btn_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(183, 329);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(175, 24);
            this.copyBtn.TabIndex = 3;
            this.copyBtn.Text = "Copy to clipboard";
            this.copyBtn.ThemeName = "VisualStudio2012Dark";
            this.copyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radLabel5.Location = new System.Drawing.Point(210, 53);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(81, 20);
            this.radLabel5.TabIndex = 8;
            this.radLabel5.Text = "Auto Restart:";
            this.radLabel5.ThemeName = "VisualStudio2012Dark";
            // 
            // restartEnabled
            // 
            this.restartEnabled.Location = new System.Drawing.Point(290, 53);
            this.restartEnabled.Name = "restartEnabled";
            this.restartEnabled.OffText = "DISABLED";
            this.restartEnabled.OnText = "ENABLED";
            this.restartEnabled.Size = new System.Drawing.Size(68, 24);
            this.restartEnabled.TabIndex = 9;
            this.restartEnabled.ThemeName = "VisualStudio2012Dark";
            this.restartEnabled.ThumbTickness = 15;
            this.restartEnabled.Value = false;
            // 
            // LocalIP
            // 
            this.LocalIP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LocalIP.Location = new System.Drawing.Point(236, 299);
            this.LocalIP.Name = "LocalIP";
            this.LocalIP.Size = new System.Drawing.Size(60, 21);
            this.LocalIP.TabIndex = 6;
            this.LocalIP.Text = "127.0.0.1";
            this.LocalIP.ThemeName = "VisualStudio2012Dark";
            // 
            // PublicIP
            // 
            this.PublicIP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PublicIP.Location = new System.Drawing.Point(69, 299);
            this.PublicIP.Name = "PublicIP";
            this.PublicIP.Size = new System.Drawing.Size(2, 2);
            this.PublicIP.TabIndex = 5;
            this.PublicIP.ThemeName = "VisualStudio2012Dark";
            // 
            // LogsFolderBtn
            // 
            this.LogsFolderBtn.Location = new System.Drawing.Point(12, 211);
            this.LogsFolderBtn.Name = "LogsFolderBtn";
            this.LogsFolderBtn.Size = new System.Drawing.Size(165, 32);
            this.LogsFolderBtn.TabIndex = 4;
            this.LogsFolderBtn.Text = "Open Logs Folder";
            this.LogsFolderBtn.ThemeName = "VisualStudio2012Dark";
            this.LogsFolderBtn.Click += new System.EventHandler(this.LogsFolderBtn_Click);
            // 
            // collapsibleConsole
            // 
            this.collapsibleConsole.ExpandDirection = Telerik.WinControls.UI.RadDirection.Right;
            this.collapsibleConsole.Location = new System.Drawing.Point(359, 25);
            this.collapsibleConsole.Name = "collapsibleConsole";
            this.collapsibleConsole.OwnerBoundsCache = new System.Drawing.Rectangle(359, 25, 547, 328);
            // 
            // collapsibleConsole.PanelContainer
            // 
            this.collapsibleConsole.PanelContainer.Controls.Add(this.consoleBox);
            this.collapsibleConsole.PanelContainer.Size = new System.Drawing.Size(519, 326);
            this.collapsibleConsole.Size = new System.Drawing.Size(547, 328);
            this.collapsibleConsole.TabIndex = 0;
            this.collapsibleConsole.ThemeName = "VisualStudio2012Dark";
            // 
            // consoleBox
            // 
            this.consoleBox.AutoScroll = true;
            this.consoleBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.consoleBox.Location = new System.Drawing.Point(3, 3);
            this.consoleBox.Multiline = true;
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            // 
            // 
            // 
            this.consoleBox.RootElement.StretchVertically = true;
            this.consoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleBox.Size = new System.Drawing.Size(513, 320);
            this.consoleBox.TabIndex = 11;
            this.consoleBox.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.radLabel6.Location = new System.Drawing.Point(210, 25);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(127, 20);
            this.radLabel6.TabIndex = 9;
            this.radLabel6.Text = "Open/Close Console:";
            this.radLabel6.ThemeName = "VisualStudio2012Dark";
            // 
            // customPort
            // 
            this.customPort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.customPort.Location = new System.Drawing.Point(13, 147);
            this.customPort.Name = "customPort";
            this.customPort.Size = new System.Drawing.Size(85, 21);
            this.customPort.TabIndex = 8;
            this.customPort.Text = "Custom Port:";
            this.customPort.ThemeName = "VisualStudio2012Dark";
            // 
            // portTxt
            // 
            this.portTxt.Location = new System.Drawing.Point(12, 174);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(272, 24);
            this.portTxt.TabIndex = 7;
            this.portTxt.ThemeName = "VisualStudio2012Dark";
            this.portTxt.TextChanged += new System.EventHandler(this.PortTxt_TextChanged);
            // 
            // portEnabled
            // 
            this.portEnabled.Location = new System.Drawing.Point(290, 174);
            this.portEnabled.Name = "portEnabled";
            this.portEnabled.OffText = "DISABLED";
            this.portEnabled.OnText = "ENABLED";
            this.portEnabled.Size = new System.Drawing.Size(68, 24);
            this.portEnabled.TabIndex = 9;
            this.portEnabled.Tag = "-port";
            this.portEnabled.ThemeName = "VisualStudio2012Dark";
            this.portEnabled.ThumbTickness = 15;
            this.portEnabled.Value = false;
            // 
            // STServerHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(919, 374);
            this.Controls.Add(this.PublicIP);
            this.Controls.Add(this.portEnabled);
            this.Controls.Add(this.portTxt);
            this.Controls.Add(this.customPort);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.collapsibleConsole);
            this.Controls.Add(this.restartEnabled);
            this.Controls.Add(this.LogsFolderBtn);
            this.Controls.Add(this.premiumEnabled);
            this.Controls.Add(this.LocalIP);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.copy2Btn);
            this.Controls.Add(this.logsBtn);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.tokenEnabled);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.updatesBtn);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.portBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "STServerHelper";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ST Server Helper";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.STServerHelper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenEnabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.premiumEnabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copy2Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartEnabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocalIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PublicIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogsFolderBtn)).EndInit();
            this.collapsibleConsole.PanelContainer.ResumeLayout(false);
            this.collapsibleConsole.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collapsibleConsole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consoleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portEnabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadButton startBtn;
        private Telerik.WinControls.UI.RadButton stopBtn;
        private Telerik.WinControls.UI.RadButton portBtn;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton updatesBtn;
        private Telerik.WinControls.UI.RadTextBox txtToken;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadToggleSwitch tokenEnabled;
        private Telerik.WinControls.UI.RadToggleSwitch premiumEnabled;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadButton logsBtn;
        private Telerik.WinControls.UI.RadButton copy2Btn;
        private Telerik.WinControls.UI.RadButton copyBtn;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadToggleSwitch restartEnabled;
        private Telerik.WinControls.UI.RadLabel LocalIP;
        private Telerik.WinControls.UI.RadLabel PublicIP;
        private Telerik.WinControls.UI.RadButton LogsFolderBtn;
        private Telerik.WinControls.UI.RadCollapsiblePanel collapsibleConsole;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel customPort;
        private Telerik.WinControls.UI.RadTextBox portTxt;
        private Telerik.WinControls.UI.RadToggleSwitch portEnabled;
        private Telerik.WinControls.UI.RadTextBox consoleBox;
    }
}
