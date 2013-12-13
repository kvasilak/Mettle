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
            this.txtAllText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.tagIO5 = new Mettle.TagIO();
            this.tagIO4 = new Mettle.TagIO();
            this.tagIO3 = new Mettle.TagIO();
            this.tagIO2 = new Mettle.TagIO();
            this.tagIO1 = new Mettle.TagIO();
            this.ioState3 = new Mettle.TagIO();
            this.ioState2 = new Mettle.TagIO();
            this.ioState1 = new Mettle.TagIO();
            this.tagText3 = new Mettle.TagText();
            this.tagState5 = new Mettle.TagState();
            this.tagState6 = new Mettle.TagState();
            this.tagState1 = new Mettle.TagState();
            this.tagState2 = new Mettle.TagState();
            this.tagState3 = new Mettle.TagState();
            this.tagState4 = new Mettle.TagState();
            this.stateButton2 = new Mettle.TagState();
            this.stateButton4 = new Mettle.TagState();
            this.stateButton1 = new Mettle.TagState();
            this.stateButton3 = new Mettle.TagState();
            this.aGauge4 = new Mettle.TagGauge();
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
            this.tabChart.Controls.Add(this.txtAllText);
            this.tabChart.Controls.Add(this.tagIO5);
            this.tabChart.Controls.Add(this.tagIO4);
            this.tabChart.Controls.Add(this.tagIO3);
            this.tabChart.Controls.Add(this.tagIO2);
            this.tabChart.Controls.Add(this.tagIO1);
            this.tabChart.Controls.Add(this.label6);
            this.tabChart.Controls.Add(this.ioState3);
            this.tabChart.Controls.Add(this.ioState2);
            this.tabChart.Controls.Add(this.ioState1);
            this.tabChart.Controls.Add(this.label4);
            this.tabChart.Controls.Add(this.tagText3);
            this.tabChart.Controls.Add(this.tagState5);
            this.tabChart.Controls.Add(this.tagState6);
            this.tabChart.Controls.Add(this.tagState1);
            this.tabChart.Controls.Add(this.tagState2);
            this.tabChart.Controls.Add(this.tagState3);
            this.tabChart.Controls.Add(this.tagState4);
            this.tabChart.Controls.Add(this.stateButton2);
            this.tabChart.Controls.Add(this.stateButton4);
            this.tabChart.Controls.Add(this.stateButton1);
            this.tabChart.Controls.Add(this.stateButton3);
            this.tabChart.Location = new System.Drawing.Point(4, 22);
            this.tabChart.Name = "tabChart";
            this.tabChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabChart.Size = new System.Drawing.Size(982, 516);
            this.tabChart.TabIndex = 1;
            this.tabChart.Tag = "Right";
            this.tabChart.Text = "Chart";
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
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(881, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Modem Control";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Modem States";
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
            // tagIO5
            // 
            this.tagIO5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagIO5.Checked = false;
            this.tagIO5.ForeColor = System.Drawing.Color.Yellow;
            this.tagIO5.Location = new System.Drawing.Point(884, 261);
            this.tagIO5.ModuleName = null;
            this.tagIO5.Name = "tagIO5";
            this.tagIO5.Size = new System.Drawing.Size(46, 24);
            this.tagIO5.TabIndex = 84;
            this.tagIO5.Tag = "Ext_Pwr_Det";
            this.tagIO5.Text = "Ext Pwr";
            // 
            // tagIO4
            // 
            this.tagIO4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagIO4.Checked = false;
            this.tagIO4.ForeColor = System.Drawing.Color.Yellow;
            this.tagIO4.Location = new System.Drawing.Point(884, 229);
            this.tagIO4.ModuleName = null;
            this.tagIO4.Name = "tagIO4";
            this.tagIO4.Size = new System.Drawing.Size(46, 24);
            this.tagIO4.TabIndex = 83;
            this.tagIO4.Tag = "nGSM_Pwr_Ind";
            this.tagIO4.Text = "GSM Pwr";
            // 
            // tagIO3
            // 
            this.tagIO3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagIO3.Checked = false;
            this.tagIO3.ForeColor = System.Drawing.Color.Yellow;
            this.tagIO3.Location = new System.Drawing.Point(888, 199);
            this.tagIO3.ModuleName = null;
            this.tagIO3.Name = "tagIO3";
            this.tagIO3.Size = new System.Drawing.Size(34, 24);
            this.tagIO3.TabIndex = 82;
            this.tagIO3.Tag = "nChg_Det_In";
            this.tagIO3.Text = "Chrg";
            // 
            // tagIO2
            // 
            this.tagIO2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagIO2.Checked = false;
            this.tagIO2.ForeColor = System.Drawing.Color.Yellow;
            this.tagIO2.Location = new System.Drawing.Point(888, 169);
            this.tagIO2.ModuleName = null;
            this.tagIO2.Name = "tagIO2";
            this.tagIO2.Size = new System.Drawing.Size(34, 24);
            this.tagIO2.TabIndex = 81;
            this.tagIO2.Tag = "nManager_Button";
            this.tagIO2.Text = "Mgr";
            // 
            // tagIO1
            // 
            this.tagIO1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagIO1.Checked = false;
            this.tagIO1.ForeColor = System.Drawing.Color.Yellow;
            this.tagIO1.Location = new System.Drawing.Point(888, 139);
            this.tagIO1.ModuleName = null;
            this.tagIO1.Name = "tagIO1";
            this.tagIO1.Size = new System.Drawing.Size(34, 24);
            this.tagIO1.TabIndex = 80;
            this.tagIO1.Tag = "nGSM_CTS0";
            this.tagIO1.Text = "CTS";
            // 
            // ioState3
            // 
            this.ioState3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ioState3.Checked = false;
            this.ioState3.ForeColor = System.Drawing.Color.Yellow;
            this.ioState3.Location = new System.Drawing.Point(888, 88);
            this.ioState3.ModuleName = null;
            this.ioState3.Name = "ioState3";
            this.ioState3.Size = new System.Drawing.Size(34, 24);
            this.ioState3.TabIndex = 78;
            this.ioState3.Tag = "PIN_GSM_FAST_SHUTDOWN";
            this.ioState3.Text = "FSD";
            // 
            // ioState2
            // 
            this.ioState2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ioState2.Checked = false;
            this.ioState2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ioState2.Location = new System.Drawing.Point(888, 58);
            this.ioState2.ModuleName = null;
            this.ioState2.Name = "ioState2";
            this.ioState2.Size = new System.Drawing.Size(34, 24);
            this.ioState2.TabIndex = 77;
            this.ioState2.Tag = "PIN_GSM_RESET";
            this.ioState2.Text = "Reset";
            // 
            // ioState1
            // 
            this.ioState1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ioState1.Checked = false;
            this.ioState1.ForeColor = System.Drawing.Color.Red;
            this.ioState1.Location = new System.Drawing.Point(888, 28);
            this.ioState1.ModuleName = null;
            this.ioState1.Name = "ioState1";
            this.ioState1.Size = new System.Drawing.Size(34, 24);
            this.ioState1.TabIndex = 76;
            this.ioState1.Tag = "PIN_GSM_ON2";
            this.ioState1.Text = "On2";
            // 
            // tagText3
            // 
            this.tagText3.Location = new System.Drawing.Point(245, 30);
            this.tagText3.ModuleName = null;
            this.tagText3.Multiline = true;
            this.tagText3.Name = "tagText3";
            this.tagText3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tagText3.Size = new System.Drawing.Size(201, 284);
            this.tagText3.TabIndex = 74;
            this.tagText3.Tag = "modem_state";
            // 
            // tagState5
            // 
            this.tagState5.Checked = false;
            this.tagState5.Location = new System.Drawing.Point(26, 291);
            this.tagState5.ModuleName = null;
            this.tagState5.Name = "tagState5";
            this.tagState5.Size = new System.Drawing.Size(213, 23);
            this.tagState5.TabIndex = 73;
            this.tagState5.Tag = "modem_state";
            this.tagState5.Text = "MODEM_TURNING_OFF";
            // 
            // tagState6
            // 
            this.tagState6.Checked = false;
            this.tagState6.Location = new System.Drawing.Point(26, 262);
            this.tagState6.ModuleName = null;
            this.tagState6.Name = "tagState6";
            this.tagState6.Size = new System.Drawing.Size(213, 23);
            this.tagState6.TabIndex = 72;
            this.tagState6.Tag = "modem_state";
            this.tagState6.Text = "MODEM_RUNNING_JAVA";
            // 
            // tagState1
            // 
            this.tagState1.Checked = false;
            this.tagState1.Location = new System.Drawing.Point(26, 175);
            this.tagState1.ModuleName = null;
            this.tagState1.Name = "tagState1";
            this.tagState1.Size = new System.Drawing.Size(213, 23);
            this.tagState1.TabIndex = 69;
            this.tagState1.Tag = "modem_state";
            this.tagState1.Text = "MODEM_RUNNING_AT";
            // 
            // tagState2
            // 
            this.tagState2.Checked = false;
            this.tagState2.Location = new System.Drawing.Point(26, 233);
            this.tagState2.ModuleName = null;
            this.tagState2.Name = "tagState2";
            this.tagState2.Size = new System.Drawing.Size(213, 23);
            this.tagState2.TabIndex = 71;
            this.tagState2.Tag = "modem_state";
            this.tagState2.Text = "MODEM_STARTING_JAVA_MSG";
            // 
            // tagState3
            // 
            this.tagState3.Checked = false;
            this.tagState3.Location = new System.Drawing.Point(26, 146);
            this.tagState3.ModuleName = null;
            this.tagState3.Name = "tagState3";
            this.tagState3.Size = new System.Drawing.Size(213, 23);
            this.tagState3.TabIndex = 68;
            this.tagState3.Tag = "modem_state";
            this.tagState3.Text = "MODEM_STARTING_AT_MSG";
            // 
            // tagState4
            // 
            this.tagState4.Checked = false;
            this.tagState4.Location = new System.Drawing.Point(26, 204);
            this.tagState4.ModuleName = null;
            this.tagState4.Name = "tagState4";
            this.tagState4.Size = new System.Drawing.Size(213, 23);
            this.tagState4.TabIndex = 70;
            this.tagState4.Tag = "modem_state";
            this.tagState4.Text = "MODEM_STARTING_JAVA";
            // 
            // stateButton2
            // 
            this.stateButton2.Checked = false;
            this.stateButton2.Location = new System.Drawing.Point(26, 59);
            this.stateButton2.ModuleName = null;
            this.stateButton2.Name = "stateButton2";
            this.stateButton2.Size = new System.Drawing.Size(213, 23);
            this.stateButton2.TabIndex = 65;
            this.stateButton2.Tag = "modem_state";
            this.stateButton2.Text = "MODEM_INIT";
            // 
            // stateButton4
            // 
            this.stateButton4.Checked = false;
            this.stateButton4.Location = new System.Drawing.Point(26, 117);
            this.stateButton4.ModuleName = null;
            this.stateButton4.Name = "stateButton4";
            this.stateButton4.Size = new System.Drawing.Size(213, 23);
            this.stateButton4.TabIndex = 67;
            this.stateButton4.Tag = "modem_state";
            this.stateButton4.Text = "MODEM_STARTING_AT";
            // 
            // stateButton1
            // 
            this.stateButton1.BackColor = System.Drawing.SystemColors.Control;
            this.stateButton1.Checked = false;
            this.stateButton1.Location = new System.Drawing.Point(26, 30);
            this.stateButton1.ModuleName = null;
            this.stateButton1.Name = "stateButton1";
            this.stateButton1.Size = new System.Drawing.Size(213, 23);
            this.stateButton1.TabIndex = 64;
            this.stateButton1.Tag = "modem_state";
            this.stateButton1.Text = "MODEM_OFF";
            // 
            // stateButton3
            // 
            this.stateButton3.Checked = false;
            this.stateButton3.Location = new System.Drawing.Point(26, 88);
            this.stateButton3.ModuleName = null;
            this.stateButton3.Name = "stateButton3";
            this.stateButton3.Size = new System.Drawing.Size(213, 23);
            this.stateButton3.TabIndex = 66;
            this.stateButton3.Tag = "modem_state";
            this.stateButton3.Text = "MODEM_LOW_VOLTAGE";
            // 
            // aGauge4
            // 
            this.aGauge4.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge4.BaseArcRadius = 150;
            this.aGauge4.BaseArcStart = 120;
            this.aGauge4.BaseArcSweep = 120;
            this.aGauge4.BaseArcWidth = 2;
            this.aGauge4.Cap_Idx = ((byte)(1));
            this.aGauge4.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge4.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge4.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge4.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge4.CapText = "";
            this.aGauge4.Center = new System.Drawing.Point(175, 160);
            this.aGauge4.Location = new System.Drawing.Point(253, 17);
            this.aGauge4.MaxValue = 55F;
            this.aGauge4.MinValue = -55F;
            this.aGauge4.ModuleName = null;
            this.aGauge4.Name = "aGauge4";
            this.aGauge4.NeedleColor1 = Mettle.TagGauge.NeedleColorEnum.Blue;
            this.aGauge4.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge4.NeedleRadius = 160;
            this.aGauge4.NeedleType = 0;
            this.aGauge4.NeedleWidth = 2;
            this.aGauge4.Range_Idx = ((byte)(1));
            this.aGauge4.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.aGauge4.RangeEnabled = true;
            this.aGauge4.RangeEndValue = 15F;
            this.aGauge4.RangeInnerRadius = 10;
            this.aGauge4.RangeOuterRadius = 150;
            this.aGauge4.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge4.RangesEnabled = new bool[] {
        false,
        true,
        false,
        false,
        false};
            this.aGauge4.RangesEndValue = new float[] {
        300F,
        15F,
        0F,
        0F,
        0F};
            this.aGauge4.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge4.RangesOuterRadius = new int[] {
        80,
        150,
        80,
        80,
        80};
            this.aGauge4.RangesStartValue = new float[] {
        -100F,
        -15F,
        0F,
        0F,
        0F};
            this.aGauge4.RangeStartValue = -15F;
            this.aGauge4.ScaleLinesInterColor = System.Drawing.Color.Red;
            this.aGauge4.ScaleLinesInterInnerRadius = 145;
            this.aGauge4.ScaleLinesInterOuterRadius = 150;
            this.aGauge4.ScaleLinesInterWidth = 2;
            this.aGauge4.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge4.ScaleLinesMajorInnerRadius = 140;
            this.aGauge4.ScaleLinesMajorOuterRadius = 150;
            this.aGauge4.ScaleLinesMajorStepValue = 10F;
            this.aGauge4.ScaleLinesMajorWidth = 2;
            this.aGauge4.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge4.ScaleLinesMinorInnerRadius = 145;
            this.aGauge4.ScaleLinesMinorNumOf = 9;
            this.aGauge4.ScaleLinesMinorOuterRadius = 150;
            this.aGauge4.ScaleLinesMinorWidth = 1;
            this.aGauge4.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge4.ScaleNumbersFormat = null;
            this.aGauge4.ScaleNumbersRadius = 162;
            this.aGauge4.ScaleNumbersRotation = 90;
            this.aGauge4.ScaleNumbersStartScaleLine = 1;
            this.aGauge4.ScaleNumbersStepScaleLines = 2;
            this.aGauge4.Size = new System.Drawing.Size(135, 324);
            this.aGauge4.TabIndex = 8;
            this.aGauge4.Text = "aGauge4";
            this.aGauge4.Value = 0F;
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
        private TagGauge aGauge4;
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
        private TagIO tagIO5;
        private TagIO tagIO4;
        private TagIO tagIO3;
        private TagIO tagIO2;
        private TagIO tagIO1;
        private System.Windows.Forms.Label label6;
        private TagIO ioState3;
        private TagIO ioState2;
        private TagIO ioState1;
        private System.Windows.Forms.Label label4;
        private TagText tagText3;
        private TagState tagState5;
        private TagState tagState6;
        private TagState tagState1;
        private TagState tagState2;
        private TagState tagState3;
        private TagState tagState4;
        private TagState stateButton2;
        private TagState stateButton4;
        private TagState stateButton1;
        private TagState stateButton3;
        private System.Windows.Forms.ToolStripButton BtnReset;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripStatus;
        private System.Windows.Forms.ToolStripStatusLabel stripError;
    }
}

