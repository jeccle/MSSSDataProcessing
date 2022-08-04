using System.Windows.Forms;

namespace MSSSDataProcessing
{
    partial class ProcessingForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listViewDisplay = new System.Windows.Forms.ListView();
            this.ColumnA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBoxSensorA = new System.Windows.Forms.ListBox();
            this.numWheelSigma = new System.Windows.Forms.NumericUpDown();
            this.numWheelMean = new System.Windows.Forms.NumericUpDown();
            this.groupBoxA = new System.Windows.Forms.GroupBox();
            this.SortGrpBoxA = new System.Windows.Forms.GroupBox();
            this.checkBoxSensorA = new System.Windows.Forms.CheckBox();
            this.radioInsertionA = new System.Windows.Forms.RadioButton();
            this.radioSelectionA = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSortA = new System.Windows.Forms.Button();
            this.textBoxSortSpdA = new System.Windows.Forms.TextBox();
            this.SearchGrpBoxA = new System.Windows.Forms.GroupBox();
            this.textBoxDifferenceA = new System.Windows.Forms.TextBox();
            this.numWheelSelectionRangeA = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSearchSpdA = new System.Windows.Forms.TextBox();
            this.searchLabelA = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numWheelValueRangeA = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTargetA = new System.Windows.Forms.TextBox();
            this.radioRecursiveA = new System.Windows.Forms.RadioButton();
            this.radioIterativeA = new System.Windows.Forms.RadioButton();
            this.buttonSearchA = new System.Windows.Forms.Button();
            this.groupBoxB = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxSensorB = new System.Windows.Forms.CheckBox();
            this.radioInsertionB = new System.Windows.Forms.RadioButton();
            this.radioSelectionB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSortB = new System.Windows.Forms.Button();
            this.textBoxSortSpdB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDifferenceB = new System.Windows.Forms.TextBox();
            this.numWheelSelectionRangeB = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numWheelValueRangeB = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTargetB = new System.Windows.Forms.TextBox();
            this.radioRecursiveB = new System.Windows.Forms.RadioButton();
            this.radioIterativeB = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearchB = new System.Windows.Forms.Button();
            this.textBoxSearchSpdB = new System.Windows.Forms.TextBox();
            this.listBoxSensorB = new System.Windows.Forms.ListBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSortProcessingA = new System.Windows.Forms.Button();
            this.numWheelSelectionRangeProcessingA = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numWheelValueRangeProcessingA = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxTargetProcessingA = new System.Windows.Forms.TextBox();
            this.buttonSearchProcessingA = new System.Windows.Forms.Button();
            this.buttonSortProcessingB = new System.Windows.Forms.Button();
            this.numWheelSelectionRangeProcessingB = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.numWheelValueRangeProcessingB = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxTargetProcessingB = new System.Windows.Forms.TextBox();
            this.buttonSearchProcessingB = new System.Windows.Forms.Button();
            this.textBoxHighlightProcessingSpdB = new System.Windows.Forms.TextBox();
            this.textBoxRecursiveSearchSpdB = new System.Windows.Forms.TextBox();
            this.textBoxIterativeSearchSpdB = new System.Windows.Forms.TextBox();
            this.textBoxInsertionSortProcessingB = new System.Windows.Forms.TextBox();
            this.textBoxSelectionSortProcessingB = new System.Windows.Forms.TextBox();
            this.listBoxSensorProcessingB = new System.Windows.Forms.ListBox();
            this.textBoxInsertionSortProcessingA = new System.Windows.Forms.TextBox();
            this.textBoxSelectionSortProcessingA = new System.Windows.Forms.TextBox();
            this.textBoxHighlightProcessingSpdA = new System.Windows.Forms.TextBox();
            this.textBoxRecursiveSearchSpdA = new System.Windows.Forms.TextBox();
            this.textBoxIterativeSearchSpdA = new System.Windows.Forms.TextBox();
            this.listBoxSensorProcessingA = new System.Windows.Forms.ListBox();
            this.buttonColumn = new System.Windows.Forms.Button();
            this.textBoxInsertionSortVisual = new System.Windows.Forms.TextBox();
            this.textBoxSelectionSortVisual = new System.Windows.Forms.TextBox();
            this.listBoxSensorVisualA = new System.Windows.Forms.ListBox();
            this.listBoxSensorVisualB = new System.Windows.Forms.ListBox();
            this.numWheelDistribution = new System.Windows.Forms.NumericUpDown();
            this.numWheelSigmaVisual = new System.Windows.Forms.NumericUpDown();
            this.numWheelMeanVisual = new System.Windows.Forms.NumericUpDown();
            this.checkBoxSortProcessingB = new System.Windows.Forms.CheckBox();
            this.buttonLoadProcessing = new System.Windows.Forms.Button();
            this.checkBoxSortProcessingA = new System.Windows.Forms.CheckBox();
            this.checkBoxSensorProcessingB = new System.Windows.Forms.CheckBox();
            this.checkBoxSensorProcessingA = new System.Windows.Forms.CheckBox();
            this.chartSensorA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSensorB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.buttonLoadVisual = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabProcess = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabVisual = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelMean)).BeginInit();
            this.groupBoxA.SuspendLayout();
            this.SortGrpBoxA.SuspendLayout();
            this.SearchGrpBoxA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelSelectionRangeA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelValueRangeA)).BeginInit();
            this.groupBoxB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelSelectionRangeB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelValueRangeB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelSelectionRangeProcessingA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelValueRangeProcessingA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelSelectionRangeProcessingB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelValueRangeProcessingB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelDistribution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelSigmaVisual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelMeanVisual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensorA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensorB)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabProcess.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabVisual.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewDisplay
            // 
            this.listViewDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnA,
            this.ColumnB});
            this.listViewDisplay.GridLines = true;
            this.listViewDisplay.HideSelection = false;
            this.listViewDisplay.Location = new System.Drawing.Point(602, 67);
            this.listViewDisplay.Name = "listViewDisplay";
            this.listViewDisplay.Size = new System.Drawing.Size(154, 278);
            this.listViewDisplay.TabIndex = 0;
            this.listViewDisplay.UseCompatibleStateImageBehavior = false;
            this.listViewDisplay.View = System.Windows.Forms.View.Details;
            // 
            // ColumnA
            // 
            this.ColumnA.Text = "Sensor A";
            this.ColumnA.Width = 74;
            // 
            // ColumnB
            // 
            this.ColumnB.Text = "Sensor B";
            this.ColumnB.Width = 76;
            // 
            // listBoxSensorA
            // 
            this.listBoxSensorA.FormattingEnabled = true;
            this.listBoxSensorA.Location = new System.Drawing.Point(15, 20);
            this.listBoxSensorA.Name = "listBoxSensorA";
            this.listBoxSensorA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSensorA.Size = new System.Drawing.Size(91, 316);
            this.listBoxSensorA.TabIndex = 1;
            this.toolTip.SetToolTip(this.listBoxSensorA, "List display for Sensor A Data");
            this.listBoxSensorA.Enter += new System.EventHandler(this.listBoxSensorA_MouseMove);
            // 
            // numWheelSigma
            // 
            this.numWheelSigma.Location = new System.Drawing.Point(641, 11);
            this.numWheelSigma.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numWheelSigma.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWheelSigma.Name = "numWheelSigma";
            this.numWheelSigma.Size = new System.Drawing.Size(41, 20);
            this.numWheelSigma.TabIndex = 18;
            this.toolTip.SetToolTip(this.numWheelSigma, "Standard Deviation\r\nSets the range in which the values will deviate from\r\nthe mea" +
        "n.");
            this.numWheelSigma.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numWheelMean
            // 
            this.numWheelMean.Location = new System.Drawing.Point(641, 37);
            this.numWheelMean.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numWheelMean.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numWheelMean.Name = "numWheelMean";
            this.numWheelMean.Size = new System.Drawing.Size(41, 20);
            this.numWheelMean.TabIndex = 19;
            this.toolTip.SetToolTip(this.numWheelMean, "Mean Value\r\nSets mean value of data set for both sensors.\r\n\r\n");
            this.numWheelMean.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // groupBoxA
            // 
            this.groupBoxA.Controls.Add(this.SortGrpBoxA);
            this.groupBoxA.Controls.Add(this.SearchGrpBoxA);
            this.groupBoxA.Controls.Add(this.listBoxSensorA);
            this.groupBoxA.Location = new System.Drawing.Point(8, 9);
            this.groupBoxA.Name = "groupBoxA";
            this.groupBoxA.Size = new System.Drawing.Size(285, 350);
            this.groupBoxA.TabIndex = 9;
            this.groupBoxA.TabStop = false;
            this.groupBoxA.Text = "Sensor A";
            // 
            // SortGrpBoxA
            // 
            this.SortGrpBoxA.Controls.Add(this.checkBoxSensorA);
            this.SortGrpBoxA.Controls.Add(this.radioInsertionA);
            this.SortGrpBoxA.Controls.Add(this.radioSelectionA);
            this.SortGrpBoxA.Controls.Add(this.label5);
            this.SortGrpBoxA.Controls.Add(this.buttonSortA);
            this.SortGrpBoxA.Controls.Add(this.textBoxSortSpdA);
            this.SortGrpBoxA.Location = new System.Drawing.Point(115, 20);
            this.SortGrpBoxA.Name = "SortGrpBoxA";
            this.SortGrpBoxA.Size = new System.Drawing.Size(160, 118);
            this.SortGrpBoxA.TabIndex = 11;
            this.SortGrpBoxA.TabStop = false;
            this.SortGrpBoxA.Text = "Sort";
            // 
            // checkBoxSensorA
            // 
            this.checkBoxSensorA.AutoSize = true;
            this.checkBoxSensorA.Enabled = false;
            this.checkBoxSensorA.Location = new System.Drawing.Point(90, 50);
            this.checkBoxSensorA.Name = "checkBoxSensorA";
            this.checkBoxSensorA.Size = new System.Drawing.Size(57, 17);
            this.checkBoxSensorA.TabIndex = 13;
            this.checkBoxSensorA.Text = "Sorted";
            this.toolTip.SetToolTip(this.checkBoxSensorA, "Displays if values are sorted.");
            this.checkBoxSensorA.UseVisualStyleBackColor = true;
            this.checkBoxSensorA.CheckedChanged += new System.EventHandler(this.checkBoxSensorA_CheckedChanged);
            // 
            // radioInsertionA
            // 
            this.radioInsertionA.AutoSize = true;
            this.radioInsertionA.Location = new System.Drawing.Point(12, 38);
            this.radioInsertionA.Name = "radioInsertionA";
            this.radioInsertionA.Size = new System.Drawing.Size(65, 17);
            this.radioInsertionA.TabIndex = 3;
            this.radioInsertionA.Text = "Insertion";
            this.toolTip.SetToolTip(this.radioInsertionA, "Use insertion sort algorithm");
            this.radioInsertionA.UseVisualStyleBackColor = true;
            // 
            // radioSelectionA
            // 
            this.radioSelectionA.AutoSize = true;
            this.radioSelectionA.Checked = true;
            this.radioSelectionA.Location = new System.Drawing.Point(12, 18);
            this.radioSelectionA.Name = "radioSelectionA";
            this.radioSelectionA.Size = new System.Drawing.Size(69, 17);
            this.radioSelectionA.TabIndex = 2;
            this.radioSelectionA.TabStop = true;
            this.radioSelectionA.Text = "Selection";
            this.toolTip.SetToolTip(this.radioSelectionA, "Use selection sort algorithm");
            this.radioSelectionA.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Processing Speed";
            // 
            // buttonSortA
            // 
            this.buttonSortA.Location = new System.Drawing.Point(91, 21);
            this.buttonSortA.Name = "buttonSortA";
            this.buttonSortA.Size = new System.Drawing.Size(56, 23);
            this.buttonSortA.TabIndex = 4;
            this.buttonSortA.Text = "Sort";
            this.toolTip.SetToolTip(this.buttonSortA, "Begin sort");
            this.buttonSortA.UseVisualStyleBackColor = true;
            this.buttonSortA.Click += new System.EventHandler(this.buttonSortA_Click);
            // 
            // textBoxSortSpdA
            // 
            this.textBoxSortSpdA.Enabled = false;
            this.textBoxSortSpdA.Location = new System.Drawing.Point(13, 83);
            this.textBoxSortSpdA.Name = "textBoxSortSpdA";
            this.textBoxSortSpdA.ReadOnly = true;
            this.textBoxSortSpdA.Size = new System.Drawing.Size(134, 20);
            this.textBoxSortSpdA.TabIndex = 9;
            this.toolTip.SetToolTip(this.textBoxSortSpdA, "Displays processing speed of sorting algorithms in milliseconds.");
            // 
            // SearchGrpBoxA
            // 
            this.SearchGrpBoxA.Controls.Add(this.textBoxDifferenceA);
            this.SearchGrpBoxA.Controls.Add(this.numWheelSelectionRangeA);
            this.SearchGrpBoxA.Controls.Add(this.label10);
            this.SearchGrpBoxA.Controls.Add(this.textBoxSearchSpdA);
            this.SearchGrpBoxA.Controls.Add(this.searchLabelA);
            this.SearchGrpBoxA.Controls.Add(this.label8);
            this.SearchGrpBoxA.Controls.Add(this.numWheelValueRangeA);
            this.SearchGrpBoxA.Controls.Add(this.label1);
            this.SearchGrpBoxA.Controls.Add(this.textBoxTargetA);
            this.SearchGrpBoxA.Controls.Add(this.radioRecursiveA);
            this.SearchGrpBoxA.Controls.Add(this.radioIterativeA);
            this.SearchGrpBoxA.Controls.Add(this.buttonSearchA);
            this.SearchGrpBoxA.Location = new System.Drawing.Point(115, 138);
            this.SearchGrpBoxA.Name = "SearchGrpBoxA";
            this.SearchGrpBoxA.Size = new System.Drawing.Size(160, 198);
            this.SearchGrpBoxA.TabIndex = 10;
            this.SearchGrpBoxA.TabStop = false;
            this.SearchGrpBoxA.Text = "Search";
            // 
            // textBoxDifferenceA
            // 
            this.textBoxDifferenceA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDifferenceA.Location = new System.Drawing.Point(10, 142);
            this.textBoxDifferenceA.Name = "textBoxDifferenceA";
            this.textBoxDifferenceA.ReadOnly = true;
            this.textBoxDifferenceA.Size = new System.Drawing.Size(137, 13);
            this.textBoxDifferenceA.TabIndex = 18;
            this.textBoxDifferenceA.Text = "Min:   |  Max:";
            this.textBoxDifferenceA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numWheelSelectionRangeA
            // 
            this.numWheelSelectionRangeA.Location = new System.Drawing.Point(105, 162);
            this.numWheelSelectionRangeA.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numWheelSelectionRangeA.Name = "numWheelSelectionRangeA";
            this.numWheelSelectionRangeA.Size = new System.Drawing.Size(41, 20);
            this.numWheelSelectionRangeA.TabIndex = 8;
            this.toolTip.SetToolTip(this.numWheelSelectionRangeA, "Sets total span of values to be included in the search (Stems from the target val" +
        "ue).");
            this.numWheelSelectionRangeA.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Selection Range:";
            this.toolTip.SetToolTip(this.label10, "Sets total span of values to be included in the search (Stems from the target val" +
        "ue).");
            // 
            // textBoxSearchSpdA
            // 
            this.textBoxSearchSpdA.Enabled = false;
            this.textBoxSearchSpdA.Location = new System.Drawing.Point(68, 64);
            this.textBoxSearchSpdA.Name = "textBoxSearchSpdA";
            this.textBoxSearchSpdA.ReadOnly = true;
            this.textBoxSearchSpdA.Size = new System.Drawing.Size(79, 20);
            this.textBoxSearchSpdA.TabIndex = 9;
            this.toolTip.SetToolTip(this.textBoxSearchSpdA, "Displays processing speed of binary searching algorithms in ticks.");
            // 
            // searchLabelA
            // 
            this.searchLabelA.AutoSize = true;
            this.searchLabelA.Location = new System.Drawing.Point(6, 60);
            this.searchLabelA.Name = "searchLabelA";
            this.searchLabelA.Size = new System.Drawing.Size(59, 26);
            this.searchLabelA.TabIndex = 10;
            this.searchLabelA.Text = "Processing\r\nSpeed";
            this.searchLabelA.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Data Value Range:";
            this.toolTip.SetToolTip(this.label8, "Specify value difference from target which will be selected.");
            // 
            // numWheelValueRangeA
            // 
            this.numWheelValueRangeA.DecimalPlaces = 1;
            this.numWheelValueRangeA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numWheelValueRangeA.Location = new System.Drawing.Point(105, 116);
            this.numWheelValueRangeA.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numWheelValueRangeA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numWheelValueRangeA.Name = "numWheelValueRangeA";
            this.numWheelValueRangeA.Size = new System.Drawing.Size(41, 20);
            this.numWheelValueRangeA.TabIndex = 7;
            this.toolTip.SetToolTip(this.numWheelValueRangeA, "Specify value difference from target which will be selected.");
            this.numWheelValueRangeA.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numWheelValueRangeA.ValueChanged += new System.EventHandler(this.numWheelValueRangeA_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Target:";
            this.toolTip.SetToolTip(this.label1, "Target value to be searched");
            // 
            // textBoxTargetA
            // 
            this.textBoxTargetA.Location = new System.Drawing.Point(91, 91);
            this.textBoxTargetA.Name = "textBoxTargetA";
            this.textBoxTargetA.Size = new System.Drawing.Size(56, 20);
            this.textBoxTargetA.TabIndex = 6;
            this.toolTip.SetToolTip(this.textBoxTargetA, "Target value to be found");
            this.textBoxTargetA.TextChanged += new System.EventHandler(this.textBoxTargetA_TextChanged);
            this.textBoxTargetA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTargetA_KeyPress);
            // 
            // radioRecursiveA
            // 
            this.radioRecursiveA.AutoSize = true;
            this.radioRecursiveA.Location = new System.Drawing.Point(12, 38);
            this.radioRecursiveA.Name = "radioRecursiveA";
            this.radioRecursiveA.Size = new System.Drawing.Size(73, 17);
            this.radioRecursiveA.TabIndex = 6;
            this.radioRecursiveA.Text = "Recursive";
            this.toolTip.SetToolTip(this.radioRecursiveA, "Use recursive search algorithm");
            this.radioRecursiveA.UseVisualStyleBackColor = true;
            // 
            // radioIterativeA
            // 
            this.radioIterativeA.AutoSize = true;
            this.radioIterativeA.Checked = true;
            this.radioIterativeA.Location = new System.Drawing.Point(12, 18);
            this.radioIterativeA.Name = "radioIterativeA";
            this.radioIterativeA.Size = new System.Drawing.Size(63, 17);
            this.radioIterativeA.TabIndex = 5;
            this.radioIterativeA.TabStop = true;
            this.radioIterativeA.Text = "Iterative";
            this.toolTip.SetToolTip(this.radioIterativeA, "Use iterative search algorithm");
            this.radioIterativeA.UseVisualStyleBackColor = true;
            // 
            // buttonSearchA
            // 
            this.buttonSearchA.Location = new System.Drawing.Point(90, 22);
            this.buttonSearchA.Name = "buttonSearchA";
            this.buttonSearchA.Size = new System.Drawing.Size(56, 23);
            this.buttonSearchA.TabIndex = 9;
            this.buttonSearchA.Text = "Search";
            this.toolTip.SetToolTip(this.buttonSearchA, "Search for Target");
            this.buttonSearchA.UseVisualStyleBackColor = true;
            this.buttonSearchA.Click += new System.EventHandler(this.buttonSearchA_Click);
            // 
            // groupBoxB
            // 
            this.groupBoxB.Controls.Add(this.groupBox2);
            this.groupBoxB.Controls.Add(this.groupBox1);
            this.groupBoxB.Controls.Add(this.listBoxSensorB);
            this.groupBoxB.Location = new System.Drawing.Point(304, 9);
            this.groupBoxB.Name = "groupBoxB";
            this.groupBoxB.Size = new System.Drawing.Size(285, 350);
            this.groupBoxB.TabIndex = 10;
            this.groupBoxB.TabStop = false;
            this.groupBoxB.Text = "Sensor B";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxSensorB);
            this.groupBox2.Controls.Add(this.radioInsertionB);
            this.groupBox2.Controls.Add(this.radioSelectionB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonSortB);
            this.groupBox2.Controls.Add(this.textBoxSortSpdB);
            this.groupBox2.Location = new System.Drawing.Point(115, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 118);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort";
            // 
            // checkBoxSensorB
            // 
            this.checkBoxSensorB.AutoSize = true;
            this.checkBoxSensorB.Enabled = false;
            this.checkBoxSensorB.Location = new System.Drawing.Point(90, 50);
            this.checkBoxSensorB.Name = "checkBoxSensorB";
            this.checkBoxSensorB.Size = new System.Drawing.Size(57, 17);
            this.checkBoxSensorB.TabIndex = 14;
            this.checkBoxSensorB.Text = "Sorted";
            this.toolTip.SetToolTip(this.checkBoxSensorB, "Displays if values are sorted.");
            this.checkBoxSensorB.UseVisualStyleBackColor = true;
            this.checkBoxSensorB.CheckedChanged += new System.EventHandler(this.checkBoxSensorB_CheckedChanged);
            // 
            // radioInsertionB
            // 
            this.radioInsertionB.AutoSize = true;
            this.radioInsertionB.Location = new System.Drawing.Point(9, 38);
            this.radioInsertionB.Name = "radioInsertionB";
            this.radioInsertionB.Size = new System.Drawing.Size(65, 17);
            this.radioInsertionB.TabIndex = 11;
            this.radioInsertionB.Text = "Insertion";
            this.toolTip.SetToolTip(this.radioInsertionB, "Use insertion sort algorithm");
            this.radioInsertionB.UseVisualStyleBackColor = true;
            // 
            // radioSelectionB
            // 
            this.radioSelectionB.AutoSize = true;
            this.radioSelectionB.Checked = true;
            this.radioSelectionB.Location = new System.Drawing.Point(9, 18);
            this.radioSelectionB.Name = "radioSelectionB";
            this.radioSelectionB.Size = new System.Drawing.Size(69, 17);
            this.radioSelectionB.TabIndex = 10;
            this.radioSelectionB.TabStop = true;
            this.radioSelectionB.Text = "Selection";
            this.toolTip.SetToolTip(this.radioSelectionB, "Use selection sort algorithm");
            this.radioSelectionB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Processing Speed";
            // 
            // buttonSortB
            // 
            this.buttonSortB.Location = new System.Drawing.Point(91, 21);
            this.buttonSortB.Name = "buttonSortB";
            this.buttonSortB.Size = new System.Drawing.Size(56, 23);
            this.buttonSortB.TabIndex = 12;
            this.buttonSortB.Text = "Sort";
            this.toolTip.SetToolTip(this.buttonSortB, "Begin sort");
            this.buttonSortB.UseVisualStyleBackColor = true;
            this.buttonSortB.Click += new System.EventHandler(this.buttonSortB_Click);
            // 
            // textBoxSortSpdB
            // 
            this.textBoxSortSpdB.Enabled = false;
            this.textBoxSortSpdB.Location = new System.Drawing.Point(13, 83);
            this.textBoxSortSpdB.Name = "textBoxSortSpdB";
            this.textBoxSortSpdB.ReadOnly = true;
            this.textBoxSortSpdB.Size = new System.Drawing.Size(134, 20);
            this.textBoxSortSpdB.TabIndex = 9;
            this.toolTip.SetToolTip(this.textBoxSortSpdB, "Displays processing speed of sorting algorithms in milliseconds.");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDifferenceB);
            this.groupBox1.Controls.Add(this.numWheelSelectionRangeB);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numWheelValueRangeB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxTargetB);
            this.groupBox1.Controls.Add(this.radioRecursiveB);
            this.groupBox1.Controls.Add(this.radioIterativeB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonSearchB);
            this.groupBox1.Controls.Add(this.textBoxSearchSpdB);
            this.groupBox1.Location = new System.Drawing.Point(115, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 198);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // textBoxDifferenceB
            // 
            this.textBoxDifferenceB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDifferenceB.Location = new System.Drawing.Point(10, 142);
            this.textBoxDifferenceB.Name = "textBoxDifferenceB";
            this.textBoxDifferenceB.Size = new System.Drawing.Size(137, 13);
            this.textBoxDifferenceB.TabIndex = 20;
            this.textBoxDifferenceB.Text = "Min:   |  Max:";
            this.textBoxDifferenceB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numWheelSelectionRangeB
            // 
            this.numWheelSelectionRangeB.Location = new System.Drawing.Point(105, 162);
            this.numWheelSelectionRangeB.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numWheelSelectionRangeB.Name = "numWheelSelectionRangeB";
            this.numWheelSelectionRangeB.Size = new System.Drawing.Size(41, 20);
            this.numWheelSelectionRangeB.TabIndex = 16;
            this.toolTip.SetToolTip(this.numWheelSelectionRangeB, "Sets total span of values to be included in the search (Stems from the target val" +
        "ue).");
            this.numWheelSelectionRangeB.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Selection Range:";
            this.toolTip.SetToolTip(this.label11, "Sets total span of values to be included in the search (Stems from the target val" +
        "ue).\r\n");
            // 
            // numWheelValueRangeB
            // 
            this.numWheelValueRangeB.DecimalPlaces = 1;
            this.numWheelValueRangeB.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numWheelValueRangeB.Location = new System.Drawing.Point(105, 116);
            this.numWheelValueRangeB.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numWheelValueRangeB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numWheelValueRangeB.Name = "numWheelValueRangeB";
            this.numWheelValueRangeB.Size = new System.Drawing.Size(41, 20);
            this.numWheelValueRangeB.TabIndex = 15;
            this.toolTip.SetToolTip(this.numWheelValueRangeB, "Specify value difference from target which will be selected.");
            this.numWheelValueRangeB.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numWheelValueRangeB.ValueChanged += new System.EventHandler(this.numWheelValueRangeB_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Data Value Range:";
            this.toolTip.SetToolTip(this.label9, "Specify value difference from target which will be selected.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Target:";
            // 
            // textBoxTargetB
            // 
            this.textBoxTargetB.Location = new System.Drawing.Point(91, 91);
            this.textBoxTargetB.Name = "textBoxTargetB";
            this.textBoxTargetB.Size = new System.Drawing.Size(59, 20);
            this.textBoxTargetB.TabIndex = 13;
            this.toolTip.SetToolTip(this.textBoxTargetB, "Target value to be found");
            this.textBoxTargetB.TextChanged += new System.EventHandler(this.textBoxTargetB_TextChanged);
            this.textBoxTargetB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTargetB_KeyPress);
            // 
            // radioRecursiveB
            // 
            this.radioRecursiveB.AutoSize = true;
            this.radioRecursiveB.Location = new System.Drawing.Point(12, 38);
            this.radioRecursiveB.Name = "radioRecursiveB";
            this.radioRecursiveB.Size = new System.Drawing.Size(73, 17);
            this.radioRecursiveB.TabIndex = 14;
            this.radioRecursiveB.Text = "Recursive";
            this.toolTip.SetToolTip(this.radioRecursiveB, "Use recursive search algorithm");
            this.radioRecursiveB.UseVisualStyleBackColor = true;
            // 
            // radioIterativeB
            // 
            this.radioIterativeB.AutoSize = true;
            this.radioIterativeB.Checked = true;
            this.radioIterativeB.Location = new System.Drawing.Point(12, 18);
            this.radioIterativeB.Name = "radioIterativeB";
            this.radioIterativeB.Size = new System.Drawing.Size(63, 17);
            this.radioIterativeB.TabIndex = 13;
            this.radioIterativeB.TabStop = true;
            this.radioIterativeB.Text = "Iterative";
            this.toolTip.SetToolTip(this.radioIterativeB, "Use iterative search algorithm");
            this.radioIterativeB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Processing\r\nSpeed";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // buttonSearchB
            // 
            this.buttonSearchB.Location = new System.Drawing.Point(91, 20);
            this.buttonSearchB.Name = "buttonSearchB";
            this.buttonSearchB.Size = new System.Drawing.Size(56, 23);
            this.buttonSearchB.TabIndex = 17;
            this.buttonSearchB.Text = "Search";
            this.toolTip.SetToolTip(this.buttonSearchB, "Search for Target");
            this.buttonSearchB.UseVisualStyleBackColor = true;
            this.buttonSearchB.Click += new System.EventHandler(this.buttonSearchB_Click);
            // 
            // textBoxSearchSpdB
            // 
            this.textBoxSearchSpdB.Enabled = false;
            this.textBoxSearchSpdB.Location = new System.Drawing.Point(68, 64);
            this.textBoxSearchSpdB.Name = "textBoxSearchSpdB";
            this.textBoxSearchSpdB.ReadOnly = true;
            this.textBoxSearchSpdB.Size = new System.Drawing.Size(79, 20);
            this.textBoxSearchSpdB.TabIndex = 9;
            this.toolTip.SetToolTip(this.textBoxSearchSpdB, "Displays processing speed of binary searching algorithms in ticks.");
            // 
            // listBoxSensorB
            // 
            this.listBoxSensorB.FormattingEnabled = true;
            this.listBoxSensorB.Location = new System.Drawing.Point(15, 20);
            this.listBoxSensorB.Name = "listBoxSensorB";
            this.listBoxSensorB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSensorB.Size = new System.Drawing.Size(91, 316);
            this.listBoxSensorB.TabIndex = 10;
            this.toolTip.SetToolTip(this.listBoxSensorB, "List display for Sensor B Data");
            this.listBoxSensorB.Enter += new System.EventHandler(this.listBoxSensorB_MouseMove);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(688, 11);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(68, 46);
            this.buttonLoad.TabIndex = 20;
            this.buttonLoad.Text = "Load Data";
            this.toolTip.SetToolTip(this.buttonLoad, "Loads data from Galileo satellite.");
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(599, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sigma:";
            this.toolTip.SetToolTip(this.label6, "Standard Deviation\r\nSets the range in which the values will deviate from\r\nthe mea" +
        "n.");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(610, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mu:";
            this.toolTip.SetToolTip(this.label7, "Mean Value\r\nSets mean value of data set for both sensors.\r\n\r\n\r\n");
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 500;
            // 
            // buttonSortProcessingA
            // 
            this.buttonSortProcessingA.Location = new System.Drawing.Point(89, 67);
            this.buttonSortProcessingA.Name = "buttonSortProcessingA";
            this.buttonSortProcessingA.Size = new System.Drawing.Size(108, 23);
            this.buttonSortProcessingA.TabIndex = 3;
            this.buttonSortProcessingA.Text = "Sort";
            this.toolTip.SetToolTip(this.buttonSortProcessingA, "Initializes both sort algorithms");
            this.buttonSortProcessingA.UseVisualStyleBackColor = true;
            this.buttonSortProcessingA.Click += new System.EventHandler(this.buttonSortProcessingA_Click);
            // 
            // numWheelSelectionRangeProcessingA
            // 
            this.numWheelSelectionRangeProcessingA.Location = new System.Drawing.Point(104, 122);
            this.numWheelSelectionRangeProcessingA.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numWheelSelectionRangeProcessingA.Name = "numWheelSelectionRangeProcessingA";
            this.numWheelSelectionRangeProcessingA.Size = new System.Drawing.Size(41, 20);
            this.numWheelSelectionRangeProcessingA.TabIndex = 5;
            this.toolTip.SetToolTip(this.numWheelSelectionRangeProcessingA, "Specifies amount of values to be checked. (Starts from found value)");
            this.numWheelSelectionRangeProcessingA.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Selection Range:";
            this.toolTip.SetToolTip(this.label13, "Specifies amount of values to be checked. (Starts from found value)");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Data Value Range:";
            this.toolTip.SetToolTip(this.label14, "Specify value difference from target which will be selected.");
            // 
            // numWheelValueRangeProcessingA
            // 
            this.numWheelValueRangeProcessingA.DecimalPlaces = 1;
            this.numWheelValueRangeProcessingA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numWheelValueRangeProcessingA.Location = new System.Drawing.Point(104, 96);
            this.numWheelValueRangeProcessingA.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWheelValueRangeProcessingA.Name = "numWheelValueRangeProcessingA";
            this.numWheelValueRangeProcessingA.Size = new System.Drawing.Size(41, 20);
            this.numWheelValueRangeProcessingA.TabIndex = 4;
            this.toolTip.SetToolTip(this.numWheelValueRangeProcessingA, "Specify value difference from target which will be selected.");
            this.numWheelValueRangeProcessingA.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(160, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Target:";
            this.toolTip.SetToolTip(this.label15, "Target value to be searched");
            // 
            // textBoxTargetProcessingA
            // 
            this.textBoxTargetProcessingA.Location = new System.Drawing.Point(207, 124);
            this.textBoxTargetProcessingA.Name = "textBoxTargetProcessingA";
            this.textBoxTargetProcessingA.Size = new System.Drawing.Size(51, 20);
            this.textBoxTargetProcessingA.TabIndex = 6;
            this.toolTip.SetToolTip(this.textBoxTargetProcessingA, "Target value to be found");
            this.textBoxTargetProcessingA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTargetProcessingA_KeyPress);
            // 
            // buttonSearchProcessingA
            // 
            this.buttonSearchProcessingA.Location = new System.Drawing.Point(160, 95);
            this.buttonSearchProcessingA.Name = "buttonSearchProcessingA";
            this.buttonSearchProcessingA.Size = new System.Drawing.Size(98, 23);
            this.buttonSearchProcessingA.TabIndex = 7;
            this.buttonSearchProcessingA.Text = "Search";
            this.toolTip.SetToolTip(this.buttonSearchProcessingA, "Search for Target using both search algorithms.");
            this.buttonSearchProcessingA.UseVisualStyleBackColor = true;
            this.buttonSearchProcessingA.Click += new System.EventHandler(this.buttonSearchProcessingA_Click);
            // 
            // buttonSortProcessingB
            // 
            this.buttonSortProcessingB.Location = new System.Drawing.Point(89, 67);
            this.buttonSortProcessingB.Name = "buttonSortProcessingB";
            this.buttonSortProcessingB.Size = new System.Drawing.Size(108, 23);
            this.buttonSortProcessingB.TabIndex = 8;
            this.buttonSortProcessingB.Text = "Sort";
            this.toolTip.SetToolTip(this.buttonSortProcessingB, "Initializes both sort algorithms");
            this.buttonSortProcessingB.UseVisualStyleBackColor = true;
            this.buttonSortProcessingB.Click += new System.EventHandler(this.buttonSortProcessingB_Click);
            // 
            // numWheelSelectionRangeProcessingB
            // 
            this.numWheelSelectionRangeProcessingB.Location = new System.Drawing.Point(104, 122);
            this.numWheelSelectionRangeProcessingB.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numWheelSelectionRangeProcessingB.Name = "numWheelSelectionRangeProcessingB";
            this.numWheelSelectionRangeProcessingB.Size = new System.Drawing.Size(41, 20);
            this.numWheelSelectionRangeProcessingB.TabIndex = 10;
            this.toolTip.SetToolTip(this.numWheelSelectionRangeProcessingB, "Specifies amount of values to be checked. (Starts from found value)");
            this.numWheelSelectionRangeProcessingB.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 123);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "Selection Range:";
            this.toolTip.SetToolTip(this.label21, "Specifies amount of values to be checked. (Starts from found value)");
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 98);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(98, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = "Data Value Range:";
            this.toolTip.SetToolTip(this.label23, "Specify value difference from target which will be selected.");
            // 
            // numWheelValueRangeProcessingB
            // 
            this.numWheelValueRangeProcessingB.DecimalPlaces = 1;
            this.numWheelValueRangeProcessingB.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numWheelValueRangeProcessingB.Location = new System.Drawing.Point(104, 96);
            this.numWheelValueRangeProcessingB.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWheelValueRangeProcessingB.Name = "numWheelValueRangeProcessingB";
            this.numWheelValueRangeProcessingB.Size = new System.Drawing.Size(41, 20);
            this.numWheelValueRangeProcessingB.TabIndex = 9;
            this.toolTip.SetToolTip(this.numWheelValueRangeProcessingB, "Specify value difference from target which will be selected.");
            this.numWheelValueRangeProcessingB.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(160, 128);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 13);
            this.label26.TabIndex = 14;
            this.label26.Text = "Target:";
            this.toolTip.SetToolTip(this.label26, "Target value to be searched");
            // 
            // textBoxTargetProcessingB
            // 
            this.textBoxTargetProcessingB.Location = new System.Drawing.Point(207, 124);
            this.textBoxTargetProcessingB.Name = "textBoxTargetProcessingB";
            this.textBoxTargetProcessingB.Size = new System.Drawing.Size(51, 20);
            this.textBoxTargetProcessingB.TabIndex = 11;
            this.toolTip.SetToolTip(this.textBoxTargetProcessingB, "Target value to be found");
            this.textBoxTargetProcessingB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTargetProcessingB_KeyPress);
            // 
            // buttonSearchProcessingB
            // 
            this.buttonSearchProcessingB.Location = new System.Drawing.Point(160, 95);
            this.buttonSearchProcessingB.Name = "buttonSearchProcessingB";
            this.buttonSearchProcessingB.Size = new System.Drawing.Size(98, 23);
            this.buttonSearchProcessingB.TabIndex = 12;
            this.buttonSearchProcessingB.Text = "Search";
            this.toolTip.SetToolTip(this.buttonSearchProcessingB, "Search for Target using both search algorithms.");
            this.buttonSearchProcessingB.UseVisualStyleBackColor = true;
            this.buttonSearchProcessingB.Click += new System.EventHandler(this.buttonSearchProcessingB_Click);
            // 
            // textBoxHighlightProcessingSpdB
            // 
            this.textBoxHighlightProcessingSpdB.Enabled = false;
            this.textBoxHighlightProcessingSpdB.Location = new System.Drawing.Point(195, 66);
            this.textBoxHighlightProcessingSpdB.Name = "textBoxHighlightProcessingSpdB";
            this.textBoxHighlightProcessingSpdB.ReadOnly = true;
            this.textBoxHighlightProcessingSpdB.Size = new System.Drawing.Size(65, 20);
            this.textBoxHighlightProcessingSpdB.TabIndex = 21;
            this.toolTip.SetToolTip(this.textBoxHighlightProcessingSpdB, "Displays processing speed of my complex highlighting algorithm in ticks.");
            // 
            // textBoxRecursiveSearchSpdB
            // 
            this.textBoxRecursiveSearchSpdB.Enabled = false;
            this.textBoxRecursiveSearchSpdB.Location = new System.Drawing.Point(195, 39);
            this.textBoxRecursiveSearchSpdB.Name = "textBoxRecursiveSearchSpdB";
            this.textBoxRecursiveSearchSpdB.ReadOnly = true;
            this.textBoxRecursiveSearchSpdB.Size = new System.Drawing.Size(65, 20);
            this.textBoxRecursiveSearchSpdB.TabIndex = 20;
            this.toolTip.SetToolTip(this.textBoxRecursiveSearchSpdB, "Displays processing speed of Recursive Binary Search algorithm in ticks.");
            // 
            // textBoxIterativeSearchSpdB
            // 
            this.textBoxIterativeSearchSpdB.Enabled = false;
            this.textBoxIterativeSearchSpdB.Location = new System.Drawing.Point(195, 13);
            this.textBoxIterativeSearchSpdB.Name = "textBoxIterativeSearchSpdB";
            this.textBoxIterativeSearchSpdB.ReadOnly = true;
            this.textBoxIterativeSearchSpdB.Size = new System.Drawing.Size(65, 20);
            this.textBoxIterativeSearchSpdB.TabIndex = 9;
            this.toolTip.SetToolTip(this.textBoxIterativeSearchSpdB, "Displays processing speed of Iterative Binary Search algorithm in ticks.");
            // 
            // textBoxInsertionSortProcessingB
            // 
            this.textBoxInsertionSortProcessingB.Enabled = false;
            this.textBoxInsertionSortProcessingB.Location = new System.Drawing.Point(170, 39);
            this.textBoxInsertionSortProcessingB.Name = "textBoxInsertionSortProcessingB";
            this.textBoxInsertionSortProcessingB.ReadOnly = true;
            this.textBoxInsertionSortProcessingB.Size = new System.Drawing.Size(90, 20);
            this.textBoxInsertionSortProcessingB.TabIndex = 12;
            this.toolTip.SetToolTip(this.textBoxInsertionSortProcessingB, "Displays processing speed of Insertion Sorting algorithm in milliseconds.");
            // 
            // textBoxSelectionSortProcessingB
            // 
            this.textBoxSelectionSortProcessingB.Enabled = false;
            this.textBoxSelectionSortProcessingB.Location = new System.Drawing.Point(170, 13);
            this.textBoxSelectionSortProcessingB.Name = "textBoxSelectionSortProcessingB";
            this.textBoxSelectionSortProcessingB.ReadOnly = true;
            this.textBoxSelectionSortProcessingB.Size = new System.Drawing.Size(90, 20);
            this.textBoxSelectionSortProcessingB.TabIndex = 9;
            this.toolTip.SetToolTip(this.textBoxSelectionSortProcessingB, "Displays processing speed of Selection Sorting algorithm in milliseconds.");
            // 
            // listBoxSensorProcessingB
            // 
            this.listBoxSensorProcessingB.FormattingEnabled = true;
            this.listBoxSensorProcessingB.Location = new System.Drawing.Point(8, 20);
            this.listBoxSensorProcessingB.Name = "listBoxSensorProcessingB";
            this.listBoxSensorProcessingB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSensorProcessingB.Size = new System.Drawing.Size(69, 316);
            this.listBoxSensorProcessingB.TabIndex = 1;
            this.toolTip.SetToolTip(this.listBoxSensorProcessingB, "List display for Sensor B Data");
            this.listBoxSensorProcessingB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxSensorProcessingB_MouseMove);
            // 
            // textBoxInsertionSortProcessingA
            // 
            this.textBoxInsertionSortProcessingA.Enabled = false;
            this.textBoxInsertionSortProcessingA.Location = new System.Drawing.Point(195, 39);
            this.textBoxInsertionSortProcessingA.Name = "textBoxInsertionSortProcessingA";
            this.textBoxInsertionSortProcessingA.ReadOnly = true;
            this.textBoxInsertionSortProcessingA.Size = new System.Drawing.Size(65, 20);
            this.textBoxInsertionSortProcessingA.TabIndex = 12;
            this.toolTip.SetToolTip(this.textBoxInsertionSortProcessingA, "Displays processing speed of Insertion Sorting algorithm in milliseconds.");
            // 
            // textBoxSelectionSortProcessingA
            // 
            this.textBoxSelectionSortProcessingA.Enabled = false;
            this.textBoxSelectionSortProcessingA.Location = new System.Drawing.Point(195, 13);
            this.textBoxSelectionSortProcessingA.Name = "textBoxSelectionSortProcessingA";
            this.textBoxSelectionSortProcessingA.ReadOnly = true;
            this.textBoxSelectionSortProcessingA.Size = new System.Drawing.Size(65, 20);
            this.textBoxSelectionSortProcessingA.TabIndex = 3;
            this.toolTip.SetToolTip(this.textBoxSelectionSortProcessingA, "Displays processing speed of Selection Sorting algorithm in milliseconds.");
            // 
            // textBoxHighlightProcessingSpdA
            // 
            this.textBoxHighlightProcessingSpdA.Enabled = false;
            this.textBoxHighlightProcessingSpdA.Location = new System.Drawing.Point(195, 66);
            this.textBoxHighlightProcessingSpdA.Name = "textBoxHighlightProcessingSpdA";
            this.textBoxHighlightProcessingSpdA.ReadOnly = true;
            this.textBoxHighlightProcessingSpdA.Size = new System.Drawing.Size(65, 20);
            this.textBoxHighlightProcessingSpdA.TabIndex = 21;
            this.toolTip.SetToolTip(this.textBoxHighlightProcessingSpdA, "Displays processing speed of my complex highlighting algorithm in ticks.");
            // 
            // textBoxRecursiveSearchSpdA
            // 
            this.textBoxRecursiveSearchSpdA.Enabled = false;
            this.textBoxRecursiveSearchSpdA.Location = new System.Drawing.Point(195, 39);
            this.textBoxRecursiveSearchSpdA.Name = "textBoxRecursiveSearchSpdA";
            this.textBoxRecursiveSearchSpdA.ReadOnly = true;
            this.textBoxRecursiveSearchSpdA.Size = new System.Drawing.Size(65, 20);
            this.textBoxRecursiveSearchSpdA.TabIndex = 20;
            this.toolTip.SetToolTip(this.textBoxRecursiveSearchSpdA, "Displays processing speed of Recursive Binary Search algorithm in ticks.");
            // 
            // textBoxIterativeSearchSpdA
            // 
            this.textBoxIterativeSearchSpdA.Enabled = false;
            this.textBoxIterativeSearchSpdA.Location = new System.Drawing.Point(195, 13);
            this.textBoxIterativeSearchSpdA.Name = "textBoxIterativeSearchSpdA";
            this.textBoxIterativeSearchSpdA.ReadOnly = true;
            this.textBoxIterativeSearchSpdA.Size = new System.Drawing.Size(65, 20);
            this.textBoxIterativeSearchSpdA.TabIndex = 9;
            this.toolTip.SetToolTip(this.textBoxIterativeSearchSpdA, "Displays processing speed of Iterative Binary Search algorithm in ticks.");
            // 
            // listBoxSensorProcessingA
            // 
            this.listBoxSensorProcessingA.FormattingEnabled = true;
            this.listBoxSensorProcessingA.Location = new System.Drawing.Point(8, 20);
            this.listBoxSensorProcessingA.Name = "listBoxSensorProcessingA";
            this.listBoxSensorProcessingA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSensorProcessingA.Size = new System.Drawing.Size(69, 316);
            this.listBoxSensorProcessingA.TabIndex = 1;
            this.toolTip.SetToolTip(this.listBoxSensorProcessingA, "List display for Sensor A Data");
            this.listBoxSensorProcessingA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxSensorProcessingA_MouseMove);
            // 
            // buttonColumn
            // 
            this.buttonColumn.Location = new System.Drawing.Point(10, 154);
            this.buttonColumn.Name = "buttonColumn";
            this.buttonColumn.Size = new System.Drawing.Size(193, 23);
            this.buttonColumn.TabIndex = 3;
            this.buttonColumn.Text = "Sort and Display Distribution";
            this.toolTip.SetToolTip(this.buttonColumn, "Sort and Display distributions of both Sensor A & B data.");
            this.buttonColumn.UseVisualStyleBackColor = true;
            this.buttonColumn.Click += new System.EventHandler(this.buttonColumn_Click);
            // 
            // textBoxInsertionSortVisual
            // 
            this.textBoxInsertionSortVisual.Enabled = false;
            this.textBoxInsertionSortVisual.Location = new System.Drawing.Point(138, 49);
            this.textBoxInsertionSortVisual.Name = "textBoxInsertionSortVisual";
            this.textBoxInsertionSortVisual.ReadOnly = true;
            this.textBoxInsertionSortVisual.Size = new System.Drawing.Size(65, 20);
            this.textBoxInsertionSortVisual.TabIndex = 12;
            this.toolTip.SetToolTip(this.textBoxInsertionSortVisual, "Displays processing speed of Insertion Sorting algorithm in milliseconds.");
            // 
            // textBoxSelectionSortVisual
            // 
            this.textBoxSelectionSortVisual.Enabled = false;
            this.textBoxSelectionSortVisual.Location = new System.Drawing.Point(138, 19);
            this.textBoxSelectionSortVisual.Name = "textBoxSelectionSortVisual";
            this.textBoxSelectionSortVisual.ReadOnly = true;
            this.textBoxSelectionSortVisual.Size = new System.Drawing.Size(65, 20);
            this.textBoxSelectionSortVisual.TabIndex = 9;
            this.toolTip.SetToolTip(this.textBoxSelectionSortVisual, "Displays processing speed of Selection Sorting algorithm in milliseconds.");
            // 
            // listBoxSensorVisualA
            // 
            this.listBoxSensorVisualA.FormattingEnabled = true;
            this.listBoxSensorVisualA.Location = new System.Drawing.Point(8, 20);
            this.listBoxSensorVisualA.Name = "listBoxSensorVisualA";
            this.listBoxSensorVisualA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSensorVisualA.Size = new System.Drawing.Size(69, 316);
            this.listBoxSensorVisualA.TabIndex = 1;
            this.toolTip.SetToolTip(this.listBoxSensorVisualA, "List display for Sensor A Data");
            this.listBoxSensorVisualA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxSensorVisualA_MouseMove);
            // 
            // listBoxSensorVisualB
            // 
            this.listBoxSensorVisualB.FormattingEnabled = true;
            this.listBoxSensorVisualB.Location = new System.Drawing.Point(672, 17);
            this.listBoxSensorVisualB.Name = "listBoxSensorVisualB";
            this.listBoxSensorVisualB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSensorVisualB.Size = new System.Drawing.Size(76, 316);
            this.listBoxSensorVisualB.TabIndex = 17;
            this.toolTip.SetToolTip(this.listBoxSensorVisualB, "List display for Sensor B Data");
            this.listBoxSensorVisualB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxSensorVisualB_MouseMove);
            // 
            // numWheelDistribution
            // 
            this.numWheelDistribution.DecimalPlaces = 1;
            this.numWheelDistribution.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numWheelDistribution.Location = new System.Drawing.Point(161, 129);
            this.numWheelDistribution.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWheelDistribution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numWheelDistribution.Name = "numWheelDistribution";
            this.numWheelDistribution.Size = new System.Drawing.Size(41, 20);
            this.numWheelDistribution.TabIndex = 2;
            this.toolTip.SetToolTip(this.numWheelDistribution, "Adjusts the visual smoothing effect.");
            this.numWheelDistribution.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numWheelSigmaVisual
            // 
            this.numWheelSigmaVisual.Location = new System.Drawing.Point(48, 75);
            this.numWheelSigmaVisual.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numWheelSigmaVisual.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWheelSigmaVisual.Name = "numWheelSigmaVisual";
            this.numWheelSigmaVisual.Size = new System.Drawing.Size(41, 20);
            this.numWheelSigmaVisual.TabIndex = 24;
            this.toolTip.SetToolTip(this.numWheelSigmaVisual, "Standard Deviation\r\nSets the range in which the values will deviate from\r\nthe mea" +
        "n.");
            this.numWheelSigmaVisual.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWheelSigmaVisual.ValueChanged += new System.EventHandler(this.numWheelSigmaVisual_ValueChanged);
            // 
            // numWheelMeanVisual
            // 
            this.numWheelMeanVisual.Location = new System.Drawing.Point(48, 101);
            this.numWheelMeanVisual.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numWheelMeanVisual.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numWheelMeanVisual.Name = "numWheelMeanVisual";
            this.numWheelMeanVisual.Size = new System.Drawing.Size(41, 20);
            this.numWheelMeanVisual.TabIndex = 25;
            this.toolTip.SetToolTip(this.numWheelMeanVisual, "Mean Value\r\nSets mean value of data set for both sensors.\r\n\r\n");
            this.numWheelMeanVisual.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numWheelMeanVisual.ValueChanged += new System.EventHandler(this.numWheelMeanVisual_ValueChanged);
            // 
            // checkBoxSortProcessingB
            // 
            this.checkBoxSortProcessingB.AutoSize = true;
            this.checkBoxSortProcessingB.Enabled = false;
            this.checkBoxSortProcessingB.Location = new System.Drawing.Point(11, 72);
            this.checkBoxSortProcessingB.Name = "checkBoxSortProcessingB";
            this.checkBoxSortProcessingB.Size = new System.Drawing.Size(57, 17);
            this.checkBoxSortProcessingB.TabIndex = 15;
            this.checkBoxSortProcessingB.Text = "Sorted";
            this.toolTip.SetToolTip(this.checkBoxSortProcessingB, "Displays if values are sorted.");
            this.checkBoxSortProcessingB.UseVisualStyleBackColor = true;
            // 
            // buttonLoadProcessing
            // 
            this.buttonLoadProcessing.Location = new System.Drawing.Point(254, 13);
            this.buttonLoadProcessing.Name = "buttonLoadProcessing";
            this.buttonLoadProcessing.Size = new System.Drawing.Size(102, 24);
            this.buttonLoadProcessing.TabIndex = 2;
            this.buttonLoadProcessing.Text = "Load Data";
            this.toolTip.SetToolTip(this.buttonLoadProcessing, "Loads data from Galileo satellite.");
            this.buttonLoadProcessing.UseVisualStyleBackColor = true;
            this.buttonLoadProcessing.Click += new System.EventHandler(this.buttonLoadProcessing_Click);
            // 
            // checkBoxSortProcessingA
            // 
            this.checkBoxSortProcessingA.AutoSize = true;
            this.checkBoxSortProcessingA.Enabled = false;
            this.checkBoxSortProcessingA.Location = new System.Drawing.Point(11, 72);
            this.checkBoxSortProcessingA.Name = "checkBoxSortProcessingA";
            this.checkBoxSortProcessingA.Size = new System.Drawing.Size(57, 17);
            this.checkBoxSortProcessingA.TabIndex = 14;
            this.checkBoxSortProcessingA.Text = "Sorted";
            this.toolTip.SetToolTip(this.checkBoxSortProcessingA, "Displays if values are sorted.");
            this.checkBoxSortProcessingA.UseVisualStyleBackColor = true;
            // 
            // checkBoxSensorProcessingB
            // 
            this.checkBoxSensorProcessingB.AutoSize = true;
            this.checkBoxSensorProcessingB.Enabled = false;
            this.checkBoxSensorProcessingB.Location = new System.Drawing.Point(280, 202);
            this.checkBoxSensorProcessingB.Name = "checkBoxSensorProcessingB";
            this.checkBoxSensorProcessingB.Size = new System.Drawing.Size(57, 17);
            this.checkBoxSensorProcessingB.TabIndex = 20;
            this.checkBoxSensorProcessingB.Text = "Sorted";
            this.toolTip.SetToolTip(this.checkBoxSensorProcessingB, "Displays if values are sorted.");
            this.checkBoxSensorProcessingB.UseVisualStyleBackColor = true;
            // 
            // checkBoxSensorProcessingA
            // 
            this.checkBoxSensorProcessingA.AutoSize = true;
            this.checkBoxSensorProcessingA.Enabled = false;
            this.checkBoxSensorProcessingA.Location = new System.Drawing.Point(280, 42);
            this.checkBoxSensorProcessingA.Name = "checkBoxSensorProcessingA";
            this.checkBoxSensorProcessingA.Size = new System.Drawing.Size(57, 17);
            this.checkBoxSensorProcessingA.TabIndex = 20;
            this.checkBoxSensorProcessingA.Text = "Sorted";
            this.toolTip.SetToolTip(this.checkBoxSensorProcessingA, "Displays if values are sorted.");
            this.checkBoxSensorProcessingA.UseVisualStyleBackColor = true;
            // 
            // chartSensorA
            // 
            chartArea3.Name = "ChartArea1";
            this.chartSensorA.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartSensorA.Legends.Add(legend3);
            this.chartSensorA.Location = new System.Drawing.Point(4, 14);
            this.chartSensorA.Name = "chartSensorA";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.CustomProperties = "LineTension=1";
            series3.Legend = "Legend1";
            series3.Name = "SensorA";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartSensorA.Series.Add(series3);
            this.chartSensorA.Size = new System.Drawing.Size(365, 145);
            this.chartSensorA.SuppressExceptions = true;
            this.chartSensorA.TabIndex = 15;
            this.chartSensorA.Text = "Sensor";
            this.toolTip.SetToolTip(this.chartSensorA, "Visual display for Sensor A data");
            // 
            // chartSensorB
            // 
            chartArea4.Name = "ChartArea1";
            this.chartSensorB.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSensorB.Legends.Add(legend4);
            this.chartSensorB.Location = new System.Drawing.Point(4, 175);
            this.chartSensorB.Name = "chartSensorB";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series4.CustomProperties = "LineTension=1, IsXAxisQuantitative=True";
            series4.Legend = "Legend1";
            series4.Name = "SensorB";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series4.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartSensorB.Series.Add(series4);
            this.chartSensorB.Size = new System.Drawing.Size(365, 145);
            this.chartSensorB.SuppressExceptions = true;
            this.chartSensorB.TabIndex = 18;
            this.chartSensorB.Text = "Sensor";
            this.toolTip.SetToolTip(this.chartSensorB, "Visual display for Sensor B data");
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(17, 105);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(25, 13);
            this.label31.TabIndex = 23;
            this.label31.Text = "Mu:";
            this.toolTip.SetToolTip(this.label31, "Mean Value\r\nSets mean value of data set for both sensors.\r\n");
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 79);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(39, 13);
            this.label32.TabIndex = 22;
            this.label32.Text = "Sigma:";
            this.toolTip.SetToolTip(this.label32, "Standard Deviation\r\nSets the range in which the values will deviate from\r\nthe mea" +
        "n.\r\n");
            // 
            // buttonLoadVisual
            // 
            this.buttonLoadVisual.Location = new System.Drawing.Point(10, 127);
            this.buttonLoadVisual.Name = "buttonLoadVisual";
            this.buttonLoadVisual.Size = new System.Drawing.Size(80, 24);
            this.buttonLoadVisual.TabIndex = 1;
            this.buttonLoadVisual.Text = "Load Data";
            this.toolTip.SetToolTip(this.buttonLoadVisual, "Loads data from Galileo satellite.");
            this.buttonLoadVisual.UseVisualStyleBackColor = true;
            this.buttonLoadVisual.Click += new System.EventHandler(this.buttonLoadVisual_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.buttonLoad);
            this.tabMain.Controls.Add(this.listViewDisplay);
            this.tabMain.Controls.Add(this.label7);
            this.tabMain.Controls.Add(this.numWheelSigma);
            this.tabMain.Controls.Add(this.label6);
            this.tabMain.Controls.Add(this.numWheelMean);
            this.tabMain.Controls.Add(this.groupBoxA);
            this.tabMain.Controls.Add(this.groupBoxB);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(769, 369);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.toolTip.SetToolTip(this.tabMain, "Center for main controls of data sort & search alogirthms.");
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tabProcess
            // 
            this.tabProcess.Controls.Add(this.groupBox6);
            this.tabProcess.Controls.Add(this.groupBox3);
            this.tabProcess.Location = new System.Drawing.Point(4, 22);
            this.tabProcess.Name = "tabProcess";
            this.tabProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcess.Size = new System.Drawing.Size(769, 369);
            this.tabProcess.TabIndex = 1;
            this.tabProcess.Text = "Processing";
            this.toolTip.SetToolTip(this.tabProcess, "Center for comparing processing speeds of search and sorting algorithms side to s" +
        "ide.");
            this.tabProcess.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.listBoxSensorProcessingB);
            this.groupBox6.Location = new System.Drawing.Point(392, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(365, 350);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sensor B";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.textBoxHighlightProcessingSpdB);
            this.groupBox8.Controls.Add(this.textBoxRecursiveSearchSpdB);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Controls.Add(this.numWheelSelectionRangeProcessingB);
            this.groupBox8.Controls.Add(this.label21);
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Controls.Add(this.numWheelValueRangeProcessingB);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Controls.Add(this.textBoxTargetProcessingB);
            this.groupBox8.Controls.Add(this.label27);
            this.groupBox8.Controls.Add(this.buttonSearchProcessingB);
            this.groupBox8.Controls.Add(this.textBoxIterativeSearchSpdB);
            this.groupBox8.Location = new System.Drawing.Point(83, 168);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(273, 154);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Search";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "Highlight Processing Speed";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 45);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(181, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "Recursive Search Processing Speed";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(7, 19);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(174, 13);
            this.label27.TabIndex = 10;
            this.label27.Text = "Iterative Search Processing Speed ";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBoxSortProcessingB);
            this.groupBox7.Controls.Add(this.textBoxInsertionSortProcessingB);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.buttonSortProcessingB);
            this.groupBox7.Controls.Add(this.textBoxSelectionSortProcessingB);
            this.groupBox7.Location = new System.Drawing.Point(83, 36);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(273, 103);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sort";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(158, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Insertion Sort Processing Speed";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(162, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Selection Sort Processing Speed";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonLoadProcessing);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.listBoxSensorProcessingA);
            this.groupBox3.Location = new System.Drawing.Point(12, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 350);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sensor A";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxSortProcessingA);
            this.groupBox4.Controls.Add(this.textBoxInsertionSortProcessingA);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.buttonSortProcessingA);
            this.groupBox4.Controls.Add(this.textBoxSelectionSortProcessingA);
            this.groupBox4.Location = new System.Drawing.Point(83, 36);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(273, 103);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sort";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 43);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(158, 13);
            this.label22.TabIndex = 11;
            this.label22.Text = "Insertion Sort Processing Speed";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Selection Sort Processing Speed";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.textBoxHighlightProcessingSpdA);
            this.groupBox5.Controls.Add(this.textBoxRecursiveSearchSpdA);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.numWheelSelectionRangeProcessingA);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.numWheelValueRangeProcessingA);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.textBoxTargetProcessingA);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.buttonSearchProcessingA);
            this.groupBox5.Controls.Add(this.textBoxIterativeSearchSpdA);
            this.groupBox5.Location = new System.Drawing.Point(83, 168);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(273, 154);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 69);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(137, 13);
            this.label25.TabIndex = 22;
            this.label25.Text = "Highlight Processing Speed";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 45);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(181, 13);
            this.label24.TabIndex = 19;
            this.label24.Text = "Recursive Search Processing Speed";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(174, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Iterative Search Processing Speed ";
            // 
            // tabVisual
            // 
            this.tabVisual.Controls.Add(this.groupBox9);
            this.tabVisual.Location = new System.Drawing.Point(4, 22);
            this.tabVisual.Name = "tabVisual";
            this.tabVisual.Padding = new System.Windows.Forms.Padding(3);
            this.tabVisual.Size = new System.Drawing.Size(769, 369);
            this.tabVisual.TabIndex = 2;
            this.tabVisual.Text = "Visualisation";
            this.toolTip.SetToolTip(this.tabVisual, "Control center for graphical output of data.");
            this.tabVisual.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox11);
            this.groupBox9.Controls.Add(this.listBoxSensorVisualB);
            this.groupBox9.Controls.Add(this.groupBox10);
            this.groupBox9.Controls.Add(this.listBoxSensorVisualA);
            this.groupBox9.Location = new System.Drawing.Point(7, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(754, 350);
            this.groupBox9.TabIndex = 12;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Line Graph Display";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.checkBoxSensorProcessingB);
            this.groupBox11.Controls.Add(this.checkBoxSensorProcessingA);
            this.groupBox11.Controls.Add(this.chartSensorA);
            this.groupBox11.Controls.Add(this.chartSensorB);
            this.groupBox11.Location = new System.Drawing.Point(80, 13);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(372, 327);
            this.groupBox11.TabIndex = 19;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Sensor Data Distribution";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label31);
            this.groupBox10.Controls.Add(this.numWheelSigmaVisual);
            this.groupBox10.Controls.Add(this.label32);
            this.groupBox10.Controls.Add(this.numWheelMeanVisual);
            this.groupBox10.Controls.Add(this.label30);
            this.groupBox10.Controls.Add(this.numWheelDistribution);
            this.groupBox10.Controls.Add(this.buttonLoadVisual);
            this.groupBox10.Controls.Add(this.textBoxInsertionSortVisual);
            this.groupBox10.Controls.Add(this.label28);
            this.groupBox10.Controls.Add(this.buttonColumn);
            this.groupBox10.Controls.Add(this.label29);
            this.groupBox10.Controls.Add(this.textBoxSelectionSortVisual);
            this.groupBox10.Location = new System.Drawing.Point(455, 77);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(213, 187);
            this.groupBox10.TabIndex = 11;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Sort";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(91, 133);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(68, 13);
            this.label30.TabIndex = 21;
            this.label30.Text = "Smoothness:";
            this.toolTip.SetToolTip(this.label30, "Adjusts the visual smoothing effect.");
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(5, 53);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(121, 13);
            this.label28.TabIndex = 11;
            this.label28.Text = "Insertion Sort (Sensor B)\r\n";
            this.toolTip.SetToolTip(this.label28, "Displays processing speed of Insertion Sorting algorithm in milliseconds.");
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(5, 22);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(125, 26);
            this.label29.TabIndex = 10;
            this.label29.Text = "Selection Sort (Sensor A)\r\n\r\n";
            this.toolTip.SetToolTip(this.label29, "Displays processing speed of Selection Sorting algorithm in milliseconds.");
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 385);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(778, 22);
            this.statusStrip.TabIndex = 14;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMain);
            this.tabControl.Controls.Add(this.tabProcess);
            this.tabControl.Controls.Add(this.tabVisual);
            this.tabControl.Location = new System.Drawing.Point(1, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(777, 395);
            this.tabControl.TabIndex = 12;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // ProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 407);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(794, 446);
            this.Name = "ProcessingForm";
            this.Text = "MSSS Data Processing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProcessingForm_FormClosed);
            this.Load += new System.EventHandler(this.ProcessingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numWheelSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelMean)).EndInit();
            this.groupBoxA.ResumeLayout(false);
            this.SortGrpBoxA.ResumeLayout(false);
            this.SortGrpBoxA.PerformLayout();
            this.SearchGrpBoxA.ResumeLayout(false);
            this.SearchGrpBoxA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelSelectionRangeA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelValueRangeA)).EndInit();
            this.groupBoxB.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelSelectionRangeB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelValueRangeB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelSelectionRangeProcessingA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelValueRangeProcessingA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelSelectionRangeProcessingB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelValueRangeProcessingB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelDistribution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelSigmaVisual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelMeanVisual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensorA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensorB)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabProcess.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabVisual.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDisplay;
        private System.Windows.Forms.ListBox listBoxSensorA;
        private System.Windows.Forms.NumericUpDown numWheelSigma;
        private System.Windows.Forms.NumericUpDown numWheelMean;
        private System.Windows.Forms.GroupBox groupBoxA;
        private System.Windows.Forms.Button buttonSearchA;
        private System.Windows.Forms.GroupBox groupBoxB;
        private System.Windows.Forms.ListBox listBoxSensorB;
        private System.Windows.Forms.GroupBox SearchGrpBoxA;
        private System.Windows.Forms.TextBox textBoxSearchSpdA;
        private System.Windows.Forms.GroupBox SortGrpBoxA;
        private System.Windows.Forms.RadioButton radioInsertionA;
        private System.Windows.Forms.RadioButton radioSelectionA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSortA;
        private System.Windows.Forms.TextBox textBoxSortSpdA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTargetA;
        private System.Windows.Forms.RadioButton radioRecursiveA;
        private System.Windows.Forms.RadioButton radioIterativeA;
        private System.Windows.Forms.Label searchLabelA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTargetB;
        private System.Windows.Forms.RadioButton radioRecursiveB;
        private System.Windows.Forms.RadioButton radioIterativeB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearchB;
        private System.Windows.Forms.TextBox textBoxSearchSpdB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioInsertionB;
        private System.Windows.Forms.RadioButton radioSelectionB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSortB;
        private System.Windows.Forms.TextBox textBoxSortSpdB;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader ColumnA;
        private System.Windows.Forms.ColumnHeader ColumnB;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private Label label8;
        private NumericUpDown numWheelValueRangeA;
        private NumericUpDown numWheelValueRangeB;
        private Label label9;
        private NumericUpDown numWheelSelectionRangeA;
        private Label label10;
        private NumericUpDown numWheelSelectionRangeB;
        private Label label11;
        private TabControl tabControl;
        private TabPage tabProcess;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox textBoxInsertionSortProcessingA;
        private Label label22;
        private Label label12;
        private Button buttonSortProcessingA;
        private TextBox textBoxSelectionSortProcessingA;
        private GroupBox groupBox5;
        private NumericUpDown numWheelSelectionRangeProcessingA;
        private Label label13;
        private Label label14;
        private NumericUpDown numWheelValueRangeProcessingA;
        private Label label15;
        private TextBox textBoxTargetProcessingA;
        private Label label16;
        private Button buttonSearchProcessingA;
        private TextBox textBoxIterativeSearchSpdA;
        private ListBox listBoxSensorProcessingA;
        private TabPage tabMain;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private TextBox textBoxInsertionSortProcessingB;
        private Label label17;
        private Label label18;
        private Button buttonSortProcessingB;
        private TextBox textBoxSelectionSortProcessingB;
        private ListBox listBoxSensorProcessingB;
        private TextBox textBoxRecursiveSearchSpdA;
        private Label label24;
        private TextBox textBoxHighlightProcessingSpdA;
        private Label label25;
        private GroupBox groupBox8;
        private Label label19;
        private TextBox textBoxHighlightProcessingSpdB;
        private TextBox textBoxRecursiveSearchSpdB;
        private Label label20;
        private NumericUpDown numWheelSelectionRangeProcessingB;
        private Label label21;
        private Label label23;
        private NumericUpDown numWheelValueRangeProcessingB;
        private Label label26;
        private TextBox textBoxTargetProcessingB;
        private Label label27;
        private Button buttonSearchProcessingB;
        private TextBox textBoxIterativeSearchSpdB;
        private Button buttonLoadProcessing;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSensorA;
        private Button buttonColumn;
        private TabPage tabVisual;
        private GroupBox groupBox9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSensorB;
        private ListBox listBoxSensorVisualB;
        private GroupBox groupBox10;
        private TextBox textBoxInsertionSortVisual;
        private Label label28;
        private Label label29;
        private TextBox textBoxSelectionSortVisual;
        private ListBox listBoxSensorVisualA;
        private Button buttonLoadVisual;
        private GroupBox groupBox11;
        private Label label30;
        private NumericUpDown numWheelDistribution;
        private Label label31;
        private NumericUpDown numWheelSigmaVisual;
        private Label label32;
        private NumericUpDown numWheelMeanVisual;
        private CheckBox checkBoxSensorA;
        private CheckBox checkBoxSensorB;
        private CheckBox checkBoxSensorProcessingB;
        private CheckBox checkBoxSensorProcessingA;
        private CheckBox checkBoxSortProcessingB;
        private CheckBox checkBoxSortProcessingA;
        private TextBox textBoxDifferenceA;
        private TextBox textBoxDifferenceB;
    }
}

