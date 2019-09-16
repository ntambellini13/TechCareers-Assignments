namespace NicolasTambellini_CPRG200_Lab2
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
            this.kwhUsedTextBox = new System.Windows.Forms.TextBox();
            this.billLabel = new System.Windows.Forms.Label();
            this.billTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.customerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.customerTypeLabel = new System.Windows.Forms.Label();
            this.offPeakKwhUsedLabel = new System.Windows.Forms.Label();
            this.offPeakKwhUsedTextBox = new System.Windows.Forms.TextBox();
            this.customerDataListBox = new System.Windows.Forms.ListBox();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.customerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.customerInfoLabel = new System.Windows.Forms.Label();
            this.totalResidentialChargesLabel = new System.Windows.Forms.Label();
            this.totalCommercialChargesLabel = new System.Windows.Forms.Label();
            this.totalIndustrialChargesLabel = new System.Windows.Forms.Label();
            this.totalResidentialChargesTextBox = new System.Windows.Forms.TextBox();
            this.totalCommercialChargesTextBox = new System.Windows.Forms.TextBox();
            this.totalChargesLabel = new System.Windows.Forms.Label();
            this.totalIndustrialChargesTextBox = new System.Windows.Forms.TextBox();
            this.totalChargesTextBox = new System.Windows.Forms.TextBox();
            this.numberOfCustomersLabel = new System.Windows.Forms.Label();
            this.totalCustomersTextBox = new System.Windows.Forms.TextBox();
            this.customerDataHeaderLabel = new System.Windows.Forms.Label();
            this.customerInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Green;
            this.calculateButton.FlatAppearance.BorderSize = 0;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.calculateButton.Location = new System.Drawing.Point(179, 254);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(143, 23);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Yellow;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.Black;
            this.clearButton.Location = new System.Drawing.Point(9, 291);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(143, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // kWhUsageLabel
            // 
            this.kWhUsageLabel.AutoSize = true;
            this.kWhUsageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kWhUsageLabel.Location = new System.Drawing.Point(6, 165);
            this.kWhUsageLabel.Name = "kWhUsageLabel";
            this.kWhUsageLabel.Size = new System.Drawing.Size(124, 15);
            this.kWhUsageLabel.TabIndex = 2;
            this.kWhUsageLabel.Text = "Overall kWh Used:";
            // 
            // kwhUsedTextBox
            // 
            this.kwhUsedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kwhUsedTextBox.Location = new System.Drawing.Point(179, 162);
            this.kwhUsedTextBox.Name = "kwhUsedTextBox";
            this.kwhUsedTextBox.Size = new System.Drawing.Size(143, 22);
            this.kwhUsedTextBox.TabIndex = 4;
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billLabel.Location = new System.Drawing.Point(6, 219);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(84, 15);
            this.billLabel.TabIndex = 4;
            this.billLabel.Text = "Bill Amount:";
            // 
            // billTextBox
            // 
            this.billTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billTextBox.Location = new System.Drawing.Point(179, 216);
            this.billTextBox.Name = "billTextBox";
            this.billTextBox.ReadOnly = true;
            this.billTextBox.Size = new System.Drawing.Size(143, 22);
            this.billTextBox.TabIndex = 9;
            this.billTextBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(179, 291);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(143, 23);
            this.exitButton.TabIndex = 9;
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
            this.customerTypeComboBox.Location = new System.Drawing.Point(179, 84);
            this.customerTypeComboBox.Name = "customerTypeComboBox";
            this.customerTypeComboBox.Size = new System.Drawing.Size(143, 21);
            this.customerTypeComboBox.TabIndex = 3;
            this.customerTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.customerTypeComboBox_SelectedIndexChanged);
            // 
            // customerTypeLabel
            // 
            this.customerTypeLabel.AutoSize = true;
            this.customerTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTypeLabel.Location = new System.Drawing.Point(6, 80);
            this.customerTypeLabel.Name = "customerTypeLabel";
            this.customerTypeLabel.Size = new System.Drawing.Size(106, 15);
            this.customerTypeLabel.TabIndex = 8;
            this.customerTypeLabel.Text = "Customer Type:";
            // 
            // offPeakKwhUsedLabel
            // 
            this.offPeakKwhUsedLabel.AutoSize = true;
            this.offPeakKwhUsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offPeakKwhUsedLabel.Location = new System.Drawing.Point(6, 193);
            this.offPeakKwhUsedLabel.Name = "offPeakKwhUsedLabel";
            this.offPeakKwhUsedLabel.Size = new System.Drawing.Size(134, 15);
            this.offPeakKwhUsedLabel.TabIndex = 9;
            this.offPeakKwhUsedLabel.Text = "Off-Peak kWh Used:";
            // 
            // offPeakKwhUsedTextBox
            // 
            this.offPeakKwhUsedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offPeakKwhUsedTextBox.Location = new System.Drawing.Point(179, 190);
            this.offPeakKwhUsedTextBox.Name = "offPeakKwhUsedTextBox";
            this.offPeakKwhUsedTextBox.Size = new System.Drawing.Size(143, 22);
            this.offPeakKwhUsedTextBox.TabIndex = 5;
            // 
            // customerDataListBox
            // 
            this.customerDataListBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDataListBox.FormattingEnabled = true;
            this.customerDataListBox.ItemHeight = 14;
            this.customerDataListBox.Location = new System.Drawing.Point(366, 84);
            this.customerDataListBox.Name = "customerDataListBox";
            this.customerDataListBox.Size = new System.Drawing.Size(391, 102);
            this.customerDataListBox.TabIndex = 10;
            this.customerDataListBox.TabStop = false;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.BackColor = System.Drawing.Color.DarkOrange;
            this.addCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerButton.ForeColor = System.Drawing.Color.White;
            this.addCustomerButton.Location = new System.Drawing.Point(9, 254);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(143, 23);
            this.addCustomerButton.TabIndex = 6;
            this.addCustomerButton.Text = "Add Customer\r\n";
            this.addCustomerButton.UseVisualStyleBackColor = false;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // customerInfoGroupBox
            // 
            this.customerInfoGroupBox.Controls.Add(this.customerNameLabel);
            this.customerInfoGroupBox.Controls.Add(this.customerNameTextBox);
            this.customerInfoGroupBox.Controls.Add(this.offPeakKwhUsedTextBox);
            this.customerInfoGroupBox.Controls.Add(this.accountNumberTextBox);
            this.customerInfoGroupBox.Controls.Add(this.kwhUsedTextBox);
            this.customerInfoGroupBox.Controls.Add(this.offPeakKwhUsedLabel);
            this.customerInfoGroupBox.Controls.Add(this.kWhUsageLabel);
            this.customerInfoGroupBox.Controls.Add(this.accountNumberLabel);
            this.customerInfoGroupBox.Controls.Add(this.billTextBox);
            this.customerInfoGroupBox.Controls.Add(this.customerTypeLabel);
            this.customerInfoGroupBox.Controls.Add(this.billLabel);
            this.customerInfoGroupBox.Controls.Add(this.customerTypeComboBox);
            this.customerInfoGroupBox.Controls.Add(this.calculateButton);
            this.customerInfoGroupBox.Controls.Add(this.exitButton);
            this.customerInfoGroupBox.Controls.Add(this.addCustomerButton);
            this.customerInfoGroupBox.Controls.Add(this.clearButton);
            this.customerInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInfoGroupBox.Location = new System.Drawing.Point(28, 28);
            this.customerInfoGroupBox.Name = "customerInfoGroupBox";
            this.customerInfoGroupBox.Size = new System.Drawing.Size(332, 327);
            this.customerInfoGroupBox.TabIndex = 12;
            this.customerInfoGroupBox.TabStop = false;
            this.customerInfoGroupBox.Text = "Customer";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(6, 56);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(114, 15);
            this.customerNameLabel.TabIndex = 15;
            this.customerNameLabel.Text = "Customer Name:";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(179, 56);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(143, 22);
            this.customerNameTextBox.TabIndex = 2;
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberTextBox.Location = new System.Drawing.Point(179, 28);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(143, 22);
            this.accountNumberTextBox.TabIndex = 1;
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberLabel.Location = new System.Drawing.Point(6, 31);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(116, 15);
            this.accountNumberLabel.TabIndex = 10;
            this.accountNumberLabel.Text = "Account Number:";
            // 
            // customerInfoLabel
            // 
            this.customerInfoLabel.AutoSize = true;
            this.customerInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInfoLabel.Location = new System.Drawing.Point(446, 28);
            this.customerInfoLabel.Name = "customerInfoLabel";
            this.customerInfoLabel.Size = new System.Drawing.Size(128, 20);
            this.customerInfoLabel.TabIndex = 13;
            this.customerInfoLabel.Text = "Customer Info:";
            // 
            // totalResidentialChargesLabel
            // 
            this.totalResidentialChargesLabel.AutoSize = true;
            this.totalResidentialChargesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalResidentialChargesLabel.Location = new System.Drawing.Point(363, 195);
            this.totalResidentialChargesLabel.Name = "totalResidentialChargesLabel";
            this.totalResidentialChargesLabel.Size = new System.Drawing.Size(190, 15);
            this.totalResidentialChargesLabel.TabIndex = 14;
            this.totalResidentialChargesLabel.Text = "Sum of Residential Charges:";
            // 
            // totalCommercialChargesLabel
            // 
            this.totalCommercialChargesLabel.AutoSize = true;
            this.totalCommercialChargesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCommercialChargesLabel.Location = new System.Drawing.Point(363, 223);
            this.totalCommercialChargesLabel.Name = "totalCommercialChargesLabel";
            this.totalCommercialChargesLabel.Size = new System.Drawing.Size(194, 15);
            this.totalCommercialChargesLabel.TabIndex = 15;
            this.totalCommercialChargesLabel.Text = "Sum of Commercial Charges:";
            // 
            // totalIndustrialChargesLabel
            // 
            this.totalIndustrialChargesLabel.AutoSize = true;
            this.totalIndustrialChargesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalIndustrialChargesLabel.Location = new System.Drawing.Point(363, 249);
            this.totalIndustrialChargesLabel.Name = "totalIndustrialChargesLabel";
            this.totalIndustrialChargesLabel.Size = new System.Drawing.Size(177, 15);
            this.totalIndustrialChargesLabel.TabIndex = 16;
            this.totalIndustrialChargesLabel.Text = "Sum of Industrial Charges:";
            // 
            // totalResidentialChargesTextBox
            // 
            this.totalResidentialChargesTextBox.Location = new System.Drawing.Point(614, 194);
            this.totalResidentialChargesTextBox.Name = "totalResidentialChargesTextBox";
            this.totalResidentialChargesTextBox.ReadOnly = true;
            this.totalResidentialChargesTextBox.Size = new System.Drawing.Size(143, 20);
            this.totalResidentialChargesTextBox.TabIndex = 10;
            this.totalResidentialChargesTextBox.TabStop = false;
            // 
            // totalCommercialChargesTextBox
            // 
            this.totalCommercialChargesTextBox.Location = new System.Drawing.Point(614, 220);
            this.totalCommercialChargesTextBox.Name = "totalCommercialChargesTextBox";
            this.totalCommercialChargesTextBox.ReadOnly = true;
            this.totalCommercialChargesTextBox.Size = new System.Drawing.Size(143, 20);
            this.totalCommercialChargesTextBox.TabIndex = 11;
            this.totalCommercialChargesTextBox.TabStop = false;
            // 
            // totalChargesLabel
            // 
            this.totalChargesLabel.AutoSize = true;
            this.totalChargesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalChargesLabel.Location = new System.Drawing.Point(363, 287);
            this.totalChargesLabel.Name = "totalChargesLabel";
            this.totalChargesLabel.Size = new System.Drawing.Size(133, 15);
            this.totalChargesLabel.TabIndex = 19;
            this.totalChargesLabel.Text = "Sum of all Charges:\r\n";
            // 
            // totalIndustrialChargesTextBox
            // 
            this.totalIndustrialChargesTextBox.Location = new System.Drawing.Point(614, 246);
            this.totalIndustrialChargesTextBox.Name = "totalIndustrialChargesTextBox";
            this.totalIndustrialChargesTextBox.ReadOnly = true;
            this.totalIndustrialChargesTextBox.Size = new System.Drawing.Size(143, 20);
            this.totalIndustrialChargesTextBox.TabIndex = 12;
            this.totalIndustrialChargesTextBox.TabStop = false;
            // 
            // totalChargesTextBox
            // 
            this.totalChargesTextBox.Location = new System.Drawing.Point(614, 284);
            this.totalChargesTextBox.Name = "totalChargesTextBox";
            this.totalChargesTextBox.ReadOnly = true;
            this.totalChargesTextBox.Size = new System.Drawing.Size(143, 20);
            this.totalChargesTextBox.TabIndex = 13;
            this.totalChargesTextBox.TabStop = false;
            // 
            // numberOfCustomersLabel
            // 
            this.numberOfCustomersLabel.AutoSize = true;
            this.numberOfCustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfCustomersLabel.Location = new System.Drawing.Point(363, 324);
            this.numberOfCustomersLabel.Name = "numberOfCustomersLabel";
            this.numberOfCustomersLabel.Size = new System.Drawing.Size(186, 15);
            this.numberOfCustomersLabel.TabIndex = 22;
            this.numberOfCustomersLabel.Text = "Total Number of Customers:";
            // 
            // totalCustomersTextBox
            // 
            this.totalCustomersTextBox.Location = new System.Drawing.Point(614, 321);
            this.totalCustomersTextBox.Name = "totalCustomersTextBox";
            this.totalCustomersTextBox.ReadOnly = true;
            this.totalCustomersTextBox.Size = new System.Drawing.Size(143, 20);
            this.totalCustomersTextBox.TabIndex = 14;
            this.totalCustomersTextBox.TabStop = false;
            // 
            // customerDataHeaderLabel
            // 
            this.customerDataHeaderLabel.AutoSize = true;
            this.customerDataHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDataHeaderLabel.Location = new System.Drawing.Point(366, 59);
            this.customerDataHeaderLabel.Name = "customerDataHeaderLabel";
            this.customerDataHeaderLabel.Size = new System.Drawing.Size(347, 15);
            this.customerDataHeaderLabel.TabIndex = 23;
            this.customerDataHeaderLabel.Text = "Account#   Customer Name          Type     Bill Amount ";
            // 
            // PowerBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(787, 385);
            this.Controls.Add(this.customerDataHeaderLabel);
            this.Controls.Add(this.totalCustomersTextBox);
            this.Controls.Add(this.numberOfCustomersLabel);
            this.Controls.Add(this.totalChargesTextBox);
            this.Controls.Add(this.totalIndustrialChargesTextBox);
            this.Controls.Add(this.totalChargesLabel);
            this.Controls.Add(this.totalCommercialChargesTextBox);
            this.Controls.Add(this.totalResidentialChargesTextBox);
            this.Controls.Add(this.totalIndustrialChargesLabel);
            this.Controls.Add(this.totalCommercialChargesLabel);
            this.Controls.Add(this.totalResidentialChargesLabel);
            this.Controls.Add(this.customerInfoLabel);
            this.Controls.Add(this.customerInfoGroupBox);
            this.Controls.Add(this.customerDataListBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "PowerBillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Bill Calculator";
            this.Load += new System.EventHandler(this.PowerBillForm_Load);
            this.customerInfoGroupBox.ResumeLayout(false);
            this.customerInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label kWhUsageLabel;
        private System.Windows.Forms.TextBox kwhUsedTextBox;
        private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.TextBox billTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox customerTypeComboBox;
        private System.Windows.Forms.Label customerTypeLabel;
        private System.Windows.Forms.Label offPeakKwhUsedLabel;
        private System.Windows.Forms.TextBox offPeakKwhUsedTextBox;
        private System.Windows.Forms.ListBox customerDataListBox;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.GroupBox customerInfoGroupBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.Label customerInfoLabel;
        private System.Windows.Forms.Label totalResidentialChargesLabel;
        private System.Windows.Forms.Label totalCommercialChargesLabel;
        private System.Windows.Forms.Label totalIndustrialChargesLabel;
        private System.Windows.Forms.TextBox totalResidentialChargesTextBox;
        private System.Windows.Forms.TextBox totalCommercialChargesTextBox;
        private System.Windows.Forms.Label totalChargesLabel;
        private System.Windows.Forms.TextBox totalIndustrialChargesTextBox;
        private System.Windows.Forms.TextBox totalChargesTextBox;
        private System.Windows.Forms.Label numberOfCustomersLabel;
        private System.Windows.Forms.TextBox totalCustomersTextBox;
        private System.Windows.Forms.Label customerDataHeaderLabel;
    }
}

