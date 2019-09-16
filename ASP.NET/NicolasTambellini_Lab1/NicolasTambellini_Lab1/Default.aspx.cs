using System;

namespace NicolasTambellini_Lab1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Converts Input Temperature To Selected Output Temperature Based on the To and From Scales Selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void convertButton_Click(object sender, EventArgs e)
        {
            switch (fromTemperatureDropDownList.SelectedValue)
            {
                case "Celsius":
                    convertCelsius(fromTemperatureDropDownList.SelectedValue);
                    break;
                case "Fahrenheit":
                    convertFahrenheit(fromTemperatureDropDownList.SelectedValue);
                    break;
                case "Kelvin":
                    convertKelvin(fromTemperatureDropDownList.SelectedValue);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Converts Input Temperature from initial scale to the Kelvin Scale
        /// </summary>
        /// <param name="selectedValue"> Input Temperature in Kelvin </param>
        private void convertKelvin(string selectedValue)
        {
            double inputValue;
            if (double.TryParse(inputTemperatureTextBox.Text, out inputValue))
            {
                if (toTemperatureDropDownList.SelectedValue == "Kelvin")
                {
                    outputTemperatureTextBox.Text = inputValue.ToString("f2");
                }
                else if (toTemperatureDropDownList.SelectedValue == "Fahrenheit")
                {
                    outputTemperatureTextBox.Text = ((inputValue - 273.15) * 9 / 5 + 32).ToString("f2");
                }
                else if (toTemperatureDropDownList.SelectedValue == "Celsius")
                {
                    outputTemperatureTextBox.Text = (inputValue - 273.15).ToString("f2");
                }
            }
        }

        /// <summary>
        /// Converts Input Temperature from initial scale to Fahrenheit Scale
        /// </summary>
        /// <param name="selectedValue"> Input Temperature in Fahrenheit </param>
        private void convertFahrenheit(string selectedValue)
        {
            double inputValue;
            if (double.TryParse(inputTemperatureTextBox.Text, out inputValue))
            {
                if (toTemperatureDropDownList.SelectedValue == "Fahrenheit")
                {
                    outputTemperatureTextBox.Text = inputValue.ToString("f2");
                }
                else if (toTemperatureDropDownList.SelectedValue == "Celsius")
                {
                    outputTemperatureTextBox.Text = ((inputValue - 32) * 5 / 9).ToString("f2");
                }
                else if (toTemperatureDropDownList.SelectedValue == "Kelvin")
                {
                    outputTemperatureTextBox.Text = ((inputValue - 32) * 5 / 9 + 273.15).ToString("f2");
                }
            }
        }

        /// <summary>
        /// Converts Input Temperature from initial scale to Celsius Scale
        /// </summary>
        /// <param name="selectedValue"> Input Temperature in Celsuis </param>
        private void convertCelsius(string selectedValue)
        {
            double inputValue;
            if (double.TryParse(inputTemperatureTextBox.Text, out inputValue))
            {
                if (toTemperatureDropDownList.SelectedValue == "Celsius")
                {
                    outputTemperatureTextBox.Text = inputValue.ToString("f2");
                }
                else if (toTemperatureDropDownList.SelectedValue == "Fahrenheit")
                {
                    outputTemperatureTextBox.Text = ((inputValue * 9 / 5) + 32).ToString("f2");
                }
                else if (toTemperatureDropDownList.SelectedValue == "Kelvin")
                {
                    outputTemperatureTextBox.Text = (inputValue + 273.15).ToString("f2");
                }
            }
        }

        /// <summary>
        /// Clears all input fields and reverts conversion to and from scales to celsius and fahrenheit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void clearButton_Click(object sender, EventArgs e)
        {
            inputTemperatureTextBox.Text = "";
            outputTemperatureTextBox.Text = "";
            fromTemperatureDropDownList.SelectedValue = "Celsius";
            toTemperatureDropDownList.SelectedValue = "Fahrenheit";
        }


    }
}