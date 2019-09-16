using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityUsers
{
    public class Student: UniversityUser
    {
        /// <summary>
        /// Expected graduation year of student, which must be equal to or greater than the current year
        /// </summary>
        public int ExpectedGraduationYear
        {
            get
            {
                return expectedGraduationYear;
            }
            set
            {
                if(value >= DateTime.Now.Year)
                {
                    expectedGraduationYear = value;
                }
                else
                {
                    throw new ArgumentException("Cannot set an expected graduation year that is before the current year");
                }
            }
        }

        /// <summary>
        /// Returns contact information in base class as StudentContactInformation type
        /// </summary>
        public new StudentContactInformation ContactInformation
        {
            get
            {
                return (StudentContactInformation)base.ContactInformation;
            }
            set
            {
                base.ContactInformation = value;
            }
        }

        /// <summary>
        /// Student course registration as a list
        /// </summary>
        public List<string> CourseList
        { get; set; }


        private int expectedGraduationYear;

        /// <summary>
        /// Constructor for Student user without a specified expected graduation year that sets to current year + 4 as default and sets course list to empty if one not specified
        /// </summary>
        /// <param name="FirstName"> Student first name </param>
        /// <param name="LastName"> Student last name </param>
        /// <param name="AcademicDepartment"> Student academic departement </param>
        /// <param name="ContactInformation"> Student contact information </param>
        /// <param name="CourseList"> Student course list </param>
        public Student (string FirstName, string LastName, string AcademicDepartment, StudentContactInformation ContactInformation, List<string> CourseList = null) : base(FirstName, LastName, AcademicDepartment, ContactInformation)
        {
            if (CourseList == null)
            {
                CourseList = new List<string>();
            }
            else
            {
                this.CourseList = CourseList;
            }
            ExpectedGraduationYear = DateTime.Now.Year + 4;
        }

        /// <summary>
        /// Constructor for Student user with a specified expected graduation year and sets course list to empty if one not specified
        /// </summary>
        /// <param name="FirstName"> Student first name </param>
        /// <param name="LastName"> Student last name </param>
        /// <param name="AcademicDepartment"> Student academic departement </param>
        /// <param name="ContactInformation"> Student contact information </param>
        /// <param name="CourseList"> Student registered course list </param>
        public Student(string FirstName, string LastName, string AcademicDepartment, StudentContactInformation ContactInformation, int ExpectedGraduationYear, List<string> CourseList = null) : base(FirstName, LastName, AcademicDepartment, ContactInformation)
        {
            if (CourseList == null)
            {
                CourseList = new List<string>();
            }
            else
            {
                this.CourseList = CourseList;
            }
            this.ExpectedGraduationYear = ExpectedGraduationYear;
        }

        /// <summary>
        /// Displays contact details for a student
        /// </summary>
        /// <returns> String of a students information with one piece of information on each line </returns>
        public override string ToContactDetails()
        {
            string studentInfoString = "Type: Student,\n" + base.ToContactDetails() + $"Email: {ContactInformation.EmailAddress},\nMailing Address: {((StudentContactInformation)ContactInformation).MailingAddress},\nExpected Graduation Year: {ExpectedGraduationYear},\nCourse List: \n";
            for (int i = 0; i < CourseList.Count; i++)
            {
                studentInfoString += "   " + CourseList[i] + "\n";
            }
            return studentInfoString;
        }


        /// <summary>
        /// Displays information for a student
        /// </summary>
        /// <returns> String of a students information </returns>
        public override string ToString()
        {
            string studentInfoString = base.ToString() + $"Type: Student, Email: {ContactInformation.EmailAddress}, Mailing Address: {((StudentContactInformation)ContactInformation).MailingAddress}, Expected Graduation Year: {ExpectedGraduationYear}, Course List: ";
            for (int i = 0; i < CourseList.Count; i++)
            {
                studentInfoString += CourseList[i] + ",";
            }
            return studentInfoString;
        }

        /// <summary>
        /// Displays student information in a format for the list box
        /// </summary>
        /// <returns> String of student infomation to be displayed in the listbox </returns>
        public override string ToListBox(string userType)
        {
            return base.ToListBox("Student");
        }

        /// <summary>
        /// Creates a string to store faculty member in specified file
        /// </summary>
        /// <returns> String of faculty member information to be saved </returns>
        public override string ToFileString()
        {
            
            // Courses in list are separated by commas
            return $"Student|{FirstName}|{LastName}|{AcademicDepartment}|{ContactInformation.EmailAddress}|{ContactInformation.MailingAddress}|{ExpectedGraduationYear}|{string.Join(",", CourseList)}";
        }


        /// <summary>
        /// Reads a faculty members information from a file
        /// </summary>
        /// <param name="readFromFile"> String containing faculty member info split by | delimiter </param>
        public Student(string readFromFile) : base(readFromFile)
        {
            char[] delimiters = { '|' };
            string[] parameters = readFromFile.Split(delimiters, StringSplitOptions.None);

            ContactInformation = new StudentContactInformation(parameters[4], parameters[5]);

            // try to read graduation year from file or throws an exception
            int expectedGraduationYear;
            if (int.TryParse(parameters[6], out expectedGraduationYear))
            {
                ExpectedGraduationYear = expectedGraduationYear;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Cannot read graduation year from file");
            }
           

            // Course list is re-made from comma separated list in file (empty entries removed)
            CourseList = new List<string>(parameters[7].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
