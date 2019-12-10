namespace Cipher2
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
            this.wordLabelLabel = new System.Windows.Forms.Label();
            this.cipherSumLabelLabel = new System.Windows.Forms.Label();
            this.symbolBreakdownLabelLabel = new System.Windows.Forms.Label();
            this.sumBreakdownLabelLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cipherPickerComboBox = new System.Windows.Forms.ComboBox();
            this.cipherButtonFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sumBreakdownLabel = new System.Windows.Forms.Label();
            this.symbolBreakdownLabel = new System.Windows.Forms.Label();
            this.cipherSumLabel = new System.Windows.Forms.Label();
            this.wordLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wordLabelLabel
            // 
            this.wordLabelLabel.AutoSize = true;
            this.wordLabelLabel.Location = new System.Drawing.Point(329, 9);
            this.wordLabelLabel.Name = "wordLabelLabel";
            this.wordLabelLabel.Size = new System.Drawing.Size(42, 17);
            this.wordLabelLabel.TabIndex = 0;
            this.wordLabelLabel.Text = "Word";
            // 
            // cipherSumLabelLabel
            // 
            this.cipherSumLabelLabel.AutoSize = true;
            this.cipherSumLabelLabel.Location = new System.Drawing.Point(329, 83);
            this.cipherSumLabelLabel.Name = "cipherSumLabelLabel";
            this.cipherSumLabelLabel.Size = new System.Drawing.Size(90, 17);
            this.cipherSumLabelLabel.TabIndex = 1;
            this.cipherSumLabelLabel.Text = "Sum of Word";
            // 
            // symbolBreakdownLabelLabel
            // 
            this.symbolBreakdownLabelLabel.AutoSize = true;
            this.symbolBreakdownLabelLabel.Location = new System.Drawing.Point(329, 159);
            this.symbolBreakdownLabelLabel.Name = "symbolBreakdownLabelLabel";
            this.symbolBreakdownLabelLabel.Size = new System.Drawing.Size(128, 17);
            this.symbolBreakdownLabelLabel.TabIndex = 2;
            this.symbolBreakdownLabelLabel.Text = "Symbol Breakdown";
            // 
            // sumBreakdownLabelLabel
            // 
            this.sumBreakdownLabelLabel.AutoSize = true;
            this.sumBreakdownLabelLabel.Location = new System.Drawing.Point(329, 265);
            this.sumBreakdownLabelLabel.Name = "sumBreakdownLabelLabel";
            this.sumBreakdownLabelLabel.Size = new System.Drawing.Size(110, 17);
            this.sumBreakdownLabelLabel.TabIndex = 3;
            this.sumBreakdownLabelLabel.Text = "Sum Breakdown";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(332, 377);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cipherPickerComboBox
            // 
            this.cipherPickerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cipherPickerComboBox.FormattingEnabled = true;
            this.cipherPickerComboBox.Location = new System.Drawing.Point(24, 13);
            this.cipherPickerComboBox.Name = "cipherPickerComboBox";
            this.cipherPickerComboBox.Size = new System.Drawing.Size(121, 24);
            this.cipherPickerComboBox.TabIndex = 6;
            this.cipherPickerComboBox.SelectedIndexChanged += new System.EventHandler(this.cipherPickerComboBox_SelectedIndexChanged);
            // 
            // cipherButtonFlowLayoutPanel
            // 
            this.cipherButtonFlowLayoutPanel.Location = new System.Drawing.Point(24, 54);
            this.cipherButtonFlowLayoutPanel.Name = "cipherButtonFlowLayoutPanel";
            this.cipherButtonFlowLayoutPanel.Size = new System.Drawing.Size(287, 345);
            this.cipherButtonFlowLayoutPanel.TabIndex = 7;
            // 
            // sumBreakdownLabel
            // 
            this.sumBreakdownLabel.AutoSize = true;
            this.sumBreakdownLabel.Location = new System.Drawing.Point(329, 294);
            this.sumBreakdownLabel.MaximumSize = new System.Drawing.Size(200, 60);
            this.sumBreakdownLabel.Name = "sumBreakdownLabel";
            this.sumBreakdownLabel.Size = new System.Drawing.Size(110, 17);
            this.sumBreakdownLabel.TabIndex = 11;
            this.sumBreakdownLabel.Text = "Sum Breakdown";
            // 
            // symbolBreakdownLabel
            // 
            this.symbolBreakdownLabel.AutoSize = true;
            this.symbolBreakdownLabel.Location = new System.Drawing.Point(329, 186);
            this.symbolBreakdownLabel.MaximumSize = new System.Drawing.Size(200, 60);
            this.symbolBreakdownLabel.Name = "symbolBreakdownLabel";
            this.symbolBreakdownLabel.Size = new System.Drawing.Size(128, 17);
            this.symbolBreakdownLabel.TabIndex = 10;
            this.symbolBreakdownLabel.Text = "Symbol Breakdown";
            // 
            // cipherSumLabel
            // 
            this.cipherSumLabel.AutoSize = true;
            this.cipherSumLabel.Location = new System.Drawing.Point(329, 109);
            this.cipherSumLabel.MaximumSize = new System.Drawing.Size(200, 40);
            this.cipherSumLabel.Name = "cipherSumLabel";
            this.cipherSumLabel.Size = new System.Drawing.Size(90, 17);
            this.cipherSumLabel.TabIndex = 9;
            this.cipherSumLabel.Text = "Sum of Word";
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Location = new System.Drawing.Point(329, 37);
            this.wordLabel.MaximumSize = new System.Drawing.Size(200, 40);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(42, 17);
            this.wordLabel.TabIndex = 8;
            this.wordLabel.Text = "Word";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(389, 7);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(56, 23);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(451, 7);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(69, 23);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 411);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sumBreakdownLabel);
            this.Controls.Add(this.symbolBreakdownLabel);
            this.Controls.Add(this.cipherSumLabel);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.cipherButtonFlowLayoutPanel);
            this.Controls.Add(this.cipherPickerComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sumBreakdownLabelLabel);
            this.Controls.Add(this.symbolBreakdownLabelLabel);
            this.Controls.Add(this.cipherSumLabelLabel);
            this.Controls.Add(this.wordLabelLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordLabelLabel;
        private System.Windows.Forms.Label cipherSumLabelLabel;
        private System.Windows.Forms.Label symbolBreakdownLabelLabel;
        private System.Windows.Forms.Label sumBreakdownLabelLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cipherPickerComboBox;
        private System.Windows.Forms.FlowLayoutPanel cipherButtonFlowLayoutPanel;
        private System.Windows.Forms.Label sumBreakdownLabel;
        private System.Windows.Forms.Label symbolBreakdownLabel;
        private System.Windows.Forms.Label cipherSumLabel;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

