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
            this.listViewDisplay = new System.Windows.Forms.ListView();
            this.ColumnA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBoxA = new System.Windows.Forms.ListBox();
            this.numWheelSigma = new System.Windows.Forms.NumericUpDown();
            this.numWheelMean = new System.Windows.Forms.NumericUpDown();
            this.groupBoxA = new System.Windows.Forms.GroupBox();
            this.SortGrpBoxA = new System.Windows.Forms.GroupBox();
            this.radioInsertionA = new System.Windows.Forms.RadioButton();
            this.radioSelectionA = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSortA = new System.Windows.Forms.Button();
            this.TbSortSpdA = new System.Windows.Forms.TextBox();
            this.SearchGrpBoxA = new System.Windows.Forms.GroupBox();
            this.numWheelSelRangeA = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numWheelTarRangeA = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.TbTargetA = new System.Windows.Forms.TextBox();
            this.radioRecursiveA = new System.Windows.Forms.RadioButton();
            this.radioIterativeA = new System.Windows.Forms.RadioButton();
            this.searchLabelA = new System.Windows.Forms.Label();
            this.buttonSearchA = new System.Windows.Forms.Button();
            this.TbSearchSpdA = new System.Windows.Forms.TextBox();
            this.groupBoxB = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioInsertionB = new System.Windows.Forms.RadioButton();
            this.radioSelectionB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSortB = new System.Windows.Forms.Button();
            this.TbSortSpdB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numWheelSelRangeB = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numWheelTarRangeB = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbTargetB = new System.Windows.Forms.TextBox();
            this.radioRecursiveB = new System.Windows.Forms.RadioButton();
            this.radioIterativeB = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearchB = new System.Windows.Forms.Button();
            this.TbSearchSpdB = new System.Windows.Forms.TextBox();
            this.listBoxB = new System.Windows.Forms.ListBox();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelMean)).BeginInit();
            this.groupBoxA.SuspendLayout();
            this.SortGrpBoxA.SuspendLayout();
            this.SearchGrpBoxA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelSelRangeA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelTarRangeA)).BeginInit();
            this.groupBoxB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelSelRangeB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelTarRangeB)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewDisplay
            // 
            this.listViewDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnA,
            this.ColumnB});
            this.listViewDisplay.GridLines = true;
            this.listViewDisplay.HideSelection = false;
            this.listViewDisplay.Location = new System.Drawing.Point(601, 67);
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
            // listBoxA
            // 
            this.listBoxA.FormattingEnabled = true;
            this.listBoxA.Location = new System.Drawing.Point(15, 20);
            this.listBoxA.Name = "listBoxA";
            this.listBoxA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxA.Size = new System.Drawing.Size(91, 316);
            this.listBoxA.TabIndex = 1;
            // 
            // numWheelSigma
            // 
            this.numWheelSigma.Location = new System.Drawing.Point(648, 15);
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
            this.numWheelSigma.TabIndex = 7;
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
            this.numWheelMean.Location = new System.Drawing.Point(648, 41);
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
            this.numWheelMean.TabIndex = 8;
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
            this.groupBoxA.Controls.Add(this.listBoxA);
            this.groupBoxA.Location = new System.Drawing.Point(7, 9);
            this.groupBoxA.Name = "groupBoxA";
            this.groupBoxA.Size = new System.Drawing.Size(285, 350);
            this.groupBoxA.TabIndex = 9;
            this.groupBoxA.TabStop = false;
            this.groupBoxA.Text = "Sensor A";
            // 
            // SortGrpBoxA
            // 
            this.SortGrpBoxA.Controls.Add(this.radioInsertionA);
            this.SortGrpBoxA.Controls.Add(this.radioSelectionA);
            this.SortGrpBoxA.Controls.Add(this.label5);
            this.SortGrpBoxA.Controls.Add(this.buttonSortA);
            this.SortGrpBoxA.Controls.Add(this.TbSortSpdA);
            this.SortGrpBoxA.Location = new System.Drawing.Point(115, 20);
            this.SortGrpBoxA.Name = "SortGrpBoxA";
            this.SortGrpBoxA.Size = new System.Drawing.Size(160, 118);
            this.SortGrpBoxA.TabIndex = 11;
            this.SortGrpBoxA.TabStop = false;
            this.SortGrpBoxA.Text = "Sort";
            // 
            // radioInsertionA
            // 
            this.radioInsertionA.AutoSize = true;
            this.radioInsertionA.Location = new System.Drawing.Point(12, 38);
            this.radioInsertionA.Name = "radioInsertionA";
            this.radioInsertionA.Size = new System.Drawing.Size(65, 17);
            this.radioInsertionA.TabIndex = 12;
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
            this.radioSelectionA.TabIndex = 11;
            this.radioSelectionA.TabStop = true;
            this.radioSelectionA.Text = "Selection";
            this.toolTip.SetToolTip(this.radioSelectionA, "Use selection sort algorithm");
            this.radioSelectionA.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 67);
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
            this.buttonSortA.TabIndex = 6;
            this.buttonSortA.Text = "Sort";
            this.toolTip.SetToolTip(this.buttonSortA, "Sorts using specified sort method");
            this.buttonSortA.UseVisualStyleBackColor = true;
            this.buttonSortA.Click += new System.EventHandler(this.buttonSortA_Click);
            // 
            // TbSortSpdA
            // 
            this.TbSortSpdA.Enabled = false;
            this.TbSortSpdA.Location = new System.Drawing.Point(13, 83);
            this.TbSortSpdA.Name = "TbSortSpdA";
            this.TbSortSpdA.ReadOnly = true;
            this.TbSortSpdA.Size = new System.Drawing.Size(134, 20);
            this.TbSortSpdA.TabIndex = 9;
            // 
            // SearchGrpBoxA
            // 
            this.SearchGrpBoxA.Controls.Add(this.numWheelSelRangeA);
            this.SearchGrpBoxA.Controls.Add(this.label10);
            this.SearchGrpBoxA.Controls.Add(this.label8);
            this.SearchGrpBoxA.Controls.Add(this.numWheelTarRangeA);
            this.SearchGrpBoxA.Controls.Add(this.label1);
            this.SearchGrpBoxA.Controls.Add(this.TbTargetA);
            this.SearchGrpBoxA.Controls.Add(this.radioRecursiveA);
            this.SearchGrpBoxA.Controls.Add(this.radioIterativeA);
            this.SearchGrpBoxA.Controls.Add(this.searchLabelA);
            this.SearchGrpBoxA.Controls.Add(this.buttonSearchA);
            this.SearchGrpBoxA.Controls.Add(this.TbSearchSpdA);
            this.SearchGrpBoxA.Location = new System.Drawing.Point(115, 140);
            this.SearchGrpBoxA.Name = "SearchGrpBoxA";
            this.SearchGrpBoxA.Size = new System.Drawing.Size(160, 190);
            this.SearchGrpBoxA.TabIndex = 10;
            this.SearchGrpBoxA.TabStop = false;
            this.SearchGrpBoxA.Text = "Search";
            // 
            // numWheelSelRangeA
            // 
            this.numWheelSelRangeA.Location = new System.Drawing.Point(106, 117);
            this.numWheelSelRangeA.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numWheelSelRangeA.Name = "numWheelSelRangeA";
            this.numWheelSelRangeA.Size = new System.Drawing.Size(41, 20);
            this.numWheelSelRangeA.TabIndex = 18;
            this.toolTip.SetToolTip(this.numWheelSelRangeA, "Sets total span of values to be included in the search (Stems from the target val" +
        "ue).");
            this.numWheelSelRangeA.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Selection Range:";
            this.toolTip.SetToolTip(this.label10, "Sets total span of values to be included in the search (Stems from the target val" +
        "ue).");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Target Range:";
            this.toolTip.SetToolTip(this.label8, "Sets the range from target for which values can be selected.");
            // 
            // numWheelTarRangeA
            // 
            this.numWheelTarRangeA.DecimalPlaces = 1;
            this.numWheelTarRangeA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numWheelTarRangeA.Location = new System.Drawing.Point(106, 91);
            this.numWheelTarRangeA.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWheelTarRangeA.Name = "numWheelTarRangeA";
            this.numWheelTarRangeA.Size = new System.Drawing.Size(41, 20);
            this.numWheelTarRangeA.TabIndex = 15;
            this.toolTip.SetToolTip(this.numWheelTarRangeA, "Sets the range from target for which values can be selected.");
            this.numWheelTarRangeA.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Target:";
            this.toolTip.SetToolTip(this.label1, "Target value to be searched");
            // 
            // TbTargetA
            // 
            this.TbTargetA.Location = new System.Drawing.Point(56, 63);
            this.TbTargetA.Name = "TbTargetA";
            this.TbTargetA.Size = new System.Drawing.Size(91, 20);
            this.TbTargetA.TabIndex = 13;
            this.toolTip.SetToolTip(this.TbTargetA, "Target value to be searched");
            this.TbTargetA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTargetA_KeyPress);
            // 
            // radioRecursiveA
            // 
            this.radioRecursiveA.AutoSize = true;
            this.radioRecursiveA.Location = new System.Drawing.Point(12, 38);
            this.radioRecursiveA.Name = "radioRecursiveA";
            this.radioRecursiveA.Size = new System.Drawing.Size(73, 17);
            this.radioRecursiveA.TabIndex = 12;
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
            this.radioIterativeA.TabIndex = 11;
            this.radioIterativeA.TabStop = true;
            this.radioIterativeA.Text = "Iterative";
            this.toolTip.SetToolTip(this.radioIterativeA, "Use iterative search algorithm");
            this.radioIterativeA.UseVisualStyleBackColor = true;
            // 
            // searchLabelA
            // 
            this.searchLabelA.AutoSize = true;
            this.searchLabelA.Location = new System.Drawing.Point(10, 141);
            this.searchLabelA.Name = "searchLabelA";
            this.searchLabelA.Size = new System.Drawing.Size(93, 13);
            this.searchLabelA.TabIndex = 10;
            this.searchLabelA.Text = "Processing Speed";
            // 
            // buttonSearchA
            // 
            this.buttonSearchA.Location = new System.Drawing.Point(91, 24);
            this.buttonSearchA.Name = "buttonSearchA";
            this.buttonSearchA.Size = new System.Drawing.Size(56, 23);
            this.buttonSearchA.TabIndex = 6;
            this.buttonSearchA.Text = "Search";
            this.toolTip.SetToolTip(this.buttonSearchA, "Search for target using specified search method");
            this.buttonSearchA.UseVisualStyleBackColor = true;
            this.buttonSearchA.Click += new System.EventHandler(this.buttonSearchA_Click);
            // 
            // TbSearchSpdA
            // 
            this.TbSearchSpdA.Enabled = false;
            this.TbSearchSpdA.Location = new System.Drawing.Point(13, 158);
            this.TbSearchSpdA.Name = "TbSearchSpdA";
            this.TbSearchSpdA.ReadOnly = true;
            this.TbSearchSpdA.Size = new System.Drawing.Size(134, 20);
            this.TbSearchSpdA.TabIndex = 9;
            // 
            // groupBoxB
            // 
            this.groupBoxB.Controls.Add(this.groupBox2);
            this.groupBoxB.Controls.Add(this.groupBox1);
            this.groupBoxB.Controls.Add(this.listBoxB);
            this.groupBoxB.Location = new System.Drawing.Point(303, 9);
            this.groupBoxB.Name = "groupBoxB";
            this.groupBoxB.Size = new System.Drawing.Size(285, 350);
            this.groupBoxB.TabIndex = 10;
            this.groupBoxB.TabStop = false;
            this.groupBoxB.Text = "Sensor B";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioInsertionB);
            this.groupBox2.Controls.Add(this.radioSelectionB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonSortB);
            this.groupBox2.Controls.Add(this.TbSortSpdB);
            this.groupBox2.Location = new System.Drawing.Point(115, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 118);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort";
            // 
            // radioInsertionB
            // 
            this.radioInsertionB.AutoSize = true;
            this.radioInsertionB.Location = new System.Drawing.Point(9, 38);
            this.radioInsertionB.Name = "radioInsertionB";
            this.radioInsertionB.Size = new System.Drawing.Size(65, 17);
            this.radioInsertionB.TabIndex = 12;
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
            this.radioSelectionB.TabIndex = 11;
            this.radioSelectionB.TabStop = true;
            this.radioSelectionB.Text = "Selection";
            this.toolTip.SetToolTip(this.radioSelectionB, "Use selection sort algorithm");
            this.radioSelectionB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 67);
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
            this.buttonSortB.TabIndex = 6;
            this.buttonSortB.Text = "Sort";
            this.toolTip.SetToolTip(this.buttonSortB, "Sorts using specified sort method");
            this.buttonSortB.UseVisualStyleBackColor = true;
            this.buttonSortB.Click += new System.EventHandler(this.buttonSortB_Click);
            // 
            // TbSortSpdB
            // 
            this.TbSortSpdB.Enabled = false;
            this.TbSortSpdB.Location = new System.Drawing.Point(14, 83);
            this.TbSortSpdB.Name = "TbSortSpdB";
            this.TbSortSpdB.ReadOnly = true;
            this.TbSortSpdB.Size = new System.Drawing.Size(134, 20);
            this.TbSortSpdB.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numWheelSelRangeB);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numWheelTarRangeB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbTargetB);
            this.groupBox1.Controls.Add(this.radioRecursiveB);
            this.groupBox1.Controls.Add(this.radioIterativeB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonSearchB);
            this.groupBox1.Controls.Add(this.TbSearchSpdB);
            this.groupBox1.Location = new System.Drawing.Point(116, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 190);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // numWheelSelRangeB
            // 
            this.numWheelSelRangeB.Location = new System.Drawing.Point(106, 117);
            this.numWheelSelRangeB.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numWheelSelRangeB.Name = "numWheelSelRangeB";
            this.numWheelSelRangeB.Size = new System.Drawing.Size(41, 20);
            this.numWheelSelRangeB.TabIndex = 20;
            this.toolTip.SetToolTip(this.numWheelSelRangeB, "Sets total span of values to be included in the search (Stems from the target val" +
        "ue).");
            this.numWheelSelRangeB.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Selection Range:";
            this.toolTip.SetToolTip(this.label11, "Sets total span of values to be included in the search (Stems from the target val" +
        "ue).\r\n");
            // 
            // numWheelTarRangeB
            // 
            this.numWheelTarRangeB.DecimalPlaces = 1;
            this.numWheelTarRangeB.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numWheelTarRangeB.Location = new System.Drawing.Point(106, 91);
            this.numWheelTarRangeB.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWheelTarRangeB.Name = "numWheelTarRangeB";
            this.numWheelTarRangeB.Size = new System.Drawing.Size(41, 20);
            this.numWheelTarRangeB.TabIndex = 18;
            this.numWheelTarRangeB.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Target Range:";
            this.toolTip.SetToolTip(this.label9, "Sets the range from target for which values can be selected.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Target:";
            // 
            // TbTargetB
            // 
            this.TbTargetB.Location = new System.Drawing.Point(56, 63);
            this.TbTargetB.Name = "TbTargetB";
            this.TbTargetB.Size = new System.Drawing.Size(91, 20);
            this.TbTargetB.TabIndex = 13;
            this.TbTargetB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTargetB_KeyPress);
            // 
            // radioRecursiveB
            // 
            this.radioRecursiveB.AutoSize = true;
            this.radioRecursiveB.Location = new System.Drawing.Point(12, 38);
            this.radioRecursiveB.Name = "radioRecursiveB";
            this.radioRecursiveB.Size = new System.Drawing.Size(73, 17);
            this.radioRecursiveB.TabIndex = 12;
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
            this.radioIterativeB.TabIndex = 11;
            this.radioIterativeB.TabStop = true;
            this.radioIterativeB.Text = "Iterative";
            this.toolTip.SetToolTip(this.radioIterativeB, "Use iterative search algorithm");
            this.radioIterativeB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Processing Speed";
            // 
            // buttonSearchB
            // 
            this.buttonSearchB.Location = new System.Drawing.Point(91, 24);
            this.buttonSearchB.Name = "buttonSearchB";
            this.buttonSearchB.Size = new System.Drawing.Size(56, 23);
            this.buttonSearchB.TabIndex = 6;
            this.buttonSearchB.Text = "Search";
            this.toolTip.SetToolTip(this.buttonSearchB, "Search for target using specified search method");
            this.buttonSearchB.UseVisualStyleBackColor = true;
            this.buttonSearchB.Click += new System.EventHandler(this.buttonSearchB_Click);
            // 
            // TbSearchSpdB
            // 
            this.TbSearchSpdB.Enabled = false;
            this.TbSearchSpdB.Location = new System.Drawing.Point(13, 158);
            this.TbSearchSpdB.Name = "TbSearchSpdB";
            this.TbSearchSpdB.ReadOnly = true;
            this.TbSearchSpdB.Size = new System.Drawing.Size(134, 20);
            this.TbSearchSpdB.TabIndex = 9;
            // 
            // listBoxB
            // 
            this.listBoxB.FormattingEnabled = true;
            this.listBoxB.Location = new System.Drawing.Point(15, 20);
            this.listBoxB.Name = "listBoxB";
            this.listBoxB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxB.Size = new System.Drawing.Size(91, 316);
            this.listBoxB.TabIndex = 1;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(710, 12);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(45, 49);
            this.LoadBtn.TabIndex = 11;
            this.LoadBtn.Text = "Load Data";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sigma:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(617, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mu:";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 500;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 361);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(772, 22);
            this.statusStrip.TabIndex = 14;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 383);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.groupBoxB);
            this.Controls.Add(this.groupBoxA);
            this.Controls.Add(this.numWheelMean);
            this.Controls.Add(this.numWheelSigma);
            this.Controls.Add(this.listViewDisplay);
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
            ((System.ComponentModel.ISupportInitialize)(this.numWheelSelRangeA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelTarRangeA)).EndInit();
            this.groupBoxB.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelSelRangeB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWheelTarRangeB)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDisplay;
        private System.Windows.Forms.ListBox listBoxA;
        private System.Windows.Forms.NumericUpDown numWheelSigma;
        private System.Windows.Forms.NumericUpDown numWheelMean;
        private System.Windows.Forms.GroupBox groupBoxA;
        private System.Windows.Forms.Button buttonSearchA;
        private System.Windows.Forms.GroupBox groupBoxB;
        private System.Windows.Forms.ListBox listBoxB;
        private System.Windows.Forms.GroupBox SearchGrpBoxA;
        private System.Windows.Forms.TextBox TbSearchSpdA;
        private System.Windows.Forms.GroupBox SortGrpBoxA;
        private System.Windows.Forms.RadioButton radioInsertionA;
        private System.Windows.Forms.RadioButton radioSelectionA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSortA;
        private System.Windows.Forms.TextBox TbSortSpdA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbTargetA;
        private System.Windows.Forms.RadioButton radioRecursiveA;
        private System.Windows.Forms.RadioButton radioIterativeA;
        private System.Windows.Forms.Label searchLabelA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbTargetB;
        private System.Windows.Forms.RadioButton radioRecursiveB;
        private System.Windows.Forms.RadioButton radioIterativeB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearchB;
        private System.Windows.Forms.TextBox TbSearchSpdB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioInsertionB;
        private System.Windows.Forms.RadioButton radioSelectionB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSortB;
        private System.Windows.Forms.TextBox TbSortSpdB;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader ColumnA;
        private System.Windows.Forms.ColumnHeader ColumnB;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private Label label8;
        private NumericUpDown numWheelTarRangeA;
        private NumericUpDown numWheelTarRangeB;
        private Label label9;
        private NumericUpDown numWheelSelRangeA;
        private Label label10;
        private NumericUpDown numWheelSelRangeB;
        private Label label11;
    }
}

