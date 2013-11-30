namespace Charter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabChart = new System.Windows.Forms.TabPage();
            this.tabText = new System.Windows.Forms.TabPage();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPlay = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.btnTools = new System.Windows.Forms.ToolStripButton();
            this.txtAllText = new System.Windows.Forms.TextBox();
            this.stateButton2 = new Charter.TagState();
            this.tagChart1 = new Charter.TagChart();
            this.stateButton4 = new Charter.TagState();
            this.stateButton1 = new Charter.TagState();
            this.tagText5 = new Charter.TagText();
            this.stateButton3 = new Charter.TagState();
            this.tagText4 = new Charter.TagText();
            this.tagText3 = new Charter.TagText();
            this.tagText2 = new Charter.TagText();
            this.tagText1 = new Charter.TagText();
            this.ioState3 = new Charter.TagIO();
            this.ioState2 = new Charter.TagIO();
            this.aGauge3 = new Charter.TagGauge();
            this.ioState1 = new Charter.TagIO();
            this.aGauge5 = new Charter.TagGauge();
            this.aGauge4 = new Charter.TagGauge();
            this.tabMain.SuspendLayout();
            this.tabChart.SuspendLayout();
            this.tabText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagChart1)).BeginInit();
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
            this.tabChart.Controls.Add(this.stateButton2);
            this.tabChart.Controls.Add(this.tagChart1);
            this.tabChart.Controls.Add(this.stateButton4);
            this.tabChart.Controls.Add(this.stateButton1);
            this.tabChart.Controls.Add(this.tagText5);
            this.tabChart.Controls.Add(this.stateButton3);
            this.tabChart.Controls.Add(this.tagText4);
            this.tabChart.Controls.Add(this.tagText3);
            this.tabChart.Controls.Add(this.tagText2);
            this.tabChart.Controls.Add(this.tagText1);
            this.tabChart.Controls.Add(this.ioState3);
            this.tabChart.Controls.Add(this.ioState2);
            this.tabChart.Controls.Add(this.aGauge3);
            this.tabChart.Controls.Add(this.ioState1);
            this.tabChart.Controls.Add(this.aGauge5);
            this.tabChart.Location = new System.Drawing.Point(4, 22);
            this.tabChart.Name = "tabChart";
            this.tabChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabChart.Size = new System.Drawing.Size(982, 516);
            this.tabChart.TabIndex = 1;
            this.tabChart.Tag = "Right";
            this.tabChart.Text = "Chart";
            // 
            // tabText
            // 
            this.tabText.Controls.Add(this.txtAllText);
            this.tabText.Location = new System.Drawing.Point(4, 22);
            this.tabText.Name = "tabText";
            this.tabText.Padding = new System.Windows.Forms.Padding(3);
            this.tabText.Size = new System.Drawing.Size(982, 516);
            this.tabText.TabIndex = 0;
            this.tabText.Text = "Text";
            this.tabText.UseVisualStyleBackColor = true;
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
            this.btnTools});
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
            // txtAllText
            // 
            this.txtAllText.AcceptsReturn = true;
            this.txtAllText.Location = new System.Drawing.Point(8, 6);
            this.txtAllText.Multiline = true;
            this.txtAllText.Name = "txtAllText";
            this.txtAllText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAllText.Size = new System.Drawing.Size(322, 423);
            this.txtAllText.TabIndex = 0;
            // 
            // stateButton2
            // 
            this.stateButton2.Checked = false;
            this.stateButton2.Location = new System.Drawing.Point(223, 88);
            this.stateButton2.Name = "stateButton2";
            this.stateButton2.Size = new System.Drawing.Size(75, 23);
            this.stateButton2.TabIndex = 40;
            this.stateButton2.Tag = "This";
            this.stateButton2.Text = "State2";
            // 
            // tagChart1
            // 
            this.tagChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.MajorGrid.Interval = 10D;
            chartArea1.AxisX.Maximum = 500D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.MinorGrid.Interval = 1D;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.Maximum = 896D;
            chartArea1.AxisY.Minimum = 128D;
            chartArea1.Name = "main";
            this.tagChart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.tagChart1.Legends.Add(legend1);
            this.tagChart1.Location = new System.Drawing.Point(0, 268);
            this.tagChart1.Name = "tagChart1";
            this.tagChart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "main";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.CustomProperties = "index=0";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "XAxis";
            series1.ShadowColor = System.Drawing.Color.Black;
            series2.ChartArea = "main";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.CustomProperties = "index=0";
            series2.Legend = "Legend1";
            series2.Name = "YAxis";
            series3.ChartArea = "main";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.CustomProperties = "index=0";
            series3.Legend = "Legend1";
            series3.Name = "ZAxis";
            this.tagChart1.Series.Add(series1);
            this.tagChart1.Series.Add(series2);
            this.tagChart1.Series.Add(series3);
            this.tagChart1.Size = new System.Drawing.Size(979, 245);
            this.tagChart1.TabIndex = 53;
            this.tagChart1.Tag = "";
            this.tagChart1.Text = "tagChart1";
            this.tagChart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // stateButton4
            // 
            this.stateButton4.Checked = false;
            this.stateButton4.Location = new System.Drawing.Point(319, 88);
            this.stateButton4.Name = "stateButton4";
            this.stateButton4.Size = new System.Drawing.Size(72, 23);
            this.stateButton4.TabIndex = 42;
            this.stateButton4.Tag = "This";
            this.stateButton4.Text = "State4";
            // 
            // stateButton1
            // 
            this.stateButton1.Checked = false;
            this.stateButton1.Location = new System.Drawing.Point(242, 30);
            this.stateButton1.Name = "stateButton1";
            this.stateButton1.Size = new System.Drawing.Size(75, 23);
            this.stateButton1.TabIndex = 39;
            this.stateButton1.Tag = "This";
            this.stateButton1.Text = "State1";
            // 
            // tagText5
            // 
            this.tagText5.Location = new System.Drawing.Point(233, 6);
            this.tagText5.Name = "tagText5";
            this.tagText5.Size = new System.Drawing.Size(100, 20);
            this.tagText5.TabIndex = 52;
            this.tagText5.Tag = "This";
            // 
            // stateButton3
            // 
            this.stateButton3.Checked = false;
            this.stateButton3.Location = new System.Drawing.Point(280, 59);
            this.stateButton3.Name = "stateButton3";
            this.stateButton3.Size = new System.Drawing.Size(75, 23);
            this.stateButton3.TabIndex = 41;
            this.stateButton3.Tag = "This";
            this.stateButton3.Text = "State3";
            // 
            // tagText4
            // 
            this.tagText4.AcceptsReturn = true;
            this.tagText4.AcceptsTab = true;
            this.tagText4.Location = new System.Drawing.Point(588, 59);
            this.tagText4.Multiline = true;
            this.tagText4.Name = "tagText4";
            this.tagText4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tagText4.Size = new System.Drawing.Size(189, 168);
            this.tagText4.TabIndex = 50;
            this.tagText4.Tag = "*";
            // 
            // tagText3
            // 
            this.tagText3.AcceptsReturn = true;
            this.tagText3.AcceptsTab = true;
            this.tagText3.Location = new System.Drawing.Point(209, 135);
            this.tagText3.Multiline = true;
            this.tagText3.Name = "tagText3";
            this.tagText3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tagText3.Size = new System.Drawing.Size(189, 127);
            this.tagText3.TabIndex = 49;
            this.tagText3.Tag = "This";
            // 
            // tagText2
            // 
            this.tagText2.AcceptsReturn = true;
            this.tagText2.AcceptsTab = true;
            this.tagText2.Location = new System.Drawing.Point(800, 30);
            this.tagText2.Multiline = true;
            this.tagText2.Name = "tagText2";
            this.tagText2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tagText2.Size = new System.Drawing.Size(74, 153);
            this.tagText2.TabIndex = 48;
            this.tagText2.Tag = "Right";
            // 
            // tagText1
            // 
            this.tagText1.AcceptsReturn = true;
            this.tagText1.AcceptsTab = true;
            this.tagText1.Location = new System.Drawing.Point(108, 30);
            this.tagText1.Multiline = true;
            this.tagText1.Name = "tagText1";
            this.tagText1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tagText1.Size = new System.Drawing.Size(72, 153);
            this.tagText1.TabIndex = 47;
            this.tagText1.Tag = "Left";
            // 
            // ioState3
            // 
            this.ioState3.Checked = false;
            this.ioState3.ForeColor = System.Drawing.Color.Yellow;
            this.ioState3.Location = new System.Drawing.Point(552, 16);
            this.ioState3.Name = "ioState3";
            this.ioState3.Size = new System.Drawing.Size(38, 24);
            this.ioState3.TabIndex = 46;
            this.ioState3.Tag = "LED3";
            // 
            // ioState2
            // 
            this.ioState2.Checked = false;
            this.ioState2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ioState2.Location = new System.Drawing.Point(509, 16);
            this.ioState2.Name = "ioState2";
            this.ioState2.Size = new System.Drawing.Size(37, 24);
            this.ioState2.TabIndex = 45;
            this.ioState2.Tag = "LED2";
            // 
            // aGauge3
            // 
            this.aGauge3.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge3.BaseArcRadius = 150;
            this.aGauge3.BaseArcStart = 145;
            this.aGauge3.BaseArcSweep = 70;
            this.aGauge3.BaseArcWidth = 2;
            this.aGauge3.Cap_Idx = ((byte)(1));
            this.aGauge3.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge3.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge3.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge3.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge3.CapText = "";
            this.aGauge3.Center = new System.Drawing.Point(175, 110);
            this.aGauge3.Location = new System.Drawing.Point(8, 6);
            this.aGauge3.MaxValue = 1024F;
            this.aGauge3.MinValue = 0F;
            this.aGauge3.Name = "aGauge3";
            this.aGauge3.NeedleColor1 = Charter.TagGauge.NeedleColorEnum.Red;
            this.aGauge3.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge3.NeedleRadius = 160;
            this.aGauge3.NeedleType = 0;
            this.aGauge3.NeedleWidth = 2;
            this.aGauge3.Range_Idx = ((byte)(1));
            this.aGauge3.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.aGauge3.RangeEnabled = true;
            this.aGauge3.RangeEndValue = 55F;
            this.aGauge3.RangeInnerRadius = 140;
            this.aGauge3.RangeOuterRadius = 150;
            this.aGauge3.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge3.RangesEnabled = new bool[] {
        false,
        true,
        false,
        false,
        false};
            this.aGauge3.RangesEndValue = new float[] {
        300F,
        55F,
        0F,
        0F,
        0F};
            this.aGauge3.RangesInnerRadius = new int[] {
        70,
        140,
        70,
        70,
        70};
            this.aGauge3.RangesOuterRadius = new int[] {
        80,
        150,
        80,
        80,
        80};
            this.aGauge3.RangesStartValue = new float[] {
        -100F,
        45F,
        0F,
        0F,
        0F};
            this.aGauge3.RangeStartValue = 45F;
            this.aGauge3.ScaleLinesInterColor = System.Drawing.Color.Red;
            this.aGauge3.ScaleLinesInterInnerRadius = 145;
            this.aGauge3.ScaleLinesInterOuterRadius = 150;
            this.aGauge3.ScaleLinesInterWidth = 2;
            this.aGauge3.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesMajorInnerRadius = 140;
            this.aGauge3.ScaleLinesMajorOuterRadius = 150;
            this.aGauge3.ScaleLinesMajorStepValue = 128F;
            this.aGauge3.ScaleLinesMajorWidth = 2;
            this.aGauge3.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge3.ScaleLinesMinorInnerRadius = 145;
            this.aGauge3.ScaleLinesMinorNumOf = 9;
            this.aGauge3.ScaleLinesMinorOuterRadius = 150;
            this.aGauge3.ScaleLinesMinorWidth = 1;
            this.aGauge3.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleNumbersFormat = null;
            this.aGauge3.ScaleNumbersRadius = 162;
            this.aGauge3.ScaleNumbersRotation = 90;
            this.aGauge3.ScaleNumbersStartScaleLine = 1;
            this.aGauge3.ScaleNumbersStepScaleLines = 2;
            this.aGauge3.Size = new System.Drawing.Size(94, 221);
            this.aGauge3.TabIndex = 13;
            this.aGauge3.Tag = "XAxis";
            this.aGauge3.Value = 0F;
            // 
            // ioState1
            // 
            this.ioState1.Checked = false;
            this.ioState1.ForeColor = System.Drawing.Color.Red;
            this.ioState1.Location = new System.Drawing.Point(469, 16);
            this.ioState1.Name = "ioState1";
            this.ioState1.Size = new System.Drawing.Size(34, 24);
            this.ioState1.TabIndex = 44;
            this.ioState1.Tag = "PushButton";
            // 
            // aGauge5
            // 
            this.aGauge5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aGauge5.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge5.BaseArcRadius = 150;
            this.aGauge5.BaseArcStart = 35;
            this.aGauge5.BaseArcSweep = -70;
            this.aGauge5.BaseArcWidth = 2;
            this.aGauge5.Cap_Idx = ((byte)(1));
            this.aGauge5.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge5.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge5.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge5.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge5.CapText = "";
            this.aGauge5.Center = new System.Drawing.Point(-80, 110);
            this.aGauge5.Location = new System.Drawing.Point(880, 6);
            this.aGauge5.MaxValue = 1024F;
            this.aGauge5.MinValue = 0F;
            this.aGauge5.Name = "aGauge5";
            this.aGauge5.NeedleColor1 = Charter.TagGauge.NeedleColorEnum.Blue;
            this.aGauge5.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge5.NeedleRadius = 160;
            this.aGauge5.NeedleType = 0;
            this.aGauge5.NeedleWidth = 2;
            this.aGauge5.Range_Idx = ((byte)(1));
            this.aGauge5.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.aGauge5.RangeEnabled = true;
            this.aGauge5.RangeEndValue = 55F;
            this.aGauge5.RangeInnerRadius = 140;
            this.aGauge5.RangeOuterRadius = 150;
            this.aGauge5.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge5.RangesEnabled = new bool[] {
        false,
        true,
        false,
        false,
        false};
            this.aGauge5.RangesEndValue = new float[] {
        300F,
        55F,
        0F,
        0F,
        0F};
            this.aGauge5.RangesInnerRadius = new int[] {
        70,
        140,
        70,
        70,
        70};
            this.aGauge5.RangesOuterRadius = new int[] {
        80,
        150,
        80,
        80,
        80};
            this.aGauge5.RangesStartValue = new float[] {
        -100F,
        45F,
        0F,
        0F,
        0F};
            this.aGauge5.RangeStartValue = 45F;
            this.aGauge5.ScaleLinesInterColor = System.Drawing.Color.Red;
            this.aGauge5.ScaleLinesInterInnerRadius = 145;
            this.aGauge5.ScaleLinesInterOuterRadius = 150;
            this.aGauge5.ScaleLinesInterWidth = 2;
            this.aGauge5.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge5.ScaleLinesMajorInnerRadius = 140;
            this.aGauge5.ScaleLinesMajorOuterRadius = 150;
            this.aGauge5.ScaleLinesMajorStepValue = 128F;
            this.aGauge5.ScaleLinesMajorWidth = 2;
            this.aGauge5.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge5.ScaleLinesMinorInnerRadius = 145;
            this.aGauge5.ScaleLinesMinorNumOf = 9;
            this.aGauge5.ScaleLinesMinorOuterRadius = 150;
            this.aGauge5.ScaleLinesMinorWidth = 1;
            this.aGauge5.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge5.ScaleNumbersFormat = null;
            this.aGauge5.ScaleNumbersRadius = 162;
            this.aGauge5.ScaleNumbersRotation = 90;
            this.aGauge5.ScaleNumbersStartScaleLine = 1;
            this.aGauge5.ScaleNumbersStepScaleLines = 2;
            this.aGauge5.Size = new System.Drawing.Size(96, 200);
            this.aGauge5.TabIndex = 14;
            this.aGauge5.Tag = "YAxis";
            this.aGauge5.Value = 0F;
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
            this.aGauge4.Name = "aGauge4";
            this.aGauge4.NeedleColor1 = Charter.TagGauge.NeedleColorEnum.Blue;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 569);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabMain);
            this.MinimumSize = new System.Drawing.Size(908, 455);
            this.Name = "Form1";
            this.Text = "Arduino Charting Tool";
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
            ((System.ComponentModel.ISupportInitialize)(this.tagChart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabText;
        private System.Windows.Forms.TabPage tabChart;
        private System.IO.Ports.SerialPort serialPort1;
        private TagGauge aGauge4;
        private TagIO ioState3;
        private TagIO ioState2;
        private TagGauge aGauge3;
        private TagIO ioState1;
        private TagGauge aGauge5;
        private TagState stateButton2;
        private TagState stateButton4;
        private TagState stateButton1;
        private TagState stateButton3;
        private TagText tagText2;
        private TagText tagText1;
        private TagText tagText3;
        private TagText tagText4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private TagText tagText5;
        private TagChart tagChart1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPlay;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripButton btnTools;
        private System.Windows.Forms.TextBox txtAllText;
    }
}

