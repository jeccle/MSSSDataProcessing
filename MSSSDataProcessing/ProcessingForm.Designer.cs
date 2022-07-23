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
            this.SigmaNumWheel = new System.Windows.Forms.NumericUpDown();
            this.MeanNumWheel = new System.Windows.Forms.NumericUpDown();
            this.groupBoxA = new System.Windows.Forms.GroupBox();
            this.SortGrpBoxA = new System.Windows.Forms.GroupBox();
            this.radioInsertionA = new System.Windows.Forms.RadioButton();
            this.radioSelectionA = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSortA = new System.Windows.Forms.Button();
            this.TbSortSpdA = new System.Windows.Forms.TextBox();
            this.SearchGrpBoxA = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.SigmaNumWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeanNumWheel)).BeginInit();
            this.groupBoxA.SuspendLayout();
            this.SortGrpBoxA.SuspendLayout();
            this.SearchGrpBoxA.SuspendLayout();
            this.groupBoxB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewDisplay
            // 
            this.listViewDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnA,
            this.ColumnB});
            this.listViewDisplay.GridLines = true;
            this.listViewDisplay.HideSelection = false;
            this.listViewDisplay.Location = new System.Drawing.Point(620, 81);
            this.listViewDisplay.Name = "listViewDisplay";
            this.listViewDisplay.Size = new System.Drawing.Size(154, 284);
            this.listViewDisplay.TabIndex = 0;
            this.listViewDisplay.UseCompatibleStateImageBehavior = false;
            this.listViewDisplay.View = System.Windows.Forms.View.Details;
            // 
            // ColumnA
            // 
            this.ColumnA.Text = "Sensor A";
            this.ColumnA.Width = 76;
            // 
            // ColumnB
            // 
            this.ColumnB.Text = "Sensor B";
            this.ColumnB.Width = 76;
            // 
            // listBoxA
            // 
            this.listBoxA.FormattingEnabled = true;
            this.listBoxA.Location = new System.Drawing.Point(6, 20);
            this.listBoxA.Name = "listBoxA";
            this.listBoxA.Size = new System.Drawing.Size(111, 316);
            this.listBoxA.TabIndex = 1;
            // 
            // SigmaNumWheel
            // 
            this.SigmaNumWheel.Location = new System.Drawing.Point(667, 29);
            this.SigmaNumWheel.Name = "SigmaNumWheel";
            this.SigmaNumWheel.Size = new System.Drawing.Size(41, 20);
            this.SigmaNumWheel.TabIndex = 7;
            this.SigmaNumWheel.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // MeanNumWheel
            // 
            this.MeanNumWheel.Location = new System.Drawing.Point(667, 55);
            this.MeanNumWheel.Name = "MeanNumWheel";
            this.MeanNumWheel.Size = new System.Drawing.Size(41, 20);
            this.MeanNumWheel.TabIndex = 8;
            this.MeanNumWheel.Value = new decimal(new int[] {
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
            this.groupBoxA.Location = new System.Drawing.Point(12, 22);
            this.groupBoxA.Name = "groupBoxA";
            this.groupBoxA.Size = new System.Drawing.Size(290, 350);
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
            this.SortGrpBoxA.Location = new System.Drawing.Point(123, 27);
            this.SortGrpBoxA.Name = "SortGrpBoxA";
            this.SortGrpBoxA.Size = new System.Drawing.Size(160, 118);
            this.SortGrpBoxA.TabIndex = 11;
            this.SortGrpBoxA.TabStop = false;
            this.SortGrpBoxA.Text = "Sort";
            // 
            // radioInsertionA
            // 
            this.radioInsertionA.AutoSize = true;
            this.radioInsertionA.Location = new System.Drawing.Point(9, 38);
            this.radioInsertionA.Name = "radioInsertionA";
            this.radioInsertionA.Size = new System.Drawing.Size(65, 17);
            this.radioInsertionA.TabIndex = 12;
            this.radioInsertionA.Text = "Insertion";
            this.radioInsertionA.UseVisualStyleBackColor = true;
            // 
            // radioSelectionA
            // 
            this.radioSelectionA.AutoSize = true;
            this.radioSelectionA.Checked = true;
            this.radioSelectionA.Location = new System.Drawing.Point(9, 18);
            this.radioSelectionA.Name = "radioSelectionA";
            this.radioSelectionA.Size = new System.Drawing.Size(69, 17);
            this.radioSelectionA.TabIndex = 11;
            this.radioSelectionA.TabStop = true;
            this.radioSelectionA.Text = "Selection";
            this.radioSelectionA.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Processing Speed:";
            // 
            // buttonSortA
            // 
            this.buttonSortA.Location = new System.Drawing.Point(97, 24);
            this.buttonSortA.Name = "buttonSortA";
            this.buttonSortA.Size = new System.Drawing.Size(56, 23);
            this.buttonSortA.TabIndex = 6;
            this.buttonSortA.Text = "Sort";
            this.buttonSortA.UseVisualStyleBackColor = true;
            this.buttonSortA.Click += new System.EventHandler(this.buttonSortA_Click);
            // 
            // TbSortSpdA
            // 
            this.TbSortSpdA.Location = new System.Drawing.Point(9, 83);
            this.TbSortSpdA.Name = "TbSortSpdA";
            this.TbSortSpdA.Size = new System.Drawing.Size(143, 20);
            this.TbSortSpdA.TabIndex = 9;
            // 
            // SearchGrpBoxA
            // 
            this.SearchGrpBoxA.Controls.Add(this.label1);
            this.SearchGrpBoxA.Controls.Add(this.TbTargetA);
            this.SearchGrpBoxA.Controls.Add(this.radioRecursiveA);
            this.SearchGrpBoxA.Controls.Add(this.radioIterativeA);
            this.SearchGrpBoxA.Controls.Add(this.searchLabelA);
            this.SearchGrpBoxA.Controls.Add(this.buttonSearchA);
            this.SearchGrpBoxA.Controls.Add(this.TbSearchSpdA);
            this.SearchGrpBoxA.Location = new System.Drawing.Point(124, 166);
            this.SearchGrpBoxA.Name = "SearchGrpBoxA";
            this.SearchGrpBoxA.Size = new System.Drawing.Size(160, 145);
            this.SearchGrpBoxA.TabIndex = 10;
            this.SearchGrpBoxA.TabStop = false;
            this.SearchGrpBoxA.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Target:";
            // 
            // TbTargetA
            // 
            this.TbTargetA.Location = new System.Drawing.Point(54, 63);
            this.TbTargetA.Name = "TbTargetA";
            this.TbTargetA.Size = new System.Drawing.Size(98, 20);
            this.TbTargetA.TabIndex = 13;
            // 
            // radioRecursiveA
            // 
            this.radioRecursiveA.AutoSize = true;
            this.radioRecursiveA.Location = new System.Drawing.Point(9, 38);
            this.radioRecursiveA.Name = "radioRecursiveA";
            this.radioRecursiveA.Size = new System.Drawing.Size(73, 17);
            this.radioRecursiveA.TabIndex = 12;
            this.radioRecursiveA.Text = "Recursive";
            this.radioRecursiveA.UseVisualStyleBackColor = true;
            // 
            // radioIterativeA
            // 
            this.radioIterativeA.AutoSize = true;
            this.radioIterativeA.Checked = true;
            this.radioIterativeA.Location = new System.Drawing.Point(9, 18);
            this.radioIterativeA.Name = "radioIterativeA";
            this.radioIterativeA.Size = new System.Drawing.Size(63, 17);
            this.radioIterativeA.TabIndex = 11;
            this.radioIterativeA.TabStop = true;
            this.radioIterativeA.Text = "Iterative";
            this.radioIterativeA.UseVisualStyleBackColor = true;
            // 
            // searchLabelA
            // 
            this.searchLabelA.AutoSize = true;
            this.searchLabelA.Location = new System.Drawing.Point(6, 94);
            this.searchLabelA.Name = "searchLabelA";
            this.searchLabelA.Size = new System.Drawing.Size(96, 13);
            this.searchLabelA.TabIndex = 10;
            this.searchLabelA.Text = "Processing Speed:";
            // 
            // buttonSearchA
            // 
            this.buttonSearchA.Location = new System.Drawing.Point(97, 24);
            this.buttonSearchA.Name = "buttonSearchA";
            this.buttonSearchA.Size = new System.Drawing.Size(56, 23);
            this.buttonSearchA.TabIndex = 6;
            this.buttonSearchA.Text = "Search";
            this.buttonSearchA.UseVisualStyleBackColor = true;
            this.buttonSearchA.Click += new System.EventHandler(this.buttonSearchA_Click);
            // 
            // TbSearchSpdA
            // 
            this.TbSearchSpdA.Location = new System.Drawing.Point(9, 110);
            this.TbSearchSpdA.Name = "TbSearchSpdA";
            this.TbSearchSpdA.Size = new System.Drawing.Size(143, 20);
            this.TbSearchSpdA.TabIndex = 9;
            // 
            // groupBoxB
            // 
            this.groupBoxB.Controls.Add(this.groupBox2);
            this.groupBoxB.Controls.Add(this.groupBox1);
            this.groupBoxB.Controls.Add(this.listBoxB);
            this.groupBoxB.Location = new System.Drawing.Point(308, 22);
            this.groupBoxB.Name = "groupBoxB";
            this.groupBoxB.Size = new System.Drawing.Size(291, 350);
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
            this.groupBox2.Location = new System.Drawing.Point(125, 27);
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
            this.radioSelectionB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Processing Speed:";
            // 
            // buttonSortB
            // 
            this.buttonSortB.Location = new System.Drawing.Point(97, 24);
            this.buttonSortB.Name = "buttonSortB";
            this.buttonSortB.Size = new System.Drawing.Size(56, 23);
            this.buttonSortB.TabIndex = 6;
            this.buttonSortB.Text = "Sort";
            this.buttonSortB.UseVisualStyleBackColor = true;
            this.buttonSortB.Click += new System.EventHandler(this.buttonSortB_Click);
            // 
            // TbSortSpdB
            // 
            this.TbSortSpdB.Location = new System.Drawing.Point(9, 83);
            this.TbSortSpdB.Name = "TbSortSpdB";
            this.TbSortSpdB.Size = new System.Drawing.Size(143, 20);
            this.TbSortSpdB.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbTargetB);
            this.groupBox1.Controls.Add(this.radioRecursiveB);
            this.groupBox1.Controls.Add(this.radioIterativeB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonSearchB);
            this.groupBox1.Controls.Add(this.TbSearchSpdB);
            this.groupBox1.Location = new System.Drawing.Point(123, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 145);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Target:";
            // 
            // TbTargetB
            // 
            this.TbTargetB.Location = new System.Drawing.Point(54, 63);
            this.TbTargetB.Name = "TbTargetB";
            this.TbTargetB.Size = new System.Drawing.Size(98, 20);
            this.TbTargetB.TabIndex = 13;
            // 
            // radioRecursiveB
            // 
            this.radioRecursiveB.AutoSize = true;
            this.radioRecursiveB.Location = new System.Drawing.Point(9, 38);
            this.radioRecursiveB.Name = "radioRecursiveB";
            this.radioRecursiveB.Size = new System.Drawing.Size(73, 17);
            this.radioRecursiveB.TabIndex = 12;
            this.radioRecursiveB.Text = "Recursive";
            this.radioRecursiveB.UseVisualStyleBackColor = true;
            // 
            // radioIterativeB
            // 
            this.radioIterativeB.AutoSize = true;
            this.radioIterativeB.Checked = true;
            this.radioIterativeB.Location = new System.Drawing.Point(9, 18);
            this.radioIterativeB.Name = "radioIterativeB";
            this.radioIterativeB.Size = new System.Drawing.Size(63, 17);
            this.radioIterativeB.TabIndex = 11;
            this.radioIterativeB.TabStop = true;
            this.radioIterativeB.Text = "Iterative";
            this.radioIterativeB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Processing Speed:";
            // 
            // buttonSearchB
            // 
            this.buttonSearchB.Location = new System.Drawing.Point(97, 24);
            this.buttonSearchB.Name = "buttonSearchB";
            this.buttonSearchB.Size = new System.Drawing.Size(56, 23);
            this.buttonSearchB.TabIndex = 6;
            this.buttonSearchB.Text = "Search";
            this.buttonSearchB.UseVisualStyleBackColor = true;
            this.buttonSearchB.Click += new System.EventHandler(this.buttonSearchB_Click);
            // 
            // TbSearchSpdB
            // 
            this.TbSearchSpdB.Location = new System.Drawing.Point(9, 110);
            this.TbSearchSpdB.Name = "TbSearchSpdB";
            this.TbSearchSpdB.Size = new System.Drawing.Size(143, 20);
            this.TbSearchSpdB.TabIndex = 9;
            // 
            // listBoxB
            // 
            this.listBoxB.FormattingEnabled = true;
            this.listBoxB.Location = new System.Drawing.Point(6, 20);
            this.listBoxB.Name = "listBoxB";
            this.listBoxB.Size = new System.Drawing.Size(111, 316);
            this.listBoxB.TabIndex = 1;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(729, 26);
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
            this.label6.Location = new System.Drawing.Point(625, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sigma:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(636, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mu:";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 100;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 500;
            // 
            // ProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 388);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.groupBoxB);
            this.Controls.Add(this.groupBoxA);
            this.Controls.Add(this.MeanNumWheel);
            this.Controls.Add(this.SigmaNumWheel);
            this.Controls.Add(this.listViewDisplay);
            this.Name = "ProcessingForm";
            this.Text = "MSSS Data Processing";
            ((System.ComponentModel.ISupportInitialize)(this.SigmaNumWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeanNumWheel)).EndInit();
            this.groupBoxA.ResumeLayout(false);
            this.SortGrpBoxA.ResumeLayout(false);
            this.SortGrpBoxA.PerformLayout();
            this.SearchGrpBoxA.ResumeLayout(false);
            this.SearchGrpBoxA.PerformLayout();
            this.groupBoxB.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDisplay;
        private System.Windows.Forms.ListBox listBoxA;
        private System.Windows.Forms.NumericUpDown SigmaNumWheel;
        private System.Windows.Forms.NumericUpDown MeanNumWheel;
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
    }
}

