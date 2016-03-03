﻿namespace CloudMusicGear
{
    partial class MainForm
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
            this.groupOptions = new System.Windows.Forms.GroupBox();
            this.useCustomDns = new System.Windows.Forms.CheckBox();
            this.proxyAddress = new System.Windows.Forms.TextBox();
            this.useProxy = new System.Windows.Forms.CheckBox();
            this.customDnsAddress = new System.Windows.Forms.ComboBox();
            this.overseasCdnAddress = new System.Windows.Forms.ComboBox();
            this.useOverseasCdn = new System.Windows.Forms.CheckBox();
            this.pacPortNum = new System.Windows.Forms.NumericUpDown();
            this.pacPort = new System.Windows.Forms.Label();
            this.usePac = new System.Windows.Forms.CheckBox();
            this.useOverseas = new System.Windows.Forms.CheckBox();
            this.downloadQuality = new System.Windows.Forms.ComboBox();
            this.forceDownload = new System.Windows.Forms.CheckBox();
            this.playbackQuality = new System.Windows.Forms.ComboBox();
            this.forcePlayback = new System.Windows.Forms.CheckBox();
            this.portNum = new System.Windows.Forms.NumericUpDown();
            this.portLabel = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.clearLog = new System.Windows.Forms.Button();
            this.ni = new System.Windows.Forms.NotifyIcon(this.components);
            this.autoStart = new System.Windows.Forms.CheckBox();
            this.autoMinimize = new System.Windows.Forms.CheckBox();
            this.groupOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacPortNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portNum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupOptions
            // 
            this.groupOptions.Controls.Add(this.useCustomDns);
            this.groupOptions.Controls.Add(this.proxyAddress);
            this.groupOptions.Controls.Add(this.useProxy);
            this.groupOptions.Controls.Add(this.customDnsAddress);
            this.groupOptions.Controls.Add(this.overseasCdnAddress);
            this.groupOptions.Controls.Add(this.useOverseasCdn);
            this.groupOptions.Controls.Add(this.pacPortNum);
            this.groupOptions.Controls.Add(this.pacPort);
            this.groupOptions.Controls.Add(this.usePac);
            this.groupOptions.Controls.Add(this.useOverseas);
            this.groupOptions.Controls.Add(this.downloadQuality);
            this.groupOptions.Controls.Add(this.forceDownload);
            this.groupOptions.Controls.Add(this.playbackQuality);
            this.groupOptions.Controls.Add(this.forcePlayback);
            this.groupOptions.Controls.Add(this.portNum);
            this.groupOptions.Controls.Add(this.portLabel);
            this.groupOptions.Location = new System.Drawing.Point(17, 15);
            this.groupOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupOptions.Name = "groupOptions";
            this.groupOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupOptions.Size = new System.Drawing.Size(911, 127);
            this.groupOptions.TabIndex = 0;
            this.groupOptions.TabStop = false;
            this.groupOptions.Text = "Options";
            // 
            // useCustomDns
            // 
            this.useCustomDns.AutoSize = true;
            this.useCustomDns.Location = new System.Drawing.Point(531, 95);
            this.useCustomDns.Name = "useCustomDns";
            this.useCustomDns.Size = new System.Drawing.Size(109, 19);
            this.useCustomDns.TabIndex = 14;
            this.useCustomDns.Text = "Custom DNS";
            this.useCustomDns.UseVisualStyleBackColor = true;
            this.useCustomDns.CheckedChanged += new System.EventHandler(this.useCustomDns_CheckedChanged);
            // 
            // proxyAddress
            // 
            this.proxyAddress.Enabled = false;
            this.proxyAddress.Location = new System.Drawing.Point(87, 92);
            this.proxyAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.proxyAddress.Name = "proxyAddress";
            this.proxyAddress.Size = new System.Drawing.Size(314, 25);
            this.proxyAddress.TabIndex = 13;
            this.proxyAddress.TextChanged += new System.EventHandler(this.proxyAddress_TextChanged);
            // 
            // useProxy
            // 
            this.useProxy.AutoSize = true;
            this.useProxy.Location = new System.Drawing.Point(9, 95);
            this.useProxy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.useProxy.Name = "useProxy";
            this.useProxy.Size = new System.Drawing.Size(69, 19);
            this.useProxy.TabIndex = 12;
            this.useProxy.Text = "Proxy";
            this.useProxy.UseVisualStyleBackColor = true;
            this.useProxy.CheckedChanged += new System.EventHandler(this.useProxy_CheckedChanged);
            // 
            // customDnsAddress
            // 
            this.customDnsAddress.Enabled = false;
            this.customDnsAddress.FormattingEnabled = true;
            this.customDnsAddress.Items.AddRange(new object[] {
            "219.141.136.10",
            "219.141.140.10",
            "202.106.196.115"});
            this.customDnsAddress.Location = new System.Drawing.Point(664, 93);
            this.customDnsAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.customDnsAddress.Name = "customDnsAddress";
            this.customDnsAddress.Size = new System.Drawing.Size(160, 23);
            this.customDnsAddress.TabIndex = 11;
            this.customDnsAddress.SelectedIndexChanged += new System.EventHandler(this.customDnsAddress_SelectedIndexChanged);
            // 
            // overseasCdnAddress
            // 
            this.overseasCdnAddress.Enabled = false;
            this.overseasCdnAddress.FormattingEnabled = true;
            this.overseasCdnAddress.Items.AddRange(new object[] {
            "14.215.9.16",
            "14.215.9.43",
            "219.138.27.16",
            "219.138.27.67",
            "163.177.171.13",
            "163.177.171.14",
            "163.177.171.16",
            "163.177.171.17",
            "163.177.171.18",
            "163.177.171.19",
            "163.177.171.20",
            "163.177.171.21",
            "163.177.171.22",
            "163.177.171.28",
            "163.177.171.29",
            "163.177.171.31",
            "163.177.171.32",
            "163.177.171.33",
            "163.177.171.34",
            "163.177.171.35",
            "163.177.171.37",
            "163.177.171.175",
            "163.177.171.206"});
            this.overseasCdnAddress.Location = new System.Drawing.Point(241, 58);
            this.overseasCdnAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.overseasCdnAddress.Name = "overseasCdnAddress";
            this.overseasCdnAddress.Size = new System.Drawing.Size(160, 23);
            this.overseasCdnAddress.TabIndex = 11;
            this.overseasCdnAddress.SelectedIndexChanged += new System.EventHandler(this.overseasCdnAddress_SelectedIndexChanged);
            // 
            // useOverseasCdn
            // 
            this.useOverseasCdn.AutoSize = true;
            this.useOverseasCdn.Enabled = false;
            this.useOverseasCdn.Location = new System.Drawing.Point(129, 61);
            this.useOverseasCdn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.useOverseasCdn.Name = "useOverseasCdn";
            this.useOverseasCdn.Size = new System.Drawing.Size(93, 19);
            this.useOverseasCdn.TabIndex = 10;
            this.useOverseasCdn.Text = "CDN mode";
            this.useOverseasCdn.UseVisualStyleBackColor = true;
            this.useOverseasCdn.CheckedChanged += new System.EventHandler(this.useOverseasCdn_CheckedChanged);
            // 
            // pacPortNum
            // 
            this.pacPortNum.Enabled = false;
            this.pacPortNum.Location = new System.Drawing.Point(736, 58);
            this.pacPortNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pacPortNum.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.pacPortNum.Minimum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.pacPortNum.Name = "pacPortNum";
            this.pacPortNum.Size = new System.Drawing.Size(89, 25);
            this.pacPortNum.TabIndex = 9;
            this.pacPortNum.Value = new decimal(new int[] {
            3413,
            0,
            0,
            0});
            this.pacPortNum.ValueChanged += new System.EventHandler(this.pacPortNum_ValueChanged);
            // 
            // pacPort
            // 
            this.pacPort.AutoSize = true;
            this.pacPort.Location = new System.Drawing.Point(661, 62);
            this.pacPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pacPort.Name = "pacPort";
            this.pacPort.Size = new System.Drawing.Size(71, 15);
            this.pacPort.TabIndex = 8;
            this.pacPort.Text = "PAC port";
            // 
            // usePac
            // 
            this.usePac.AutoSize = true;
            this.usePac.Location = new System.Drawing.Point(531, 61);
            this.usePac.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.usePac.Name = "usePac";
            this.usePac.Size = new System.Drawing.Size(109, 19);
            this.usePac.TabIndex = 7;
            this.usePac.Text = "Enable PAC";
            this.usePac.UseVisualStyleBackColor = true;
            this.usePac.CheckedChanged += new System.EventHandler(this.usePac_CheckedChanged);
            // 
            // useOverseas
            // 
            this.useOverseas.AutoSize = true;
            this.useOverseas.Location = new System.Drawing.Point(9, 61);
            this.useOverseas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.useOverseas.Name = "useOverseas";
            this.useOverseas.Size = new System.Drawing.Size(93, 19);
            this.useOverseas.TabIndex = 6;
            this.useOverseas.Text = "Overseas";
            this.useOverseas.UseVisualStyleBackColor = true;
            this.useOverseas.CheckedChanged += new System.EventHandler(this.useOverseas_CheckedChanged);
            // 
            // downloadQuality
            // 
            this.downloadQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.downloadQuality.Enabled = false;
            this.downloadQuality.FormattingEnabled = true;
            this.downloadQuality.Items.AddRange(new object[] {
            "HQ / 320000",
            "MQ / 192000",
            "LQ / 128000",
            "BQ / 96000"});
            this.downloadQuality.Location = new System.Drawing.Point(736, 24);
            this.downloadQuality.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.downloadQuality.Name = "downloadQuality";
            this.downloadQuality.Size = new System.Drawing.Size(160, 23);
            this.downloadQuality.TabIndex = 5;
            this.downloadQuality.SelectedIndexChanged += new System.EventHandler(this.downloadQuality_SelectedIndexChanged);
            // 
            // forceDownload
            // 
            this.forceDownload.AutoSize = true;
            this.forceDownload.Location = new System.Drawing.Point(531, 27);
            this.forceDownload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.forceDownload.Name = "forceDownload";
            this.forceDownload.Size = new System.Drawing.Size(229, 19);
            this.forceDownload.TabIndex = 4;
            this.forceDownload.Text = "Override download quality";
            this.forceDownload.UseVisualStyleBackColor = true;
            this.forceDownload.CheckedChanged += new System.EventHandler(this.forceDownload_CheckedChanged);
            // 
            // playbackQuality
            // 
            this.playbackQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playbackQuality.Enabled = false;
            this.playbackQuality.FormattingEnabled = true;
            this.playbackQuality.Items.AddRange(new object[] {
            "HQ / 320000",
            "MQ / 192000",
            "LQ / 128000",
            "BQ / 96000"});
            this.playbackQuality.Location = new System.Drawing.Point(361, 24);
            this.playbackQuality.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.playbackQuality.Name = "playbackQuality";
            this.playbackQuality.Size = new System.Drawing.Size(160, 23);
            this.playbackQuality.TabIndex = 3;
            this.playbackQuality.SelectedIndexChanged += new System.EventHandler(this.playbackQuality_SelectedIndexChanged);
            // 
            // forcePlayback
            // 
            this.forcePlayback.AutoSize = true;
            this.forcePlayback.Location = new System.Drawing.Point(160, 27);
            this.forcePlayback.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.forcePlayback.Name = "forcePlayback";
            this.forcePlayback.Size = new System.Drawing.Size(229, 19);
            this.forcePlayback.TabIndex = 2;
            this.forcePlayback.Text = "Override playback quality";
            this.forcePlayback.UseVisualStyleBackColor = true;
            this.forcePlayback.CheckedChanged += new System.EventHandler(this.forcePlayback_CheckedChanged);
            // 
            // portNum
            // 
            this.portNum.Location = new System.Drawing.Point(51, 25);
            this.portNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.portNum.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portNum.Minimum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.portNum.Name = "portNum";
            this.portNum.Size = new System.Drawing.Size(89, 25);
            this.portNum.TabIndex = 1;
            this.portNum.Value = new decimal(new int[] {
            3412,
            0,
            0,
            0});
            this.portNum.ValueChanged += new System.EventHandler(this.portNum_ValueChanged);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(8, 28);
            this.portLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(39, 15);
            this.portLabel.TabIndex = 0;
            this.portLabel.Text = "Port";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(16, 149);
            this.log.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log.Size = new System.Drawing.Size(911, 350);
            this.log.TabIndex = 2;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(720, 507);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 27);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(828, 507);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 27);
            this.stopButton.TabIndex = 7;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // clearLog
            // 
            this.clearLog.Location = new System.Drawing.Point(16, 508);
            this.clearLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(100, 27);
            this.clearLog.TabIndex = 3;
            this.clearLog.Text = "Clear";
            this.clearLog.UseVisualStyleBackColor = true;
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // ni
            // 
            this.ni.BalloonTipText = "Double click to restore";
            this.ni.BalloonTipTitle = "Cloud Music Gear";
            this.ni.Text = "Cloud Music Gear";
            this.ni.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ni_MouseDoubleClick);
            // 
            // autoStart
            // 
            this.autoStart.AutoSize = true;
            this.autoStart.Location = new System.Drawing.Point(124, 512);
            this.autoStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.autoStart.Name = "autoStart";
            this.autoStart.Size = new System.Drawing.Size(181, 19);
            this.autoStart.TabIndex = 4;
            this.autoStart.Text = "Start when launched";
            this.autoStart.UseVisualStyleBackColor = true;
            this.autoStart.CheckedChanged += new System.EventHandler(this.autoStart_CheckedChanged);
            // 
            // autoMinimize
            // 
            this.autoMinimize.AutoSize = true;
            this.autoMinimize.Location = new System.Drawing.Point(297, 512);
            this.autoMinimize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.autoMinimize.Name = "autoMinimize";
            this.autoMinimize.Size = new System.Drawing.Size(205, 19);
            this.autoMinimize.TabIndex = 5;
            this.autoMinimize.Text = "Minimize when launched";
            this.autoMinimize.UseVisualStyleBackColor = true;
            this.autoMinimize.CheckedChanged += new System.EventHandler(this.autoMinimize_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 549);
            this.Controls.Add(this.autoMinimize);
            this.Controls.Add(this.autoStart);
            this.Controls.Add(this.clearLog);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.log);
            this.Controls.Add(this.groupOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "CloudMusicGear";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupOptions.ResumeLayout(false);
            this.groupOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacPortNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupOptions;
        private System.Windows.Forms.ComboBox overseasCdnAddress;
        private System.Windows.Forms.CheckBox useOverseasCdn;
        private System.Windows.Forms.NumericUpDown pacPortNum;
        private System.Windows.Forms.Label pacPort;
        private System.Windows.Forms.CheckBox usePac;
        private System.Windows.Forms.CheckBox useOverseas;
        private System.Windows.Forms.ComboBox downloadQuality;
        private System.Windows.Forms.CheckBox forceDownload;
        private System.Windows.Forms.ComboBox playbackQuality;
        private System.Windows.Forms.CheckBox forcePlayback;
        private System.Windows.Forms.NumericUpDown portNum;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox proxyAddress;
        private System.Windows.Forms.CheckBox useProxy;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button clearLog;
        private System.Windows.Forms.NotifyIcon ni;
        private System.Windows.Forms.CheckBox autoStart;
        private System.Windows.Forms.CheckBox autoMinimize;
        private System.Windows.Forms.CheckBox useCustomDns;
        private System.Windows.Forms.ComboBox customDnsAddress;
    }
}
