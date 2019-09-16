namespace UniversityContactManager
{
    partial class AddEditFacultyForm
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
            this.facultyFirstNameLabel = new System.Windows.Forms.Label();
            this.facultyLastNameLabel = new System.Windows.Forms.Label();
            this.facultyAcademicDepartmentLabel = new System.Windows.Forms.Label();
            this.studentContactInformationLabel = new System.Windows.Forms.Label();
            this.facultyEmailAddressLabel = new System.Windows.Forms.Label();
            this.officeBuildingLocationLabel = new System.Windows.Forms.Label();
            this.facultyFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.facultyLastNameTextBox = new System.Windows.Forms.TextBox();
            this.facultyAcademicDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.facultyEmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.officeBuildingLocationTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // facultyFirstNameLabel
            // 
            this.facultyFirstNameLabel.AutoSize = true;
            this.facultyFirstNameLabel.Location = new System.Drawing.Point(118, 44);
            this.facultyFirstNameLabel.Name = "facultyFirstNameLabel";
            this.facultyFirstNameLabel.Size = new System.Drawing.Size(80, 17);
            this.facultyFirstNameLabel.TabIndex = 0;
            this.facultyFirstNameLabel.Text = "First Name:";
            // 
            // facultyLastNameLabel
            // 
            this.facultyLastNameLabel.AutoSize = true;
            this.facultyLastNameLabel.Location = new System.Drawing.Point(118, 72);
            this.facultyLastNameLabel.Name = "facultyLastNameLabel";
            this.facultyLastNameLabel.Size = new System.Drawing.Size(80, 17);
            this.facultyLastNameLabel.TabIndex = 1;
            this.facultyLastNameLabel.Text = "Last Name:";
            // 
            // facultyAcademicDepartmentLabel
            // 
            this.facultyAcademicDepartmentLabel.AutoSize = true;
            this.facultyAcademicDepartmentLabel.Location = new System.Drawing.Point(47, 98);
            this.facultyAcademicDepartmentLabel.Name = "facultyAcademicDepartmentLabel";
            this.facultyAcademicDepartmentLabel.Size = new System.Drawing.Size(151, 17);
            this.facultyAcademicDepartmentLabel.TabIndex = 2;
            this.facultyAcademicDepartmentLabel.Text = "Academic Department:";
            // 
            // studentContactInformationLabel
            // 
            this.studentContactInformationLabel.AutoSize = true;
            this.studentContactInformationLabel.Location = new System.Drawing.Point(64, 127);
            this.studentContactInformationLabel.Name = "studentContactInformationLabel";
            this.studentContactInformationLabel.Size = new System.Drawing.Size(134, 17);
            this.studentContactInformationLabel.TabIndex = 3;
            this.studentContactInformationLabel.Text = "Contact Information:";
            // 
            // facultyEmailAddressLabel
            // 
            this.facultyEmailAddressLabel.AutoSize = true;
            this.facultyEmailAddressLabel.Location = new System.Drawing.Point(96, 154);
            this.facultyEmailAddressLabel.Name = "facultyEmailAddressLabel";
            this.facultyEmailAddressLabel.Size = new System.Drawing.Size(102, 17);
            this.facultyEmailAddressLabel.TabIndex = 4;
            this.facultyEmailAddressLabel.Text = "Email Address:";
            // 
            // officeBuildingLocationLabel
            // 
            this.officeBuildingLocationLabel.AutoSize = true;
            this.officeBuildingLocationLabel.Location = new System.Drawing.Point(37, 180);
            this.officeBuildingLocationLabel.Name = "officeBuildingLocationLabel";
            this.officeBuildingLocationLabel.Size = new System.Drawing.Size(161, 17);
            this.officeBuildingLocationLabel.TabIndex = 6;
            this.officeBuildingLocationLabel.Text = "Office Building Location:";
            // 
            // facultyFirstNameTextBox
            // 
            this.facultyFirstNameTextBox.Location = new System.Drawing.Point(220, 41);
            this.facultyFirstNameTextBox.Name = "facultyFirstNameTextBox";
            this.facultyFirstNameTextBox.Size = new System.Drawing.Size(399, 22);
            this.facultyFirstNameTextBox.TabIndex = 1;
            // 
            // facultyLastNameTextBox
            // 
            this.facultyLastNameTextBox.Location = new System.Drawing.Point(220, 69);
            this.facultyLastNameTextBox.Name = "facultyLastNameTextBox";
            this.facultyLastNameTextBox.Size = new System.Drawing.Size(399, 22);
            this.facultyLastNameTextBox.TabIndex = 2;
            // 
            // facultyAcademicDepartmentTextBox
            // 
            this.facultyAcademicDepartmentTextBox.Location = new System.Drawing.Point(220, 95);
            this.facultyAcademicDepartmentTextBox.Name = "facultyAcademicDepartmentTextBox";
            this.facultyAcademicDepartmentTextBox.Size = new System.Drawing.Size(399, 22);
            this.facultyAcademicDepartmentTextBox.TabIndex = 3;
            // 
            // facultyEmailAddressTextBox
            // 
            this.facultyEmailAddressTextBox.Location = new System.Drawing.Point(220, 151);
            this.facultyEmailAddressTextBox.Name = "facultyEmailAddressTextBox";
            this.facultyEmailAddressTextBox.Size = new System.Drawing.Size(399, 22);
            this.facultyEmailAddressTextBox.TabIndex = 4;
            // 
            // officeBuildingLocationTextBox
            // 
            this.officeBuildingLocationTextBox.Location = new System.Drawing.Point(220, 177);
            this.officeBuildingLocationTextBox.Name = "officeBuildingLocationTextBox";
            this.officeBuildingLocationTextBox.Size = new System.Drawing.Size(399, 22);
            this.officeBuildingLocationTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(463, 224);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(544, 224);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddEditFacultyForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(653, 272);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.officeBuildingLocationTextBox);
            this.Controls.Add(this.facultyEmailAddressTextBox);
            this.Controls.Add(this.facultyAcademicDepartmentTextBox);
            this.Controls.Add(this.facultyLastNameTextBox);
            this.Controls.Add(this.facultyFirstNameTextBox);
            this.Controls.Add(this.officeBuildingLocationLabel);
            this.Controls.Add(this.facultyEmailAddressLabel);
            this.Controls.Add(this.studentContactInformationLabel);
            this.Controls.Add(this.facultyAcademicDepartmentLabel);
            this.Controls.Add(this.facultyLastNameLabel);
            this.Controls.Add(this.facultyFirstNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddEditFacultyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditStudentForm";
            this.Load += new System.EventHandler(this.AddEditFacultyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label facultyFirstNameLabel;
        private System.Windows.Forms.Label facultyLastNameLabel;
        private System.Windows.Forms.Label facultyAcademicDepartmentLabel;
        private System.Windows.Forms.Label studentContactInformationLabel;
        private System.Windows.Forms.Label facultyEmailAddressLabel;
        private System.Windows.Forms.Label officeBuildingLocationLabel;
        private System.Windows.Forms.TextBox facultyFirstNameTextBox;
        private System.Windows.Forms.TextBox facultyLastNameTextBox;
        private System.Windows.Forms.TextBox facultyAcademicDepartmentTextBox;
        private System.Windows.Forms.TextBox facultyEmailAddressTextBox;
        private System.Windows.Forms.TextBox officeBuildingLocationTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}