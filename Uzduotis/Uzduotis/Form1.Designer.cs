namespace Uzduotis
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.browseFileLocationButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.folderLocationTextBox = new System.Windows.Forms.TextBox();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.removeIntrestChange = new System.Windows.Forms.Button();
            this.addIntrestChange = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.intrestChangeTextBox = new System.Windows.Forms.TextBox();
            this.intrestDateChangePicker = new System.Windows.Forms.DateTimePicker();
            this.dateListBox = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.moneyAmmountTextBox = new System.Windows.Forms.TextBox();
            this.intrestRateTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateSelectTo = new System.Windows.Forms.DateTimePicker();
            this.startCalculations = new System.Windows.Forms.Button();
            this.dateSelectFrom = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 681);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.splitContainer1.Panel1.Controls.Add(this.browseFileLocationButton);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.folderLocationTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.fileNameTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.removeIntrestChange);
            this.splitContainer1.Panel1.Controls.Add(this.addIntrestChange);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.intrestChangeTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.intrestDateChangePicker);
            this.splitContainer1.Panel1.Controls.Add(this.dateListBox);
            this.splitContainer1.Panel1.Controls.Add(this.clearButton);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.moneyAmmountTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.intrestRateTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dateSelectTo);
            this.splitContainer1.Panel1.Controls.Add(this.startCalculations);
            this.splitContainer1.Panel1.Controls.Add(this.dateSelectFrom);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Size = new System.Drawing.Size(1005, 681);
            this.splitContainer1.SplitterDistance = 347;
            this.splitContainer1.TabIndex = 1;
            // 
            // browseFileLocationButton
            // 
            this.browseFileLocationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.browseFileLocationButton.Location = new System.Drawing.Point(256, 567);
            this.browseFileLocationButton.Name = "browseFileLocationButton";
            this.browseFileLocationButton.Size = new System.Drawing.Size(88, 29);
            this.browseFileLocationButton.TabIndex = 25;
            this.browseFileLocationButton.Text = "Narsyt";
            this.browseFileLocationButton.UseVisualStyleBackColor = true;
            this.browseFileLocationButton.Click += new System.EventHandler(this.browseFileLocationButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.Location = new System.Drawing.Point(9, 570);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Vieta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(9, 535);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Pavadinimas:";
            // 
            // folderLocationTextBox
            // 
            this.folderLocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.folderLocationTextBox.Location = new System.Drawing.Point(67, 567);
            this.folderLocationTextBox.Name = "folderLocationTextBox";
            this.folderLocationTextBox.Size = new System.Drawing.Size(183, 26);
            this.folderLocationTextBox.TabIndex = 21;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.fileNameTextBox.Location = new System.Drawing.Point(124, 532);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(126, 26);
            this.fileNameTextBox.TabIndex = 20;
            // 
            // removeIntrestChange
            // 
            this.removeIntrestChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.removeIntrestChange.Location = new System.Drawing.Point(194, 364);
            this.removeIntrestChange.Name = "removeIntrestChange";
            this.removeIntrestChange.Size = new System.Drawing.Size(101, 30);
            this.removeIntrestChange.TabIndex = 19;
            this.removeIntrestChange.Text = "Panaikinti";
            this.removeIntrestChange.UseVisualStyleBackColor = true;
            this.removeIntrestChange.Click += new System.EventHandler(this.removeIntrestChange_Click);
            // 
            // addIntrestChange
            // 
            this.addIntrestChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.addIntrestChange.Location = new System.Drawing.Point(194, 328);
            this.addIntrestChange.Name = "addIntrestChange";
            this.addIntrestChange.Size = new System.Drawing.Size(101, 30);
            this.addIntrestChange.TabIndex = 18;
            this.addIntrestChange.Text = "Prideti";
            this.addIntrestChange.UseVisualStyleBackColor = true;
            this.addIntrestChange.Click += new System.EventHandler(this.addIntrestChange_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(50, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(9, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Palukanos:";
            // 
            // intrestChangeTextBox
            // 
            this.intrestChangeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.intrestChangeTextBox.Location = new System.Drawing.Point(106, 264);
            this.intrestChangeTextBox.Name = "intrestChangeTextBox";
            this.intrestChangeTextBox.Size = new System.Drawing.Size(144, 26);
            this.intrestChangeTextBox.TabIndex = 15;
            // 
            // intrestDateChangePicker
            // 
            this.intrestDateChangePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.intrestDateChangePicker.Location = new System.Drawing.Point(106, 295);
            this.intrestDateChangePicker.Name = "intrestDateChangePicker";
            this.intrestDateChangePicker.Size = new System.Drawing.Size(144, 26);
            this.intrestDateChangePicker.TabIndex = 14;
            this.intrestDateChangePicker.Value = new System.DateTime(2018, 5, 25, 23, 59, 59, 0);
            // 
            // dateListBox
            // 
            this.dateListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dateListBox.FormattingEnabled = true;
            this.dateListBox.ItemHeight = 20;
            this.dateListBox.Location = new System.Drawing.Point(13, 327);
            this.dateListBox.Name = "dateListBox";
            this.dateListBox.Size = new System.Drawing.Size(174, 164);
            this.dateListBox.TabIndex = 13;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.clearButton.Location = new System.Drawing.Point(247, 640);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 29);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Isvalyti";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(66, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pradine suma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Palukanos procentais:";
            // 
            // moneyAmmountTextBox
            // 
            this.moneyAmmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.moneyAmmountTextBox.Location = new System.Drawing.Point(189, 61);
            this.moneyAmmountTextBox.Name = "moneyAmmountTextBox";
            this.moneyAmmountTextBox.Size = new System.Drawing.Size(133, 26);
            this.moneyAmmountTextBox.TabIndex = 8;
            // 
            // intrestRateTextBox
            // 
            this.intrestRateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.intrestRateTextBox.Location = new System.Drawing.Point(189, 93);
            this.intrestRateTextBox.Name = "intrestRateTextBox";
            this.intrestRateTextBox.Size = new System.Drawing.Size(133, 26);
            this.intrestRateTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(101, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data iki:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(90, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data nuo:";
            // 
            // dateSelectTo
            // 
            this.dateSelectTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dateSelectTo.Location = new System.Drawing.Point(178, 167);
            this.dateSelectTo.Name = "dateSelectTo";
            this.dateSelectTo.Size = new System.Drawing.Size(144, 26);
            this.dateSelectTo.TabIndex = 2;
            this.dateSelectTo.Value = new System.DateTime(2018, 5, 25, 23, 59, 59, 0);
            // 
            // startCalculations
            // 
            this.startCalculations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.startCalculations.Location = new System.Drawing.Point(148, 640);
            this.startCalculations.Name = "startCalculations";
            this.startCalculations.Size = new System.Drawing.Size(93, 29);
            this.startCalculations.TabIndex = 1;
            this.startCalculations.Text = "Skaiciuoti";
            this.startCalculations.UseVisualStyleBackColor = true;
            this.startCalculations.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateSelectFrom
            // 
            this.dateSelectFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dateSelectFrom.Location = new System.Drawing.Point(178, 141);
            this.dateSelectFrom.Name = "dateSelectFrom";
            this.dateSelectFrom.Size = new System.Drawing.Size(144, 26);
            this.dateSelectFrom.TabIndex = 0;
            this.dateSelectFrom.Value = new System.DateTime(2018, 5, 25, 23, 59, 59, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dateSelectFrom;
        private System.Windows.Forms.Button startCalculations;
        private System.Windows.Forms.DateTimePicker dateSelectTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox intrestRateTextBox;
        private System.Windows.Forms.TextBox moneyAmmountTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox dateListBox;
        private System.Windows.Forms.Button removeIntrestChange;
        private System.Windows.Forms.Button addIntrestChange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox intrestChangeTextBox;
        private System.Windows.Forms.DateTimePicker intrestDateChangePicker;
        private System.Windows.Forms.Button browseFileLocationButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox folderLocationTextBox;
        private System.Windows.Forms.TextBox fileNameTextBox;
    }
}

