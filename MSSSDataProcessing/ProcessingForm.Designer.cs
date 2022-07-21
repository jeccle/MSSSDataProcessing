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
            this.listViewDisplay = new System.Windows.Forms.ListView();
            this.ListBoxA = new System.Windows.Forms.ListBox();
            this.SigmaNumWheel = new System.Windows.Forms.NumericUpDown();
            this.MeanNumWheel = new System.Windows.Forms.NumericUpDown();
            this.groupBoxA = new System.Windows.Forms.GroupBox();
            this.groupBoxB = new System.Windows.Forms.GroupBox();
            this.ListBoxB = new System.Windows.Forms.ListBox();
            this.searchBtnA = new System.Windows.Forms.Button();
            this.SearchSpeedTbA = new System.Windows.Forms.TextBox();
            this.SearchGrpBoxA = new System.Windows.Forms.GroupBox();
            this.searchLabelA = new System.Windows.Forms.Label();
            this.RadioIterativeA = new System.Windows.Forms.RadioButton();
            this.RadioRecursiveA = new System.Windows.Forms.RadioButton();
            this.TargetTbA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TargetTbB = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchSpeedTbB = new System.Windows.Forms.TextBox();
            this.SortGrpBoxA = new System.Windows.Forms.GroupBox();
            this.RadioInsertionA = new System.Windows.Forms.RadioButton();
            this.RadioSelectionA = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SortBtnA = new System.Windows.Forms.Button();
            this.SortSpeedTbA = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioInsertionB = new System.Windows.Forms.RadioButton();
            this.RadioSelectionB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SortBtnB = new System.Windows.Forms.Button();
            this.SortSpeedTbB = new System.Windows.Forms.TextBox();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SigmaNumWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeanNumWheel)).BeginInit();
            this.groupBoxA.SuspendLayout();
            this.groupBoxB.SuspendLayout();
            this.SearchGrpBoxA.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SortGrpBoxA.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewDisplay
            // 
            this.listViewDisplay.HideSelection = false;
            this.listViewDisplay.Location = new System.Drawing.Point(620, 81);
            this.listViewDisplay.Name = "listViewDisplay";
            this.listViewDisplay.Size = new System.Drawing.Size(154, 284);
            this.listViewDisplay.TabIndex = 0;
            this.listViewDisplay.UseCompatibleStateImageBehavior = false;
            // 
            // ListBoxA
            // 
            this.ListBoxA.FormattingEnabled = true;
            this.ListBoxA.Location = new System.Drawing.Point(6, 20);
            this.ListBoxA.Name = "ListBoxA";
            this.ListBoxA.Size = new System.Drawing.Size(111, 316);
            this.ListBoxA.TabIndex = 1;
            // 
            // SigmaNumWheel
            // 
            this.SigmaNumWheel.Location = new System.Drawing.Point(667, 29);
            this.SigmaNumWheel.Name = "SigmaNumWheel";
            this.SigmaNumWheel.Size = new System.Drawing.Size(41, 20);
            this.SigmaNumWheel.TabIndex = 7;
            // 
            // MeanNumWheel
            // 
            this.MeanNumWheel.Location = new System.Drawing.Point(667, 55);
            this.MeanNumWheel.Name = "MeanNumWheel";
            this.MeanNumWheel.Size = new System.Drawing.Size(41, 20);
            this.MeanNumWheel.TabIndex = 8;
            // 
            // groupBoxA
            // 
            this.groupBoxA.Controls.Add(this.SortGrpBoxA);
            this.groupBoxA.Controls.Add(this.SearchGrpBoxA);
            this.groupBoxA.Controls.Add(this.ListBoxA);
            this.groupBoxA.Location = new System.Drawing.Point(12, 22);
            this.groupBoxA.Name = "groupBoxA";
            this.groupBoxA.Size = new System.Drawing.Size(290, 350);
            this.groupBoxA.TabIndex = 9;
            this.groupBoxA.TabStop = false;
            this.groupBoxA.Text = "Sensor A";
            // 
            // groupBoxB
            // 
            this.groupBoxB.Controls.Add(this.groupBox2);
            this.groupBoxB.Controls.Add(this.groupBox1);
            this.groupBoxB.Controls.Add(this.ListBoxB);
            this.groupBoxB.Location = new System.Drawing.Point(308, 22);
            this.groupBoxB.Name = "groupBoxB";
            this.groupBoxB.Size = new System.Drawing.Size(291, 350);
            this.groupBoxB.TabIndex = 10;
            this.groupBoxB.TabStop = false;
            this.groupBoxB.Text = "Sensor B";
            // 
            // ListBoxB
            // 
            this.ListBoxB.FormattingEnabled = true;
            this.ListBoxB.Location = new System.Drawing.Point(6, 20);
            this.ListBoxB.Name = "ListBoxB";
            this.ListBoxB.Size = new System.Drawing.Size(111, 316);
            this.ListBoxB.TabIndex = 1;
            // 
            // searchBtnA
            // 
            this.searchBtnA.Location = new System.Drawing.Point(97, 24);
            this.searchBtnA.Name = "searchBtnA";
            this.searchBtnA.Size = new System.Drawing.Size(56, 23);
            this.searchBtnA.TabIndex = 6;
            this.searchBtnA.Text = "Search";
            this.searchBtnA.UseVisualStyleBackColor = true;
            // 
            // SearchSpeedTbA
            // 
            this.SearchSpeedTbA.Location = new System.Drawing.Point(9, 110);
            this.SearchSpeedTbA.Name = "SearchSpeedTbA";
            this.SearchSpeedTbA.Size = new System.Drawing.Size(143, 20);
            this.SearchSpeedTbA.TabIndex = 9;
            // 
            // SearchGrpBoxA
            // 
            this.SearchGrpBoxA.Controls.Add(this.label1);
            this.SearchGrpBoxA.Controls.Add(this.TargetTbA);
            this.SearchGrpBoxA.Controls.Add(this.RadioRecursiveA);
            this.SearchGrpBoxA.Controls.Add(this.RadioIterativeA);
            this.SearchGrpBoxA.Controls.Add(this.searchLabelA);
            this.SearchGrpBoxA.Controls.Add(this.searchBtnA);
            this.SearchGrpBoxA.Controls.Add(this.SearchSpeedTbA);
            this.SearchGrpBoxA.Location = new System.Drawing.Point(124, 166);
            this.SearchGrpBoxA.Name = "SearchGrpBoxA";
            this.SearchGrpBoxA.Size = new System.Drawing.Size(160, 145);
            this.SearchGrpBoxA.TabIndex = 10;
            this.SearchGrpBoxA.TabStop = false;
            this.SearchGrpBoxA.Text = "Search";
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
            // RadioIterativeA
            // 
            this.RadioIterativeA.AutoSize = true;
            this.RadioIterativeA.Location = new System.Drawing.Point(9, 18);
            this.RadioIterativeA.Name = "RadioIterativeA";
            this.RadioIterativeA.Size = new System.Drawing.Size(63, 17);
            this.RadioIterativeA.TabIndex = 11;
            this.RadioIterativeA.TabStop = true;
            this.RadioIterativeA.Text = "Iterative";
            this.RadioIterativeA.UseVisualStyleBackColor = true;
            // 
            // RadioRecursiveA
            // 
            this.RadioRecursiveA.AutoSize = true;
            this.RadioRecursiveA.Location = new System.Drawing.Point(9, 38);
            this.RadioRecursiveA.Name = "RadioRecursiveA";
            this.RadioRecursiveA.Size = new System.Drawing.Size(73, 17);
            this.RadioRecursiveA.TabIndex = 12;
            this.RadioRecursiveA.TabStop = true;
            this.RadioRecursiveA.Text = "Recursive";
            this.RadioRecursiveA.UseVisualStyleBackColor = true;
            // 
            // TargetTbA
            // 
            this.TargetTbA.Location = new System.Drawing.Point(54, 63);
            this.TargetTbA.Name = "TargetTbA";
            this.TargetTbA.Size = new System.Drawing.Size(98, 20);
            this.TargetTbA.TabIndex = 13;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TargetTbB);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.SearchSpeedTbB);
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
            // TargetTbB
            // 
            this.TargetTbB.Location = new System.Drawing.Point(54, 63);
            this.TargetTbB.Name = "TargetTbB";
            this.TargetTbB.Size = new System.Drawing.Size(98, 20);
            this.TargetTbB.TabIndex = 13;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Recursive";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(9, 18);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(63, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Iterative";
            this.radioButton3.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SearchSpeedTbB
            // 
            this.SearchSpeedTbB.Location = new System.Drawing.Point(9, 110);
            this.SearchSpeedTbB.Name = "SearchSpeedTbB";
            this.SearchSpeedTbB.Size = new System.Drawing.Size(143, 20);
            this.SearchSpeedTbB.TabIndex = 9;
            // 
            // SortGrpBoxA
            // 
            this.SortGrpBoxA.Controls.Add(this.RadioInsertionA);
            this.SortGrpBoxA.Controls.Add(this.RadioSelectionA);
            this.SortGrpBoxA.Controls.Add(this.label5);
            this.SortGrpBoxA.Controls.Add(this.SortBtnA);
            this.SortGrpBoxA.Controls.Add(this.SortSpeedTbA);
            this.SortGrpBoxA.Location = new System.Drawing.Point(123, 27);
            this.SortGrpBoxA.Name = "SortGrpBoxA";
            this.SortGrpBoxA.Size = new System.Drawing.Size(160, 118);
            this.SortGrpBoxA.TabIndex = 11;
            this.SortGrpBoxA.TabStop = false;
            this.SortGrpBoxA.Text = "Sort";
            // 
            // RadioInsertionA
            // 
            this.RadioInsertionA.AutoSize = true;
            this.RadioInsertionA.Location = new System.Drawing.Point(9, 38);
            this.RadioInsertionA.Name = "RadioInsertionA";
            this.RadioInsertionA.Size = new System.Drawing.Size(65, 17);
            this.RadioInsertionA.TabIndex = 12;
            this.RadioInsertionA.TabStop = true;
            this.RadioInsertionA.Text = "Insertion";
            this.RadioInsertionA.UseVisualStyleBackColor = true;
            // 
            // RadioSelectionA
            // 
            this.RadioSelectionA.AutoSize = true;
            this.RadioSelectionA.Location = new System.Drawing.Point(9, 18);
            this.RadioSelectionA.Name = "RadioSelectionA";
            this.RadioSelectionA.Size = new System.Drawing.Size(69, 17);
            this.RadioSelectionA.TabIndex = 11;
            this.RadioSelectionA.TabStop = true;
            this.RadioSelectionA.Text = "Selection";
            this.RadioSelectionA.UseVisualStyleBackColor = true;
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
            // SortBtnA
            // 
            this.SortBtnA.Location = new System.Drawing.Point(97, 24);
            this.SortBtnA.Name = "SortBtnA";
            this.SortBtnA.Size = new System.Drawing.Size(56, 23);
            this.SortBtnA.TabIndex = 6;
            this.SortBtnA.Text = "Sort";
            this.SortBtnA.UseVisualStyleBackColor = true;
            // 
            // SortSpeedTbA
            // 
            this.SortSpeedTbA.Location = new System.Drawing.Point(9, 83);
            this.SortSpeedTbA.Name = "SortSpeedTbA";
            this.SortSpeedTbA.Size = new System.Drawing.Size(143, 20);
            this.SortSpeedTbA.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioInsertionB);
            this.groupBox2.Controls.Add(this.RadioSelectionB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.SortBtnB);
            this.groupBox2.Controls.Add(this.SortSpeedTbB);
            this.groupBox2.Location = new System.Drawing.Point(125, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 118);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort";
            // 
            // RadioInsertionB
            // 
            this.RadioInsertionB.AutoSize = true;
            this.RadioInsertionB.Location = new System.Drawing.Point(9, 38);
            this.RadioInsertionB.Name = "RadioInsertionB";
            this.RadioInsertionB.Size = new System.Drawing.Size(65, 17);
            this.RadioInsertionB.TabIndex = 12;
            this.RadioInsertionB.TabStop = true;
            this.RadioInsertionB.Text = "Insertion";
            this.RadioInsertionB.UseVisualStyleBackColor = true;
            // 
            // RadioSelectionB
            // 
            this.RadioSelectionB.AutoSize = true;
            this.RadioSelectionB.Location = new System.Drawing.Point(9, 18);
            this.RadioSelectionB.Name = "RadioSelectionB";
            this.RadioSelectionB.Size = new System.Drawing.Size(69, 17);
            this.RadioSelectionB.TabIndex = 11;
            this.RadioSelectionB.TabStop = true;
            this.RadioSelectionB.Text = "Selection";
            this.RadioSelectionB.UseVisualStyleBackColor = true;
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
            // SortBtnB
            // 
            this.SortBtnB.Location = new System.Drawing.Point(97, 24);
            this.SortBtnB.Name = "SortBtnB";
            this.SortBtnB.Size = new System.Drawing.Size(56, 23);
            this.SortBtnB.TabIndex = 6;
            this.SortBtnB.Text = "Sort";
            this.SortBtnB.UseVisualStyleBackColor = true;
            // 
            // SortSpeedTbB
            // 
            this.SortSpeedTbB.Location = new System.Drawing.Point(9, 83);
            this.SortSpeedTbB.Name = "SortSpeedTbB";
            this.SortSpeedTbB.Size = new System.Drawing.Size(143, 20);
            this.SortSpeedTbB.TabIndex = 9;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(729, 26);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(45, 49);
            this.LoadBtn.TabIndex = 11;
            this.LoadBtn.Text = "Load Data";
            this.LoadBtn.UseVisualStyleBackColor = true;
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
            this.groupBoxB.ResumeLayout(false);
            this.SearchGrpBoxA.ResumeLayout(false);
            this.SearchGrpBoxA.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SortGrpBoxA.ResumeLayout(false);
            this.SortGrpBoxA.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDisplay;
        private System.Windows.Forms.ListBox ListBoxA;
        private System.Windows.Forms.NumericUpDown SigmaNumWheel;
        private System.Windows.Forms.NumericUpDown MeanNumWheel;
        private System.Windows.Forms.GroupBox groupBoxA;
        private System.Windows.Forms.Button searchBtnA;
        private System.Windows.Forms.GroupBox groupBoxB;
        private System.Windows.Forms.ListBox ListBoxB;
        private System.Windows.Forms.GroupBox SearchGrpBoxA;
        private System.Windows.Forms.TextBox SearchSpeedTbA;
        private System.Windows.Forms.GroupBox SortGrpBoxA;
        private System.Windows.Forms.RadioButton RadioInsertionA;
        private System.Windows.Forms.RadioButton RadioSelectionA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SortBtnA;
        private System.Windows.Forms.TextBox SortSpeedTbA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TargetTbA;
        private System.Windows.Forms.RadioButton RadioRecursiveA;
        private System.Windows.Forms.RadioButton RadioIterativeA;
        private System.Windows.Forms.Label searchLabelA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TargetTbB;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SearchSpeedTbB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RadioInsertionB;
        private System.Windows.Forms.RadioButton RadioSelectionB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SortBtnB;
        private System.Windows.Forms.TextBox SortSpeedTbB;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

