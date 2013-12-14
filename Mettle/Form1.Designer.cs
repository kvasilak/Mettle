namespace Mettle
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabChart = new System.Windows.Forms.TabPage();
            this.tagState3 = new MettleLib.TagState();
            this.tagState2 = new MettleLib.TagState();
            this.tagState1 = new MettleLib.TagState();
            this.tagText1 = new MettleLib.TagText();
            this.txtAllText = new System.Windows.Forms.TextBox();
            this.tabText = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModules = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTagData = new System.Windows.Forms.TextBox();
            this.txtUniques = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPlay = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.btnTools = new System.Windows.Forms.ToolStripButton();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.BtnReset = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripError = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabMain.SuspendLayout();
            this.tabChart.SuspendLayout();
            this.tabText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabChart);
            this.tabMain.Controls.Add(this.tabText);
            this.tabMain.Location = new System.Drawing.Point(0, 28);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(990, 542);
            this.tabMain.TabIndex = 0;
            // 
            // tabChart
            // 
            this.tabChart.BackColor = System.Drawing.SystemColors.Control;
            this.tabChart.Controls.Add(this.tagState3);
            this.tabChart.Controls.Add(this.tagState2);
            this.tabChart.Controls.Add(this.tagState1);
            this.tabChart.Controls.Add(this.tagText1);
            this.tabChart.Controls.Add(this.txtAllText);
            this.tabChart.Location = new System.Drawing.Point(4, 22);
            this.tabChart.Name = "tabChart";
            this.tabChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabChart.Size = new System.Drawing.Size(982, 516);
            this.tabChart.TabIndex = 1;
            this.tabChart.Tag = "Right";
            this.tabChart.Text = "Chart";
            // 
            // tagState3
            // 
            this.tagState3.Checked = false;
            this.tagState3.Location = new System.Drawing.Point(26, 56);
            this.tagState3.ModuleName = "App";
            this.tagState3.Name = "tagState3";
            this.tagState3.Size = new System.Drawing.Size(193, 26);
            this.tagState3.TabIndex = 89;
            this.tagState3.Tag = "modem_state";
            this.tagState3.Text = "MODEM_RUNNING_AT";
            // 
            // tagState2
            // 
            this.tagState2.Checked = false;
            this.tagState2.Location = new System.Drawing.Point(38, 88);
            this.tagState2.ModuleName = "App";
            this.tagState2.Name = "tagState2";
            this.tagState2.Size = new System.Drawing.Size(181, 26);
            this.tagState2.TabIndex = 88;
            this.tagState2.Tag = "modem_state";
            this.tagState2.Text = "MODEM_STARTING_AT";
            // 
            // tagState1
            // 
            this.tagState1.Checked = false;
            this.tagState1.Location = new System.Drawing.Point(13, 24);
            this.tagState1.ModuleName = "App";
            this.tagState1.Name = "tagState1";
            this.tagState1.Size = new System.Drawing.Size(232, 26);
            this.tagState1.TabIndex = 87;
            this.tagState1.Tag = "modem_state";
            this.tagState1.Text = "MODEM_STARTING_AT_MSG";
            // 
            // tagText1
            // 
            this.tagText1.Location = new System.Drawing.Point(251, 6);
            this.tagText1.ModuleName = "App";
            this.tagText1.Multiline = true;
            this.tagText1.Name = "tagText1";
            this.tagText1.Size = new System.Drawing.Size(212, 113);
            this.tagText1.TabIndex = 86;
            this.tagText1.Tag = "modem_state";
            // 
            // txtAllText
            // 
            this.txtAllText.AcceptsReturn = true;
            this.txtAllText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAllText.HideSelection = false;
            this.txtAllText.Location = new System.Drawing.Point(26, 334);
            this.txtAllText.Multiline = true;
            this.txtAllText.Name = "txtAllText";
            this.txtAllText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAllText.Size = new System.Drawing.Size(322, 161);
            this.txtAllText.TabIndex = 85;
            // 
            // tabText
            // 
            this.tabText.Controls.Add(this.label5);
            this.tabText.Controls.Add(this.txtModules);
            this.tabText.Controls.Add(this.label3);
            this.tabText.Controls.Add(this.label2);
            this.tabText.Controls.Add(this.label1);
            this.tabText.Controls.Add(this.txtTagData);
            this.tabText.Controls.Add(this.txtUniques);
            this.tabText.Location = new System.Drawing.Point(4, 22);
            this.tabText.Name = "tabText";
            this.tabText.Padding = new System.Windows.Forms.Padding(3);
            this.tabText.Size = new System.Drawing.Size(982, 516);
            this.tabText.TabIndex = 0;
            this.tabText.Text = "Text";
            this.tabText.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Modules";
            // 
            // txtModules
            // 
            this.txtModules.AcceptsReturn = true;
            this.txtModules.AcceptsTab = true;
            this.txtModules.HideSelection = false;
            this.txtModules.Location = new System.Drawing.Point(394, 41);
            this.txtModules.Multiline = true;
            this.txtModules.Name = "txtModules";
            this.txtModules.Size = new System.Drawing.Size(172, 388);
            this.txtModules.TabIndex = 6;
            this.txtModules.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtModules_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(780, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tag Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tags";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "All serial data";
            // 
            // txtTagData
            // 
            this.txtTagData.AcceptsReturn = true;
            this.txtTagData.AcceptsTab = true;
            this.txtTagData.HideSelection = false;
            this.txtTagData.Location = new System.Drawing.Point(783, 41);
            this.txtTagData.Multiline = true;
            this.txtTagData.Name = "txtTagData";
            this.txtTagData.Size = new System.Drawing.Size(172, 388);
            this.txtTagData.TabIndex = 2;
            // 
            // txtUniques
            // 
            this.txtUniques.AcceptsReturn = true;
            this.txtUniques.AcceptsTab = true;
            this.txtUniques.HideSelection = false;
            this.txtUniques.Location = new System.Drawing.Point(590, 41);
            this.txtUniques.Multiline = true;
            this.txtUniques.Name = "txtUniques";
            this.txtUniques.Size = new System.Drawing.Size(172, 388);
            this.txtUniques.TabIndex = 1;
            this.txtUniques.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textUniques_MouseClick);
            // 
            // serialPort1
            // 
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // chart1
            // 
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            // 
            // chart2
            // 
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPlay,
            this.btnStop,
            this.btnTools,
            this.btnAbout,
            this.BtnReset});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(990, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPlay
            // 
            this.btnPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(23, 22);
            this.btnPlay.Text = "toolStripButton1";
            this.btnPlay.ToolTipText = "Start !";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(23, 22);
            this.btnStop.Text = "toolStripButton2";
            this.btnStop.ToolTipText = "Stop!";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnTools
            // 
            this.btnTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTools.Image = ((System.Drawing.Image)(resources.GetObject("btnTools.Image")));
            this.btnTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(23, 22);
            this.btnTools.ToolTipText = "Setup";
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(44, 22);
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnReset.Image = ((System.Drawing.Image)(resources.GetObject("BtnReset.Image")));
            this.BtnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(39, 22);
            this.BtnReset.Text = "Reset";
            this.BtnReset.ToolTipText = "Reset and clear UI";
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripStatus,
            this.stripError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(990, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "Status";
            // 
            // stripStatus
            // 
            this.stripStatus.Name = "stripStatus";
            this.stripStatus.Size = new System.Drawing.Size(39, 17);
            this.stripStatus.Text = "Status";
            this.stripStatus.ToolTipText = "Application status";
            // 
            // stripError
            // 
            this.stripError.Name = "stripError";
            this.stripError.Size = new System.Drawing.Size(32, 17);
            this.stripError.Text = "Error";
            this.stripError.ToolTipText = "Application errors";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 569);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(908, 455);
            this.Name = "FormMain";
            this.Text = "Mettle; Firmware inspector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMain.ResumeLayout(false);
            this.tabChart.ResumeLayout(false);
            this.tabChart.PerformLayout();
            this.tabText.ResumeLayout(false);
            this.tabText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabText;
        private System.Windows.Forms.TabPage tabChart;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPlay;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripButton btnTools;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTagData;
        private System.Windows.Forms.TextBox txtUniques;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModules;
        private System.Windows.Forms.TextBox txtAllText;
        private System.Windows.Forms.ToolStripButton BtnReset;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripStatus;
        private System.Windows.Forms.ToolStripStatusLabel stripError;
        private MettleLib.TagState tagState1;
        private MettleLib.TagText tagText1;
        private MettleLib.TagState tagState3;
        private MettleLib.TagState tagState2;
    }
}

