namespace CLCRelationMerge
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OriginalButton = new System.Windows.Forms.Button();
            this.CLCButton = new System.Windows.Forms.Button();
            this.OutputButton = new System.Windows.Forms.Button();
            this.MergeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OriginalFileBox = new System.Windows.Forms.TextBox();
            this.CLCFileBox = new System.Windows.Forms.TextBox();
            this.OutputFileBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioPanel = new System.Windows.Forms.Panel();
            this.showClcAreaButton = new System.Windows.Forms.Button();
            this.fromApiRadioButton = new System.Windows.Forms.RadioButton();
            this.fromFileRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.boundingBoxSelectButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioPanel2 = new System.Windows.Forms.Panel();
            this.fromExternalPolyRadioButton = new System.Windows.Forms.RadioButton();
            this.fromClcRadioButton = new System.Windows.Forms.RadioButton();
            this.polyFileBox = new System.Windows.Forms.TextBox();
            this.OFD1 = new System.Windows.Forms.OpenFileDialog();
            this.SFD1 = new System.Windows.Forms.SaveFileDialog();
            this.bgWorker1 = new System.ComponentModel.BackgroundWorker();
            this.OFD2 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.radioPanel.SuspendLayout();
            this.radioPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Controls.Add(this.OriginalButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.CLCButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.OutputButton, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.MergeButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.OutputLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.OriginalFileBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CLCFileBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.OutputFileBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.boundingBoxSelectButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.radioPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.polyFileBox, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(444, 177);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // OriginalButton
            // 
            this.OriginalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginalButton.Enabled = false;
            this.OriginalButton.Location = new System.Drawing.Point(380, 25);
            this.OriginalButton.Margin = new System.Windows.Forms.Padding(1);
            this.OriginalButton.Name = "OriginalButton";
            this.OriginalButton.Size = new System.Drawing.Size(63, 22);
            this.OriginalButton.TabIndex = 0;
            this.OriginalButton.Text = "Change";
            this.OriginalButton.UseVisualStyleBackColor = true;
            this.OriginalButton.Click += new System.EventHandler(this.OriginalButton_Click);
            // 
            // CLCButton
            // 
            this.CLCButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CLCButton.Location = new System.Drawing.Point(380, 97);
            this.CLCButton.Margin = new System.Windows.Forms.Padding(1);
            this.CLCButton.Name = "CLCButton";
            this.CLCButton.Size = new System.Drawing.Size(63, 22);
            this.CLCButton.TabIndex = 1;
            this.CLCButton.Text = "Change";
            this.CLCButton.UseVisualStyleBackColor = true;
            this.CLCButton.Click += new System.EventHandler(this.CLCButton_Click);
            // 
            // OutputButton
            // 
            this.OutputButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputButton.Location = new System.Drawing.Point(380, 121);
            this.OutputButton.Margin = new System.Windows.Forms.Padding(1);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(63, 22);
            this.OutputButton.TabIndex = 2;
            this.OutputButton.Text = "Change";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // MergeButton
            // 
            this.MergeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MergeButton.Location = new System.Drawing.Point(3, 147);
            this.MergeButton.Name = "MergeButton";
            this.MergeButton.Size = new System.Drawing.Size(114, 27);
            this.MergeButton.TabIndex = 3;
            this.MergeButton.Text = "Start merge";
            this.MergeButton.UseVisualStyleBackColor = true;
            this.MergeButton.Click += new System.EventHandler(this.MergeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "CLC data file:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output file:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputLabel.Location = new System.Drawing.Point(123, 144);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(253, 33);
            this.OutputLabel.TabIndex = 7;
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OutputLabel.Click += new System.EventHandler(this.OutputLabel_Click);
            // 
            // OriginalFileBox
            // 
            this.OriginalFileBox.BackColor = System.Drawing.SystemColors.Window;
            this.OriginalFileBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginalFileBox.Location = new System.Drawing.Point(123, 27);
            this.OriginalFileBox.Name = "OriginalFileBox";
            this.OriginalFileBox.ReadOnly = true;
            this.OriginalFileBox.Size = new System.Drawing.Size(253, 20);
            this.OriginalFileBox.TabIndex = 8;
            // 
            // CLCFileBox
            // 
            this.CLCFileBox.BackColor = System.Drawing.SystemColors.Window;
            this.CLCFileBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CLCFileBox.Location = new System.Drawing.Point(123, 99);
            this.CLCFileBox.Name = "CLCFileBox";
            this.CLCFileBox.ReadOnly = true;
            this.CLCFileBox.Size = new System.Drawing.Size(253, 20);
            this.CLCFileBox.TabIndex = 9;
            // 
            // OutputFileBox
            // 
            this.OutputFileBox.BackColor = System.Drawing.SystemColors.Window;
            this.OutputFileBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputFileBox.Location = new System.Drawing.Point(123, 123);
            this.OutputFileBox.Name = "OutputFileBox";
            this.OutputFileBox.ReadOnly = true;
            this.OutputFileBox.Size = new System.Drawing.Size(253, 20);
            this.OutputFileBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Original data source:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioPanel
            // 
            this.radioPanel.Controls.Add(this.showClcAreaButton);
            this.radioPanel.Controls.Add(this.fromApiRadioButton);
            this.radioPanel.Controls.Add(this.fromFileRadioButton);
            this.radioPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioPanel.Location = new System.Drawing.Point(120, 0);
            this.radioPanel.Margin = new System.Windows.Forms.Padding(0);
            this.radioPanel.Name = "radioPanel";
            this.radioPanel.Size = new System.Drawing.Size(259, 24);
            this.radioPanel.TabIndex = 12;
            // 
            // showClcAreaButton
            // 
            this.showClcAreaButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.showClcAreaButton.Location = new System.Drawing.Point(110, 0);
            this.showClcAreaButton.Name = "showClcAreaButton";
            this.showClcAreaButton.Size = new System.Drawing.Size(90, 24);
            this.showClcAreaButton.TabIndex = 11;
            this.showClcAreaButton.Text = "Show CLC area";
            this.showClcAreaButton.UseVisualStyleBackColor = true;
            this.showClcAreaButton.Click += new System.EventHandler(this.showClcAreaButton_Click);
            // 
            // fromApiRadioButton
            // 
            this.fromApiRadioButton.AutoSize = true;
            this.fromApiRadioButton.Checked = true;
            this.fromApiRadioButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.fromApiRadioButton.Location = new System.Drawing.Point(41, 0);
            this.fromApiRadioButton.Name = "fromApiRadioButton";
            this.fromApiRadioButton.Size = new System.Drawing.Size(69, 24);
            this.fromApiRadioButton.TabIndex = 1;
            this.fromApiRadioButton.TabStop = true;
            this.fromApiRadioButton.Text = "OSM API";
            this.fromApiRadioButton.UseVisualStyleBackColor = true;
            this.fromApiRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // fromFileRadioButton
            // 
            this.fromFileRadioButton.AutoSize = true;
            this.fromFileRadioButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.fromFileRadioButton.Location = new System.Drawing.Point(0, 0);
            this.fromFileRadioButton.Name = "fromFileRadioButton";
            this.fromFileRadioButton.Size = new System.Drawing.Size(41, 24);
            this.fromFileRadioButton.TabIndex = 0;
            this.fromFileRadioButton.Text = "File";
            this.fromFileRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Original data file:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // boundingBoxSelectButton
            // 
            this.boundingBoxSelectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boundingBoxSelectButton.Enabled = false;
            this.boundingBoxSelectButton.Location = new System.Drawing.Point(380, 73);
            this.boundingBoxSelectButton.Margin = new System.Windows.Forms.Padding(1);
            this.boundingBoxSelectButton.Name = "boundingBoxSelectButton";
            this.boundingBoxSelectButton.Size = new System.Drawing.Size(63, 22);
            this.boundingBoxSelectButton.TabIndex = 15;
            this.boundingBoxSelectButton.Text = "Change";
            this.boundingBoxSelectButton.UseVisualStyleBackColor = true;
            this.boundingBoxSelectButton.Click += new System.EventHandler(this.boundingBoxSelectButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bounding box source:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Poly file:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioPanel2
            // 
            this.radioPanel2.Controls.Add(this.fromExternalPolyRadioButton);
            this.radioPanel2.Controls.Add(this.fromClcRadioButton);
            this.radioPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioPanel2.Location = new System.Drawing.Point(120, 48);
            this.radioPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.radioPanel2.Name = "radioPanel2";
            this.radioPanel2.Size = new System.Drawing.Size(259, 24);
            this.radioPanel2.TabIndex = 18;
            // 
            // fromExternalPolyRadioButton
            // 
            this.fromExternalPolyRadioButton.AutoSize = true;
            this.fromExternalPolyRadioButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.fromExternalPolyRadioButton.Location = new System.Drawing.Point(146, 0);
            this.fromExternalPolyRadioButton.Name = "fromExternalPolyRadioButton";
            this.fromExternalPolyRadioButton.Size = new System.Drawing.Size(101, 24);
            this.fromExternalPolyRadioButton.TabIndex = 1;
            this.fromExternalPolyRadioButton.Text = "External poly file";
            this.fromExternalPolyRadioButton.UseVisualStyleBackColor = true;
            this.fromExternalPolyRadioButton.CheckedChanged += new System.EventHandler(this.fromExternalPolyRadioButton_CheckedChanged_1);
            // 
            // fromClcRadioButton
            // 
            this.fromClcRadioButton.AutoSize = true;
            this.fromClcRadioButton.Checked = true;
            this.fromClcRadioButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.fromClcRadioButton.Location = new System.Drawing.Point(0, 0);
            this.fromClcRadioButton.Name = "fromClcRadioButton";
            this.fromClcRadioButton.Size = new System.Drawing.Size(146, 24);
            this.fromClcRadioButton.TabIndex = 0;
            this.fromClcRadioButton.TabStop = true;
            this.fromClcRadioButton.Text = "CLC data file (from nodes)";
            this.fromClcRadioButton.UseVisualStyleBackColor = true;
            // 
            // polyFileBox
            // 
            this.polyFileBox.BackColor = System.Drawing.SystemColors.Window;
            this.polyFileBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.polyFileBox.Location = new System.Drawing.Point(123, 75);
            this.polyFileBox.Name = "polyFileBox";
            this.polyFileBox.ReadOnly = true;
            this.polyFileBox.Size = new System.Drawing.Size(253, 20);
            this.polyFileBox.TabIndex = 19;
            // 
            // OFD1
            // 
            this.OFD1.DefaultExt = "osm";
            this.OFD1.Filter = "OSM Files|*.osm|All files|*.*";
            // 
            // SFD1
            // 
            this.SFD1.DefaultExt = "osm";
            this.SFD1.FileName = "output";
            this.SFD1.Filter = "OSM Files|*.osm|All files|*.*";
            // 
            // bgWorker1
            // 
            this.bgWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker1_DoWork);
            this.bgWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker1_RunWorkerCompleted);
            // 
            // OFD2
            // 
            this.OFD2.DefaultExt = "poly";
            this.OFD2.Filter = "Poly files|*.poly|All files|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 177);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(100, 215);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "CLC Relation Merge v0.1 by Plutoz";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.radioPanel.ResumeLayout(false);
            this.radioPanel.PerformLayout();
            this.radioPanel2.ResumeLayout(false);
            this.radioPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button OriginalButton;
        private System.Windows.Forms.Button CLCButton;
        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.Button MergeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox OriginalFileBox;
        private System.Windows.Forms.TextBox CLCFileBox;
        private System.Windows.Forms.TextBox OutputFileBox;
        private System.Windows.Forms.OpenFileDialog OFD1;
        private System.Windows.Forms.SaveFileDialog SFD1;
        private System.ComponentModel.BackgroundWorker bgWorker1;
        private System.Windows.Forms.Button showClcAreaButton;
        private System.Windows.Forms.Panel radioPanel;
        private System.Windows.Forms.RadioButton fromFileRadioButton;
        private System.Windows.Forms.RadioButton fromApiRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button boundingBoxSelectButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel radioPanel2;
        private System.Windows.Forms.RadioButton fromExternalPolyRadioButton;
        private System.Windows.Forms.RadioButton fromClcRadioButton;
        private System.Windows.Forms.TextBox polyFileBox;
        private System.Windows.Forms.OpenFileDialog OFD2;
    }
}

