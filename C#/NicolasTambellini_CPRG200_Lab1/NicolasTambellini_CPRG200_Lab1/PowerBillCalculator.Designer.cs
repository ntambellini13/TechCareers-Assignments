namespace NicolasTambellini_CPRG200_Lab1
{
    partial class PowerBillForm
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.kWhUsageLabel = new System.Windows.Forms.Label();
            this.kwhUsedText = new System.Windows.Forms.TextBox();
            this.billLabel = new System.Windows.Forms.Label();
            this.billText = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.customerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.customerTypeLabel = new System.Windows.Forms.Label();
            this.offPeakKwhUsedLabel = new System.Windows.Forms.Label();
            this.offPeakKwhUsedText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Green;
            this.calculateButton.FlatAppearance.BorderSize = 0;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.calculateButton.Location = new System.Drawing.Point(28, 199);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(96, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Yellow;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Location = new System.Drawing.Point(130, 199);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(96, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // kWhUsageLabel
            // 
            this.kWhUsageLabel.AutoSize = true;
            this.kWhUsageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kWhUsageLabel.Location = new System.Drawing.Point(25, 88);
            this.kWhUsageLabel.Name = "kWhUsageLabel";
            this.kWhUsageLabel.Size = new System.Drawing.Size(124, 15);
            this.kWhUsageLabel.TabIndex = 2;
            this.kWhUsageLabel.Text = "Overall kWh Used:";
            // 
            // kwhUsedText
            // 
            this.kwhUsedText.Location = new System.Drawing.Point(187, 87);
            this.kwhUsedText.Name = "kwhUsedText";
            this.kwhUsedText.Size = new System.Drawing.Size(143, 20);
            this.kwhUsedText.TabIndex = 2;
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billLabel.Location = new System.Drawing.Point(25, 158);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(84, 15);
            this.billLabel.TabIndex = 4;
            this.billLabel.Text = "Bill Amount:";
            // 
            // billText
            // 
            this.billText.Location = new System.Drawing.Point(187, 157);
            this.billText.Name = "billText";
            this.billText.ReadOnly = true;
            this.billText.Size = new System.Drawing.Size(143, 20);
            this.billText.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Location = new System.Drawing.Point(234, 199);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(96, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // customerTypeComboBox
            // 
            this.customerTypeComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.customerTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTypeComboBox.FormattingEnabled = true;
            this.customerTypeComboBox.Items.AddRange(new object[] {
            "Residential",
            "Commercial",
            "Industrial"});
            this.customerTypeComboBox.Location = new System.Drawing.Point(187, 15);
            this.customerTypeComboBox.Name = "customerTypeComboBox";
            this.customerTypeComboBox.Size = new System.Drawing.Size(143, 21);
            this.customerTypeComboBox.TabIndex = 1;
            this.customerTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.customerTypeComboBox_SelectedIndexChanged);
            // 
            // customerTypeLabel
            // 
            this.customerTypeLabel.AutoSize = true;
            this.customerTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTypeLabel.Location = new System.Drawing.Point(25, 16);
            this.customerTypeLabel.Name = "customerTypeLabel";
            this.customerTypeLabel.Size = new System.Drawing.Size(106, 15);
            this.customerTypeLabel.TabIndex = 8;
            this.customerTypeLabel.Text = "Customer Type:";
            // 
            // offPeakKwhUsedLabel
            // 
            this.offPeakKwhUsedLabel.AutoSize = true;
            this.offPeakKwhUsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offPeakKwhUsedLabel.Location = new System.Drawing.Point(25, 119);
            this.offPeakKwhUsedLabel.Name = "offPeakKwhUsedLabel";
            this.offPeakKwhUsedLabel.Size = new System.Drawing.Size(134, 15);
            this.offPeakKwhUsedLabel.TabIndex = 9;
            this.offPeakKwhUsedLabel.Text = "Off-Peak kWh Used:";
            // 
            // offPeakKwhUsedText
            // 
            this.offPeakKwhUsedText.Location = new System.Drawing.Point(187, 118);
            this.offPeakKwhUsedText.Name = "offPeakKwhUsedText";
            this.offPeakKwhUsedText.Size = new System.Drawing.Size(143, 20);
            this.offPeakKwhUsedText.TabIndex = 3;
            // 
            // PowerBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(365, 239);
            this.Controls.Add(this.offPeakKwhUsedText);
            this.Controls.Add(this.offPeakKwhUsedLabel);
            this.Controls.Add(this.customerTypeLabel);
            this.Controls.Add(this.customerTypeComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.billText);
            this.Controls.Add(this.billLabel);
            this.Controls.Add(this.kwhUsedText);
            this.Controls.Add(this.kWhUsageLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "PowerBillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Bill Calculator";
            this.Load += new System.EventHandler(this.PowerBillForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label kWhUsageLabel;
        private System.Windows.Forms.TextBox kwhUsedText;
        private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.TextBox billText;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox customerTypeComboBox;
        private System.Windows.Forms.Label customerTypeLabel;
        private System.Windows.Forms.Label offPeakKwhUsedLabel;
        private System.Windows.Forms.TextBox offPeakKwhUsedText;
    }
}

