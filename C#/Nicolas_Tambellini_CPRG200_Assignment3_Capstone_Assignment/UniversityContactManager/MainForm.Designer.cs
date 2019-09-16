namespace UniversityContactManager
{
    partial class MainForm
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
            this.mainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactListBoxMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contactDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstAndLastNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.userTypeLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.contactListBox = new System.Windows.Forms.ListBox();
            this.mainFormMenuStrip.SuspendLayout();
            this.contactListBoxMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormMenuStrip
            // 
            this.mainFormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.mainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainFormMenuStrip.Name = "mainFormMenuStrip";
            this.mainFormMenuStrip.Size = new System.Drawing.Size(919, 28);
            this.mainFormMenuStrip.TabIndex = 1;
            this.mainFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.saveContactsToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveContactsToolStripMenuItem
            // 
            this.saveContactsToolStripMenuItem.Name = "saveContactsToolStripMenuItem";
            this.saveContactsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveContactsToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.saveContactsToolStripMenuItem.Text = "Save Contacts";
            this.saveContactsToolStripMenuItem.Click += new System.EventHandler(this.saveContactsToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(231, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contactListBoxMenuStrip
            // 
            this.contactListBoxMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contactListBoxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactDetailsToolStripMenuItem,
            this.addContactToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.deleteContactToolStripMenuItem,
            this.searchForToolStripMenuItem});
            this.contactListBoxMenuStrip.Name = "contactListBoxMenuStrip";
            this.contactListBoxMenuStrip.Size = new System.Drawing.Size(189, 124);
            // 
            // contactDetailsToolStripMenuItem
            // 
            this.contactDetailsToolStripMenuItem.Name = "contactDetailsToolStripMenuItem";
            this.contactDetailsToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.contactDetailsToolStripMenuItem.Text = "Contact Details...";
            this.contactDetailsToolStripMenuItem.Click += new System.EventHandler(this.contactDetailsToolStripMenuItem_Click);
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facultyToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.addContactToolStripMenuItem.Text = "Add Contact";
            // 
            // facultyToolStripMenuItem
            // 
            this.facultyToolStripMenuItem.Name = "facultyToolStripMenuItem";
            this.facultyToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.facultyToolStripMenuItem.Text = "Faculty";
            this.facultyToolStripMenuItem.Click += new System.EventHandler(this.facultyToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.editContactToolStripMenuItem.Text = "Edit Contact";
            this.editContactToolStripMenuItem.Click += new System.EventHandler(this.editContactToolStripMenuItem_Click);
            // 
            // deleteContactToolStripMenuItem
            // 
            this.deleteContactToolStripMenuItem.Name = "deleteContactToolStripMenuItem";
            this.deleteContactToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.deleteContactToolStripMenuItem.Text = "Delete Contact";
            this.deleteContactToolStripMenuItem.Click += new System.EventHandler(this.deleteContactToolStripMenuItem_Click);
            // 
            // searchForToolStripMenuItem
            // 
            this.searchForToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstNameToolStripMenuItem,
            this.lastNameToolStripMenuItem,
            this.firstAndLastNameToolStripMenuItem});
            this.searchForToolStripMenuItem.Name = "searchForToolStripMenuItem";
            this.searchForToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.searchForToolStripMenuItem.Text = "Search For";
            // 
            // firstNameToolStripMenuItem
            // 
            this.firstNameToolStripMenuItem.Name = "firstNameToolStripMenuItem";
            this.firstNameToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.firstNameToolStripMenuItem.Text = "First Name";
            this.firstNameToolStripMenuItem.Click += new System.EventHandler(this.firstNameToolStripMenuItem_Click);
            // 
            // lastNameToolStripMenuItem
            // 
            this.lastNameToolStripMenuItem.Name = "lastNameToolStripMenuItem";
            this.lastNameToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.lastNameToolStripMenuItem.Text = "Last Name";
            this.lastNameToolStripMenuItem.Click += new System.EventHandler(this.lastNameToolStripMenuItem_Click);
            // 
            // firstAndLastNameToolStripMenuItem
            // 
            this.firstAndLastNameToolStripMenuItem.Name = "firstAndLastNameToolStripMenuItem";
            this.firstAndLastNameToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.firstAndLastNameToolStripMenuItem.Text = "First and Last Name";
            this.firstAndLastNameToolStripMenuItem.Click += new System.EventHandler(this.firstAndLastNameToolStripMenuItem_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(7, 37);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(112, 23);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(232, 37);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(119, 23);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name";
            // 
            // userTypeLabel
            // 
            this.userTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeLabel.Location = new System.Drawing.Point(455, 37);
            this.userTypeLabel.Name = "userTypeLabel";
            this.userTypeLabel.Size = new System.Drawing.Size(83, 23);
            this.userTypeLabel.TabIndex = 5;
            this.userTypeLabel.Text = "Type";
            // 
            // departmentLabel
            // 
            this.departmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLabel.Location = new System.Drawing.Point(625, 37);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(112, 23);
            this.departmentLabel.TabIndex = 6;
            this.departmentLabel.Text = "Department";
            // 
            // contactListBox
            // 
            this.contactListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactListBox.ContextMenuStrip = this.contactListBoxMenuStrip;
            this.contactListBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactListBox.FormattingEnabled = true;
            this.contactListBox.HorizontalScrollbar = true;
            this.contactListBox.ItemHeight = 20;
            this.contactListBox.Location = new System.Drawing.Point(6, 63);
            this.contactListBox.Name = "contactListBox";
            this.contactListBox.ScrollAlwaysVisible = true;
            this.contactListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.contactListBox.Size = new System.Drawing.Size(913, 264);
            this.contactListBox.TabIndex = 2;
            this.contactListBox.DoubleClick += new System.EventHandler(this.contactListBox_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 343);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.userTypeLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.contactListBox);
            this.Controls.Add(this.mainFormMenuStrip);
            this.MainMenuStrip = this.mainFormMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Contact Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mainFormMenuStrip.ResumeLayout(false);
            this.mainFormMenuStrip.PerformLayout();
            this.contactListBoxMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label userTypeLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.ContextMenuStrip contactListBoxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem contactDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchForToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstAndLastNameToolStripMenuItem;
        private System.Windows.Forms.ListBox contactListBox;
    }
}

