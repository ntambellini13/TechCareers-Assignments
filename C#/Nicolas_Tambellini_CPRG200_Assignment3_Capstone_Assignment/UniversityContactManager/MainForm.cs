// University Contact Manager program to add faculty/student contacts in a university
// Author: Nicolas Tambellini
// Date: September 2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityUsers;

namespace UniversityContactManager
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Creates form
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Holds contact list with people in the university
        /// </summary>
        public List<UniversityUser> Contacts = new List<UniversityUser>();

        private string filepath = null; // sets default filepath to null 
        private bool fileChangesSaved = true; // Determines if the file was saved since last change

        /// <summary>
        /// Exits the application
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Displays message with basic instructions on how to use the program and who to contact if an error or issue is experienced
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "This application allows you to manage the contact info for students and faculty of the university. \n" +
                             "\n" +
                             "To add, edit, delete or search for contacts, right click on the contacts box.\n" +
                             "\n" +
                             "You can open or save already existing files from the file menu. \n" +
                             "\n" +
                             "You can also save new files and exit the program from the file menu." +
                             "\n" +
                             "\n" +
                             "\n" +
                             "Contact Nico Tambellini for help if you encounter any issues! \n";
            MessageBox.Show(message, "Help Information", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Add new faculty member UniversityUSer
        /// </summary>
        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditFacultyForm facultyForm = new AddEditFacultyForm();
            DialogResult result = facultyForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Contacts.Add(facultyForm.NewFacultyMember); // add new faculty member to contacts list
                contactListBox.Items.Add(facultyForm.NewFacultyMember.ToListBox("Faculty")); // display new faculty member information to contactListBox
                fileChangesSaved = false;
            }
        }

        /// <summary>
        /// Add new student UniversityUser
        /// </summary>
        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditStudentForm studentForm = new AddEditStudentForm();
            DialogResult result = studentForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Contacts.Add(studentForm.NewStudentMember); // add new student to contacts list
                contactListBox.Items.Add(studentForm.NewStudentMember.ToListBox("Student")); // display new student information to contactListBox
                fileChangesSaved = false;
            }
        }

        /// <summary>
        /// Allows editing of existing contact that is selected from the contactListBox 
        /// </summary>
        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> selectedContact = contactListBox.SelectedIndices.Cast<int>().ToList();
            if (selectedContact.Count == 1)
            {
                UniversityUser user = Contacts[selectedContact[0]];
                if (user is Student)
                {
                    // open and populate form with student information for editing
                    AddEditStudentForm studentInfoForm = new AddEditStudentForm((Student)user); DialogResult result = studentInfoForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show($"Saved changes to student {user.FirstName} {user.LastName}", "Student Edited", MessageBoxButtons.OK);
                        contactListBox.Items[selectedContact[0]] = Contacts[selectedContact[0]].ToListBox("Student");
                        fileChangesSaved = false;
                    }
                }
                else if (user is Faculty)
                {
                    // open and populate form with faculty member information for editing
                    AddEditFacultyForm addEditFacultyForm = new AddEditFacultyForm((Faculty)user);
                    DialogResult result = addEditFacultyForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show($"Saved changes to faculty member {user.FirstName} {user.LastName}", "Faculty Member Edited", MessageBoxButtons.OK);
                        contactListBox.Items[selectedContact[0]] = Contacts[selectedContact[0]].ToListBox("Faculty");
                        fileChangesSaved = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please selecte a student or faculty member", "Error", MessageBoxButtons.OK);
                }
            }
            else if (selectedContact.Count == 0)
            {
                MessageBox.Show("Must select a contact to edit.", "No contact selected.", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Must select only one contact to edit.", "Too many contacts selected.", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Display contact info of a selected contact from the contactListBox
        /// </summary>
        private void contactDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayContactInfo();
        }

        /// <summary>
        /// Deletes a contact that is selected in the contactListBox or dispalys a contact is not selected
        /// </summary>
        private void deleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> selectedContact = contactListBox.SelectedIndices.Cast<int>().ToList();
            
            if (selectedContact.Count == 1)
            {
                UniversityUser user = Contacts[selectedContact[0]]; // selected contact
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {user.FirstName} {user.LastName}?", "Confirm Delete", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    Contacts.RemoveAt(selectedContact[0]);
                    contactListBox.Items.RemoveAt(selectedContact[0]);
                    fileChangesSaved = false;
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Must select only one contact to remove.", "No Contact Selected.", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Saves file as a new file and prompts for a filepath to save to
        /// </summary>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        /// <summary>
        /// Saves current file
        /// </summary>
        private void saveContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        /// <summary>
        /// Checks if current file is save, if not prompts save and then opens a new file when specified.
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!fileChangesSaved)
            {
                DialogResult result = MessageBox.Show("There are unsaved changes to the file,  would you like to save before exiting and opening the new file?", "Confirm Exit", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    saveFile();
                    openFile();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    openFile();
                }
            }
            else
            {
                openFile();
            }
        }

        /// <summary>
        /// Display contact info of a selected contact from the contactListBox when they are double clicked
        /// </summary>
        private void contactListBox_DoubleClick(object sender, EventArgs e)
        {
            displayContactInfo();
        }

        /// <summary>
        /// Search for a contact first name, check for matches and return any
        /// </summary>
        private void firstNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open a new search function form with first name field
            SearchFunctionForm search = new SearchFunctionForm(SearchFunctionForm.FormModes.FirstName);

            DialogResult result = search.ShowDialog();

            // check for matches(case insensitive) and highlight those that match
            if (result == DialogResult.OK)
            {
                for (int i = 0; i < Contacts.Count; i++)
                {
                    if (Contacts[i].FirstName.ToLower() == search.SearchValue)
                    {
                        contactListBox.SetSelected(i, true);
                    }
                    else
                    {
                        contactListBox.SetSelected(i, false);
                    }
                }
            }
        }

        /// <summary>
        /// Search for a contact last name, check for matches and return any
        /// </summary>
        private void lastNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open a new search function form with last name field
            SearchFunctionForm search = new SearchFunctionForm(SearchFunctionForm.FormModes.LastName);

            DialogResult result = search.ShowDialog();

            // check for matches(case insensitive) and highlight those that match
            if (result == DialogResult.OK)
            {
                for (int i = 0; i < Contacts.Count; i++)
                {
                    if (Contacts[i].LastName.ToLower() == search.SearchValue)
                    {
                        contactListBox.SetSelected(i, true);
                    }
                    else
                    {
                        contactListBox.SetSelected(i, false);
                    }
                }
            }
        }

        /// <summary>
        /// Search for a contact by first and last name, check for matches and return any
        /// </summary>
        private void firstAndLastNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open a new search function form with first and last name field
            SearchFunctionForm search = new SearchFunctionForm(SearchFunctionForm.FormModes.FullName);

            DialogResult result = search.ShowDialog();

            if (result == DialogResult.OK)
            {
                // check for matches(case insensitive) and highlight those that match
                for (int i = 0; i < Contacts.Count; i++)
                {
                    string FullName = Contacts[i].FirstName + " " + Contacts[i].LastName;
                    if (FullName.ToLower() == search.SearchValue)
                    {
                        contactListBox.SetSelected(i, true);
                    }
                    else
                    {
                        contactListBox.SetSelected(i, false);
                    }
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!fileChangesSaved)
            {
                DialogResult result = MessageBox.Show("There are unsaved changes to the file,  would you like to save before exiting?", "Confirm Exit", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    saveFile();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }


        /// <summary>
        /// Displays contact info for a UniversityUser type based on the one selected
        /// </summary>
        private void displayContactInfo()
        {
            List<int> selectedContact = contactListBox.SelectedIndices.Cast<int>().ToList();

            if (selectedContact.Count == 1)
            {
                MessageBox.Show(Contacts[selectedContact[0]].ToContactDetails(), "Contact Details", MessageBoxButtons.OK);
            }
            else if (selectedContact.Count == 0)
            {
                MessageBox.Show("No contact selected.", "No Contacts Selected", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Too many contacts selected. Choose only one contact.", "Too Many Contacts Selected", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Write UniversityUsers from contacts list to a file or show an error
        /// </summary>
        private void writeFile()
        {
            try
            {
                // try to write a file line by line
                StreamWriter output = new StreamWriter(filepath);
                for (int i = 0; i < Contacts.Count; i++)
                {
                    output.WriteLine(Contacts[i].ToFileString());
                }
                output.Close();
                fileChangesSaved = true; // Changes value to show changes to file have been saved
                return;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Could not write file " + filepath + "\n" + ex.Message, "Writing Error", MessageBoxButtons.OK);
                return;
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error in writing " + filepath + "\n" + ex.Message, "Writing Error", MessageBoxButtons.OK);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an unexpected error\n" + ex.Message + "\nPlease Contact Nico with your error", "Unexpected Error", MessageBoxButtons.OK);
                return;
            }
        }

        /// <summary>
        /// Saves a file using current filepath or prompts for a filepath to be specified if there is not one.
        /// </summary>
        private void saveFile()
        {
            if (filepath == null)
            {
                saveAs();
            }
            else
            {
                writeFile();
            }
        }

        /// <summary>
        /// Saves a file while prompting for a filepath to be specified.
        /// </summary>
        private void saveAs()
        {
            // create new save file dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Contact List File|*.cl",
                DefaultExt = ".cl",
                Title = "Save file ..."
            };

            try
            {
                DialogResult result = saveFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // default save file directory
                    filepath = saveFileDialog.FileName; // set filepath
                };
                if (result != DialogResult.OK)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an unexpected error\n" + ex.Message + "\nPlease Contact Nico with your error message", "Unexpected Error", MessageBoxButtons.OK);
                return;
            }
            writeFile();
        }

        /// <summary>
        /// Opens and Loads a file and populates UniversityUsers in contacts list and contactListBox
        /// </summary>
        private void openFile()
        {
            // creates new open file dialog to select file to be opened
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Contact List File|*.cl",
                DefaultExt = ".cl",
                Title = "Load file .."
            };

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                contactListBox.Items.Clear();
                Contacts.Clear();
                filepath = openFileDialog.FileName; // Sets file path 
                fileChangesSaved = true; // sets changes saved to true
            }
            else
            {
                return;
            }

            // Load file
            StreamReader input = null;
            try
            {
                input = new StreamReader(filepath);
                // Stores information to create new contact
                string newContactLine = null;
                UniversityUser newContact = null;
                while (!input.EndOfStream)
                {
                    // Read new line
                    newContact = null;
                    newContactLine = input.ReadLine();
                    try
                    {
                        // Create user depenting on the type of UniversityUser
                        switch (newContactLine[0].ToString().ToUpper())
                        {
                            case "S":
                                newContact = new Student(newContactLine);
                                break;
                            case "F":
                                newContact = new Faculty(newContactLine);
                                break;
                            default:
                                throw new ArgumentOutOfRangeException("Unsupported user type");
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Could not read some file data.", "Error", MessageBoxButtons.OK);
                    }
                    // If new user created successfully, add them to the contacts list
                    if (newContact is Student)
                    {
                        Contacts.Add(newContact);
                        contactListBox.Items.Add(newContact.ToListBox("Student"));
                    }
                    else if (newContact is Faculty)
                    {
                        Contacts.Add(newContact);
                        contactListBox.Items.Add(newContact.ToListBox("Faculty"));
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Unsupported user type");
                    }
                }
                input.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Could not find file " + filepath + ". " + ex.Message, "Filepath Error", MessageBoxButtons.OK);
                return;
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error in reading " + filepath + ". " + ex.Message, "Reading File Error", MessageBoxButtons.OK);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an unexpected error\n" + ex.Message + "\nPlease Contact Nico with your error", "Unexpected Error", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
