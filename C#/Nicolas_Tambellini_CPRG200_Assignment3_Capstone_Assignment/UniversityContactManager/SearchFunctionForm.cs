using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityContactManager
{
    public partial class SearchFunctionForm : Form
    {
        /// <summary>
        /// Creates form
        /// </summary>
        public SearchFunctionForm()
        {
            InitializeComponent();
        }

        private void SearchFunctionForm_Load(object sender, EventArgs e)
        {
            firstNameTextBox.Focus();
        }

        public enum FormModes { FirstName, LastName, FullName }; // sets fields to be displayed
        public FormModes SelectedMode; // sets what textbox searchValue will be pulled from
        public string SearchValue; // string to search for a match with
        
        /// <summary>
        /// Re-titles form name and the labels and textboxes visible based on the search parameters being used
        /// </summary>
        /// <param name="searchMode" >what you are searching for a match against (first name, last name or first and last name) </param>
        public SearchFunctionForm(FormModes searchMode) : this()
        {
            SelectedMode = searchMode;
            switch (searchMode)
            {
                case FormModes.FirstName:
                    {
                        lastNameLabel.Visible = false;
                        lastNameTextBox.Visible = false;
                        this.Text = "Search by First Name";
                        break;
                    }

                case FormModes.LastName:
                    {
                        firstNameLabel.Visible = false;
                        firstNameTextBox.Visible = false;
                        this.Text = "Search by Last Name";
                        break;
                    }

                case FormModes.FullName:
                    {
                        this.Text = "Search by First and Last Name";
                        break;
                    }

                default:
                    {
                        throw new ArgumentException("Invalid search mode selected");
                    }
            }
        }

        /// <summary>
        /// Search for contact(s) by first, last or first and last name depending on the selectedMode or cancel out of the search
        /// </summary>
        private void searchButton_Click(object sender, EventArgs e)
        {
            switch (SelectedMode)
            {
                case FormModes.FirstName:
                    {
                        if (!Validation.isValidString(firstNameTextBox))
                        {
                            MessageBox.Show("You need to enter a first name in the input field with only letters.", "Invalid Input", MessageBoxButtons.OK);
                        }
                        else
                        {
                            SearchValue = firstNameTextBox.Text.Trim().ToLower(); // set case insensitive first name searchValue
                            DialogResult = DialogResult.OK;
                        }
                        break;
                    }

                case FormModes.LastName:
                    {
                        if (!Validation.isValidString(lastNameTextBox))
                        {
                            MessageBox.Show("You need to enter a last name in the input field with only letters.", "Invalid Input", MessageBoxButtons.OK);
                        }
                        else
                        {
                            SearchValue = lastNameTextBox.Text.Trim().ToLower(); // set case insensitive first name searchValue
                            DialogResult = DialogResult.OK; 
                        }
                        break;
                    }

                case FormModes.FullName:
                    {
                        if (!Validation.isValidString(firstNameTextBox) || !Validation.isValidString(lastNameTextBox))
                        {
                            MessageBox.Show("You need to enter a first and last names in the input fields with only letters.", "Invalid Input", MessageBoxButtons.OK);
                        }
                        else
                        {
                            SearchValue = $"{firstNameTextBox.Text.Trim().ToLower()} {lastNameTextBox.Text.Trim().ToLower()}";
                            DialogResult = DialogResult.OK;
                        }
                        break;
                    }

                default:
                    {
                        throw new ArgumentException("Invalid search mode selected");
                    }
            }
        }

        /// <summary>
        /// Cancels out of searching for contact
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
