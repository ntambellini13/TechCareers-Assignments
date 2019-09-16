using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityUsers;

namespace UniversityContactManager
{
    public partial class AddEditFacultyForm : Form
    {
        public Faculty NewFacultyMember; // new faculty member object

        private Faculty editFaculty = null; // Stores edit faculty value
        private bool editMode = false; // determines whether form is in edit mode or not

        /// <summary>
        /// Creates from
        /// </summary>
        public AddEditFacultyForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Changes form title to add faculty
        /// </summary>
        private void AddEditFacultyForm_Load(object sender, EventArgs e)
        {
            this.Text = "Add Faculty Member";
            facultyFirstNameTextBox.Focus();
        }

        /// <summary>
        /// Sets DailaogResult as cancel
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Creates or edits a faculty member
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            // creates a new faculty member
            if (!editMode && isValidEntries())
            {
                try
                {
                    NewFacultyMember = new Faculty(
                    facultyFirstNameTextBox.Text.Trim(),
                    facultyLastNameTextBox.Text.Trim(),
                    facultyAcademicDepartmentTextBox.Text.Trim(),
                    new FacultyContactInformation(facultyEmailAddressTextBox.Text.Trim(), officeBuildingLocationTextBox.Text.Trim())
                    );

                    DialogResult = DialogResult.OK;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Could not create a new faculty member\n" + Ex.Message, "Error Adding New Faculty Member", MessageBoxButtons.OK);
                }
            }
            // check if existing faculty member inputs are changed and if so change those values
            else if (editMode && isValidEntries())
            {
                try
                {
                    if (editFaculty.FirstName != facultyFirstNameTextBox.Text.Trim())
                    {
                        editFaculty.FirstName = facultyFirstNameTextBox.Text.Trim();
                    }
                    if (editFaculty.LastName != facultyLastNameTextBox.Text.Trim())
                    {
                        editFaculty.LastName = facultyLastNameTextBox.Text.Trim();
                    }
                    if (editFaculty.AcademicDepartment != facultyAcademicDepartmentTextBox.Text.Trim())
                    {
                        editFaculty.AcademicDepartment = facultyAcademicDepartmentTextBox.Text.Trim();
                    }
                    if (editFaculty.ContactInformation.EmailAddress != facultyEmailAddressTextBox.Text.Trim())
                    {
                        editFaculty.ContactInformation.EmailAddress = facultyEmailAddressTextBox.Text.Trim();
                    }
                    if (editFaculty.ContactInformation.BuildingLocation != officeBuildingLocationTextBox.Text.Trim())
                    {
                        editFaculty.ContactInformation.BuildingLocation = officeBuildingLocationTextBox.Text.Trim();
                    }
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not edit the faculty member information\n" + ex.Message, "Error Editing Faculty Member", MessageBoxButtons.OK);
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

        /// <summary>
        ///  Populates form with the information from the faculty member that was selected so it can be edited
        /// </summary>
        /// <param name="editFaculty"> faculty member selected that is being edited </param>
        public AddEditFacultyForm(Faculty editFaculty) : this()
        {
            if (editFaculty == null)
            {
                throw new ArgumentNullException("Must supply a faculty member");
            }


            editMode = true; // changes to edit mode
            this.editFaculty = editFaculty; // faculty member selected in the contactListBox is the one being edited
            this.Text = "Edit Faculty Member"; // changes form title
            addButton.Text = "Save"; // Add button becomes save button

            // Populates all fields on form with faculty member being edited's current inputs
            facultyFirstNameTextBox.Text = editFaculty.FirstName;
            facultyLastNameTextBox.Text = editFaculty.LastName;
            facultyAcademicDepartmentTextBox.Text = editFaculty.AcademicDepartment;
            facultyEmailAddressTextBox.Text = editFaculty.ContactInformation.EmailAddress;
            officeBuildingLocationTextBox.Text = editFaculty.ContactInformation.BuildingLocation;
        }

        /// <summary>
        /// Checks if input is valid for a given textbox
        /// </summary>
        /// <returns> Bool value and error message if the input is not valid </returns>
        private bool isValidEntries()
        {
            if (!Validation.isValidString(facultyFirstNameTextBox))
            {
                MessageBox.Show("You need to enter a first name in the input field with only letters", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }
            if (!Validation.isValidString(facultyLastNameTextBox))
            {
                MessageBox.Show("You need to enter a last name in the input field with only letters", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }
            if (!Validation.isValidString(facultyAcademicDepartmentTextBox))
            {
                MessageBox.Show("You need to enter an academic department name in the input field with only letters", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }
            if (!Validation.isValidEmail(facultyEmailAddressTextBox))
            {
                MessageBox.Show("You need to enter a valid email in the input field", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }
            if (!Validation.isValidEmail(facultyEmailAddressTextBox))
            {
                MessageBox.Show("You need to enter a valid email in the input field", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }
            if (!Validation.isNotNullOrEmpty(officeBuildingLocationTextBox))
            {
                MessageBox.Show("You need to enter an office location in the input field", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
    }
}
