using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace UniversityContactManager
{
    public class Validation
    {
        /// <summary>
        /// Checks if textbox value is null/ empty or not
        /// </summary>
        /// <param name="textbox"> input from textbox </param>
        /// <returns> Returns bool value for validation </returns>
        public static bool isNotNullOrEmpty (TextBox textbox)
        {
            if (textbox.Text.Trim() != null && textbox.Text.Trim() != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if textbox is null/empty and if year in textbox is an int and before current year
        /// </summary>
        /// <param name="textbox"> input from textbox </param>
        /// <returns> Returns bool value for validation </returns>
        public static bool isNotBeforeCurrentYear(TextBox textbox)
        {
            int year;
            if (Validation.isNotNullOrEmpty(textbox) && int.TryParse(textbox.Text.Trim(), out year))
            {
                if (DateTime.Now.Year > year)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks textbox if null/empty and if email entered matches regex
        /// </summary>
        /// <param name="textbox"> input from textbox </param>
        /// <returns> Returns bool value for validation </returns>
        public static bool isValidEmail(TextBox textbox)
        {
            if (Validation.isNotNullOrEmpty(textbox) && Regex.IsMatch(textbox.Text.Trim(), @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Check if textbox is null/empty and if string contains only letters
        /// </summary>
        /// <param name="textbox"> input from textbox </param>
        /// <returns> Returns bool value for validation </returns>
        public static bool isValidString(TextBox textbox)
        {
            if (Validation.isNotNullOrEmpty(textbox) && Regex.IsMatch(textbox.Text.Trim(), @"^[a-zA-Z]+"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
