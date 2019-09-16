using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace UniversityUsers
{
    public abstract class ContactInformation
    {
        /// <summary>
        /// users email address needs to be in correct format as specified by regex
        /// </summary>
        public string EmailAddress
        {
            get
            {
                return emailAddress;  
            }
            set 
            {
                bool isEmail = Regex.IsMatch(value, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                if (isEmail)
                {
                    emailAddress = value;
                }
                else
                {
                    throw new ArgumentException("You have not entered a valid e-mail");
                }
            }
        }

        private string emailAddress;

        /// <summary>
        /// Constructor that initializes email address
        /// </summary>
        /// <param name="EmailAddress"> User email address </param>
        public ContactInformation(string EmailAddress)
        {
            this.EmailAddress = EmailAddress;
        }


        /// <summary>
        /// Override ToString method that give email address as a string
        /// </summary>
        /// <returns> Email Address as a string </returns>
        public override string ToString()
        {
            return $"Email Address: {EmailAddress}";
        }
    }
}
