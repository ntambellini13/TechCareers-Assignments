using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityUsers
{
    public class Faculty : UniversityUser
    {
        /// <summary>
        /// Returns contact information in base class as FacultyContactInformation type
        /// </summary>
        public new FacultyContactInformation ContactInformation
        {
            get
            {
                return (FacultyContactInformation)base.ContactInformation;
            }
            set
            {
                base.ContactInformation = value;
            }
        }

        /// <summary>
        /// Constructor for a Faculty member
        /// </summary>
        /// <param name="FirstName"> Faculty member first name </param>
        /// <param name="LastName"> Faculty member last name </param>
        /// <param name="AcademicDepartment"> Faculty member academic department </param>
        /// <param name="ContactInformation"> Faculty member contact information </param>
        public Faculty(string FirstName, string LastName, string AcademicDepartment, FacultyContactInformation ContactInformation) : base(FirstName, LastName, AcademicDepartment, ContactInformation)
        {
            // nothing unique to do here
        }

        /// <summary>
        /// Displays information for a faculty member for contact details menu item
        /// </summary>
        /// <returns> String of a faculty members information with one piece of information on each line </returns>
        public override string ToContactDetails()
        {
            return "Type: Faculty,\n" + base.ToContactDetails() + $"Email: {ContactInformation.EmailAddress},\nOffice Location: {((FacultyContactInformation)ContactInformation).BuildingLocation}";
        }

        /// <summary>
        /// Displays information for a faculty member
        /// </summary>
        /// <returns> String of a faculty members information </returns>
        public override string ToString()
        {
            return base.ToString() + $"Type: Faculty, Email: {ContactInformation.EmailAddress}, Office Location: {((FacultyContactInformation)ContactInformation).BuildingLocation}";
        }

        /// <summary>
        /// Displays faculty member information in a format for the list box
        /// </summary>
        /// <returns> String of faculty member infomation to be displayed in the listbox </returns>
        public override string ToListBox(string userType)
        {
            return base.ToListBox("Faculty");
        }

        /// <summary>
        /// Creates a string to store faculty member in specified file
        /// </summary>
        /// <returns> String of faculty member information to be saved </returns>
        public override string ToFileString()
        {
            return $"Faculty|{FirstName}|{LastName}|{AcademicDepartment}|{ContactInformation.EmailAddress}|{ContactInformation.BuildingLocation}";
        }

        
        /// <summary>
        /// Reads a faculty members information from a file
        /// </summary>
        /// <param name="readFromFile"> String containing faculty member info split by | delimiter </param>
        public Faculty(string readFromFile) : base(readFromFile)
        {
            char[] delimiters = { '|' };
            string[] parameters = readFromFile.Split(delimiters, StringSplitOptions.None);

            ContactInformation = new FacultyContactInformation(parameters[4], parameters[5]);
        }
    }
}
