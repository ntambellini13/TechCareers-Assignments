using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityUsers
{
    public abstract class UniversityUser
    {
        /// <summary>
        /// first name of user, which cannot be empty
        /// </summary>
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please make sure a first name has been inputted");
                }
                else
                {
                    firstName = value;
                }
            }
        }

        /// <summary>
        /// last name of user, which cannot be empty
        /// </summary>
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please make sure a last name has been inputted");
                }
                else
                {
                    lastName = value;
                }
            }
        }

        /// <summary>
        /// academic department of user, which cannot be empty
        /// </summary>
        public string AcademicDepartment
        {
            get
            {
                return academicDepartment;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please make sure a last name has been inputted");
                }
                else
                {
                    academicDepartment = value;
                }
            }
        }

        /// <summary>
        /// Contact information of user, which cannot be empty
        /// </summary>
        public ContactInformation ContactInformation
        {
            get
            {
                return contactInformation;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Contact info is needed");
                }
                else
                {
                    contactInformation = value;
                }
            }
        }

        private string firstName;
        private string lastName;
        private string academicDepartment;
        private ContactInformation contactInformation;

        /// <summary>
        /// Constructor for University User
        /// </summary>
        /// <param name="FirstName"> User first name </param>
        /// <param name="LastName"> User last name </param>
        /// <param name="AcademicDepartment"> User academic apartment </param>
        /// <param name="ContactInformation"> User contact information </param>
        public UniversityUser(string FirstName, string LastName, string AcademicDepartment, ContactInformation ContactInformation)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.AcademicDepartment = AcademicDepartment;
            this.ContactInformation = ContactInformation;
        }

        /// <summary>
        /// Reads first 3 parameters common to every person from a file.
        /// </summary>
        /// <param name="readFromFile"> String containing person type first name, last name, and academic department split by | delimiter </param>
        protected UniversityUser(string readFromFile)
        {
            char[] delimiters = { '|' };
            string[] parameters = readFromFile.Split(delimiters, StringSplitOptions.None);

            FirstName = parameters[1];
            LastName = parameters[2];
            AcademicDepartment = parameters[3];
        }

        /// <summary>
        /// Displays general contact information for a user
        /// </summary>
        /// <returns> General info (first name, last name and academic department) for a user as a string with one piece of information on each line </returns>
        public virtual string ToContactDetails()
        {
            return $"First Name: {FirstName},\nLast Name: {LastName},\nAcademic Department: {AcademicDepartment},\n";
        }

        /// <summary>
        /// Display summary of general information for a user
        /// </summary>
        /// <returns> General info (first name, last name and academic department) for a user as a string </returns>
        public override string ToString()
        {
            return $"First Name: {FirstName}, Last Name: {LastName}, Academic Department: {AcademicDepartment}";
        }

        /// <summary>
        /// Displays a string to be published in contact list box
        /// </summary>
        /// <returns> General info (first name, last name and academic department) as a string to go in list box </returns>
        public virtual string ToListBox(string userType)
        {
            return $"{FirstName,-20} {LastName,-20} {userType,-15} {AcademicDepartment,-20}";
        }

        /// <summary>
        /// Returns a string to be written to a file
        /// </summary>
        /// <returns> General info (first name, last name and academic department) as a string to go in the file to be saved </returns>
        public abstract string ToFileString();

    }
}
