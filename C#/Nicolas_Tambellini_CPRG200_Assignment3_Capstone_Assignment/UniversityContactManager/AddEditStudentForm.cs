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
    public partial class AddEditStudentForm : Form
    {
        public Student NewStudentMember; // new student object
        List<string> Courses = new List<string>(); // creates list of students courses

        private Student editStudent = null; // Stores edit student value
        private bool editMode = false; // Lets form know we are in edit mode

        /// <summary>
        /// Creates from
        /// </summary>
        public AddEditStudentForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Changes form title to add faculty
        /// </summary>
        private void AddEditStudentForm_Load(object sender, EventArgs e)
        {
            this.Text = "Add Student";
            studentFirstNameTextBox.Focus();
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
            // creates a new student
            if (!editMode && isValidEntries())
            {
                try
                {
                    NewStudentMember = new Student(
                    studentFirstNameTextBox.Text.Trim(),
                    studentLastNameTextBox.Text.Trim(),
                    studentAcademicDepartmentTextBox.Text.Trim(),
                    new StudentContactInformation(studentEmailAddressTextBox.Text.Trim(), mailingAddressTextBox.Text.Trim()),
                    int.Parse(graduationYearTextBox.Text.Trim()),
                    Courses);

                    DialogResult = DialogResult.OK;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Could not create a new student\n" + Ex.Message, "Error Adding New Student", MessageBoxButtons.OK);
                }
            }
            // check if existing student inputs are changed and if so change those values
            else if (editMode && isValidEntries())
            {
                try
                {
                    int year;
                    if (editStudent.FirstName != studentFirstNameTextBox.Text.Trim())
                    {
                        editStudent.FirstName = studentFirstNameTextBox.Text.Trim();
                    }
                    if (editStudent.LastName != studentLastNameTextBox.Text.Trim())
                    {
                        editStudent.LastName = studentLastNameTextBox.Text.Trim();
                    }
                    if (editStudent.AcademicDepartment != studentAcademicDepartmentTextBox.Text.Trim())
                    {
                        editStudent.AcademicDepartment = studentAcademicDepartmentTextBox.Text.Trim();
                    }
                    if (editStudent.ContactInformation.EmailAddress != studentEmailAddressTextBox.Text.Trim())
                    {
                        editStudent.ContactInformation.EmailAddress = studentEmailAddressTextBox.Text.Trim();
                    }
                    if (editStudent.ContactInformation.MailingAddress != mailingAddressTextBox.Text.Trim())
                    {
                        editStudent.ContactInformation.MailingAddress = mailingAddressTextBox.Text.Trim();
                    }
                    if (int.TryParse(graduationYearTextBox.Text.Trim(), out year) && editStudent.ExpectedGraduationYear != year)
                    {
                        editStudent.ExpectedGraduationYear = year;
                    }
                    editStudent.CourseList = Courses; // make new Course list for student
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not edit the student information\n" + ex.Message, "Error Editing Student", MessageBoxButtons.OK);
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

        /// <summary>
        /// Add course to a students Course list
        /// </summary>
        private void addCourseButton_Click(object sender, EventArgs e)
        {
            string newCourse = addCourseTextBox.Text.Trim(); // course to be added
            if (!Validation.isNotNullOrEmpty(addCourseTextBox))
            {
                MessageBox.Show("You need enter a course in the input field", "Invalid Input", MessageBoxButtons.OK);
                return;
            }
            courseListListBox.Items.Add(newCourse); // add course to courseListBox
            Courses.Add(newCourse); // add course to students Courses list
            addCourseTextBox.Text = ""; // Add Course: textbox to empty
        }

        /// <summary>
        /// Delete selected course from a students Course list
        /// </summary>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (courseListListBox.SelectedIndex == -1)
            {
                MessageBox.Show("No course has been selected", "No Course Selected", MessageBoxButtons.OK);
            }
            else
            {
                Courses.RemoveAt(courseListListBox.SelectedIndex); // remove course from courseListBox
                courseListListBox.Items.RemoveAt(courseListListBox.SelectedIndex); // remove course from students Course list
            } 
        }

        /// <summary>
        ///  Populates form with the information from the student that was selected so it can be edited
        /// </summary>
        /// <param name="editFaculty"> student selected that is being edited </param>
        public AddEditStudentForm(Student editStudent) : this()
        {
            if (editStudent == null)
            {
                throw new ArgumentNullException("Must supply a student");
            }

            editMode = true; // Sets edit mode for student
            this.editStudent = editStudent; // student selected in the contactListBox is the one being edited
            Courses = editStudent.CourseList; // Course list for student being edited
            this.Text = "Edit Student"; // changes form title
            addButton.Text = "Save"; // Add button becomes save button

            // Populates all fields on form with student being edited's current inputs
            for (int i = 0; i < this.Courses.Count; i++)
            {
                courseListListBox.Items.Add(this.Courses[i]);
            }
            studentFirstNameTextBox.Text = editStudent.FirstName;
            studentLastNameTextBox.Text = editStudent.LastName;
            studentAcademicDepartmentTextBox.Text = editStudent.AcademicDepartment;
            studentEmailAddressTextBox.Text = editStudent.ContactInformation.EmailAddress;
            mailingAddressTextBox.Text = editStudent.ContactInformation.MailingAddress;
            graduationYearTextBox.Text = editStudent.ExpectedGraduationYear.ToString();
        }

        /// <summary>
        /// Checks if input is valid for a given textbox
        /// </summary>
        /// <returns> Bool value and error message if the input is not valid </returns>
        private bool isValidEntries()
        {
            if (!Validation.isValidString(studentFirstNameTextBox))
            {
                MessageBox.Show("You need to enter a first name in the input field with only letters.", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }
            if (!Validation.isValidString(studentLastNameTextBox))
            {
                MessageBox.Show("You need to enter a last name in the input field with only letters.", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }
            if (!Validation.isValidString(studentAcademicDepartmentTextBox))
            {
                MessageBox.Show("You need to enter an academic department name in the input field with only letters.", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }
            if (!Validation.isValidEmail(studentEmailAddressTextBox))
            {
                MessageBox.Show("You need to enter a valid email in the input field.", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }
            if (!Validation.isNotNullOrEmpty(mailingAddressTextBox))
            {
                MessageBox.Show("You need to enter a mailing address in the input field.", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }
            if (!Validation.isNotBeforeCurrentYear(graduationYearTextBox))
            {
                MessageBox.Show("You need to enter a graduation year that is an integer value greater or equal to the current year.", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
    }
}
