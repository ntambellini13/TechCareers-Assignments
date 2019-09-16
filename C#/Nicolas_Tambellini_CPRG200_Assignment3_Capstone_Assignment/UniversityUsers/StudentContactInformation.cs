using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityUsers
{
    public class StudentContactInformation : ContactInformation
    {
        /// <summary>
        /// Mailing address for student, which cannot be empty
        /// </summary>
        public string MailingAddress 
        {
            get
            {
                return mailingAddress;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please make sure mailing address has been inputted");
                }
                else
                {
                    mailingAddress = value;
                }
            }
        }

        private string mailingAddress;
        
        /// <summary>
        /// Constructor for student contact information.
        /// </summary>
        /// <param name="EmailAddress"> student email address </param>
        /// <param name="MailingAddress"> student mailing address </param>
        public StudentContactInformation (string EmailAddress, string MailingAddress) : base(EmailAddress)
        {
            this.MailingAddress = MailingAddress;
        }
    }
}
