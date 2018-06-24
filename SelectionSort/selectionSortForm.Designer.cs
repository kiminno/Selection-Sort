namespace WindowsFormsApp1
{
    partial class SelectionSortForm
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
            this.numListBox = new System.Windows.Forms.ListBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.minButton = new System.Windows.Forms.Button();
            this.maxButton = new System.Windows.Forms.Button();
            this.meanButton = new System.Windows.Forms.Button();
            this.medianButton = new System.Windows.Forms.Button();
            this.modeButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.scrambleButton = new System.Windows.Forms.Button();
            this.ascendingRadioButton = new System.Windows.Forms.RadioButton();
            this.descendingRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.meanLabel = new System.Windows.Forms.Label();
            this.medianLabel = new System.Windows.Forms.Label();
            this.modeLabel = new System.Windows.Forms.Label();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numListBox
            // 
            this.numListBox.FormattingEnabled = true;
            this.numListBox.Location = new System.Drawing.Point(120, 213);
            this.numListBox.Name = "numListBox";
            this.numListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.numListBox.Size = new System.Drawing.Size(120, 238);
            this.numListBox.TabIndex = 0;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(264, 162);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // numTextBox
            // 
            this.numTextBox.Location = new System.Drawing.Point(129, 162);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(100, 20);
            this.numTextBox.TabIndex = 2;
            this.numTextBox.Click += new System.EventHandler(this.numTextBox_Click);
            // 
            // minButton
            // 
            this.minButton.Location = new System.Drawing.Point(265, 213);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(75, 23);
            this.minButton.TabIndex = 3;
            this.minButton.Text = "Min";
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // maxButton
            // 
            this.maxButton.Location = new System.Drawing.Point(265, 242);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(75, 23);
            this.maxButton.TabIndex = 4;
            this.maxButton.Text = "Max";
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // meanButton
            // 
            this.meanButton.Location = new System.Drawing.Point(265, 271);
            this.meanButton.Name = "meanButton";
            this.meanButton.Size = new System.Drawing.Size(75, 23);
            this.meanButton.TabIndex = 5;
            this.meanButton.Text = "Mean";
            this.meanButton.UseVisualStyleBackColor = true;
            this.meanButton.Click += new System.EventHandler(this.meanButton_Click);
            // 
            // medianButton
            // 
            this.medianButton.Location = new System.Drawing.Point(265, 300);
            this.medianButton.Name = "medianButton";
            this.medianButton.Size = new System.Drawing.Size(75, 23);
            this.medianButton.TabIndex = 6;
            this.medianButton.Text = "Median";
            this.medianButton.UseVisualStyleBackColor = true;
            this.medianButton.Click += new System.EventHandler(this.medianButton_Click);
            // 
            // modeButton
            // 
            this.modeButton.Location = new System.Drawing.Point(265, 329);
            this.modeButton.Name = "modeButton";
            this.modeButton.Size = new System.Drawing.Size(75, 23);
            this.modeButton.TabIndex = 7;
            this.modeButton.Text = "Mode";
            this.modeButton.UseVisualStyleBackColor = true;
            this.modeButton.Click += new System.EventHandler(this.modeButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(265, 358);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 8;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // scrambleButton
            // 
            this.scrambleButton.Location = new System.Drawing.Point(265, 429);
            this.scrambleButton.Name = "scrambleButton";
            this.scrambleButton.Size = new System.Drawing.Size(75, 23);
            this.scrambleButton.TabIndex = 9;
            this.scrambleButton.Text = "Scramble";
            this.scrambleButton.UseVisualStyleBackColor = true;
            this.scrambleButton.Click += new System.EventHandler(this.scrambleButton_Click_1);
            // 
            // ascendingRadioButton
            // 
            this.ascendingRadioButton.AutoSize = true;
            this.ascendingRadioButton.Checked = true;
            this.ascendingRadioButton.Location = new System.Drawing.Point(265, 388);
            this.ascendingRadioButton.Name = "ascendingRadioButton";
            this.ascendingRadioButton.Size = new System.Drawing.Size(75, 17);
            this.ascendingRadioButton.TabIndex = 10;
            this.ascendingRadioButton.TabStop = true;
            this.ascendingRadioButton.Text = "Ascending";
            this.ascendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // descendingRadioButton
            // 
            this.descendingRadioButton.AutoSize = true;
            this.descendingRadioButton.Location = new System.Drawing.Point(265, 406);
            this.descendingRadioButton.Name = "descendingRadioButton";
            this.descendingRadioButton.Size = new System.Drawing.Size(82, 17);
            this.descendingRadioButton.TabIndex = 11;
            this.descendingRadioButton.Text = "Descending";
            this.descendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter a number:";
            // 
            // meanLabel
            // 
            this.meanLabel.AutoSize = true;
            this.meanLabel.Location = new System.Drawing.Point(353, 276);
            this.meanLabel.Name = "meanLabel";
            this.meanLabel.Size = new System.Drawing.Size(40, 13);
            this.meanLabel.TabIndex = 13;
            this.meanLabel.Text = "Mean: ";
            // 
            // medianLabel
            // 
            this.medianLabel.AutoSize = true;
            this.medianLabel.Location = new System.Drawing.Point(353, 306);
            this.medianLabel.Name = "medianLabel";
            this.medianLabel.Size = new System.Drawing.Size(48, 13);
            this.medianLabel.TabIndex = 14;
            this.medianLabel.Text = "Median: ";
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(353, 334);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(40, 13);
            this.modeLabel.TabIndex = 15;
            this.modeLabel.Text = "Mode: ";
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(356, 162);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(75, 23);
            this.clearAllButton.TabIndex = 16;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.miku_welcome;
            this.pictureBox1.Location = new System.Drawing.Point(101, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nancy Ngo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Selection Sort";
            // 
            // selectionSortForm
            // 
            this.AcceptButton = this.enterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(476, 484);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.medianLabel);
            this.Controls.Add(this.meanLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descendingRadioButton);
            this.Controls.Add(this.ascendingRadioButton);
            this.Controls.Add(this.scrambleButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.modeButton);
            this.Controls.Add(this.medianButton);
            this.Controls.Add(this.meanButton);
            this.Controls.Add(this.maxButton);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.numListBox);
            this.Name = "selectionSortForm";
            this.Text = "Selection Sort (Nancy Ngo)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox numListBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button maxButton;
        private System.Windows.Forms.Button meanButton;
        private System.Windows.Forms.Button medianButton;
        private System.Windows.Forms.Button modeButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button scrambleButton;
        private System.Windows.Forms.RadioButton ascendingRadioButton;
        private System.Windows.Forms.RadioButton descendingRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label meanLabel;
        private System.Windows.Forms.Label medianLabel;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

