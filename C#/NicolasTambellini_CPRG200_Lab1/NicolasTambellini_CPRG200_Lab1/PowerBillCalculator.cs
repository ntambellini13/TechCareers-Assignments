using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * Application to calculate the power bill for residential, commercial and industrial customers
 * based on their unique rates and kWh usage.
 * 
 * Date Created: August 14th, 2019
 * Author: Nicolas Tambellini
*/

namespace NicolasTambellini_CPRG200_Lab1
{
    public partial class PowerBillForm : Form
    {
        public PowerBillForm()
        {
            InitializeComponent();
        }

        // Click button event that closes the window
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Click button even that clears all fields and resets the customerTypeComboBox to the default customer type of residential
        private void clearButton_Click(object sender, EventArgs e)
        {
            kwhUsedText.Text = "";
            offPeakKwhUsedText.Text = "";
            billText.Text = "";
            customerTypeComboBox.SelectedItem = "Residential";
        }

        // Click button event that calculates the power bill based on customer type
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (customerTypeComboBox.SelectedItem.ToString() == "Residential")
            {
                if (residentialCustomerValidation())
                {
                    decimal bill = calculateResidentialBill(int.Parse(kwhUsedText.Text));
                    billText.Text = bill.ToString("c2");
                }
            }
            else if (customerTypeComboBox.SelectedItem.ToString() == "Commercial")
            {
                if (commercialCustomerValidation())
                {
                    decimal bill = calculateCommercialBill(int.Parse(kwhUsedText.Text));
                    billText.Text = bill.ToString("c2");
                }
            }
            else if (customerTypeComboBox.SelectedItem.ToString() == "Industrial")
            {
                if (industrialCustomerValidation())
                {
                    decimal bill = calculateIndustrialBill(int.Parse(kwhUsedText.Text), int.Parse(offPeakKwhUsedText.Text));
                    billText.Text = bill.ToString("c2");
                }
            }
            else
            {
                MessageBox.Show("You have selected an invalid customer type, please choose a valid customer type!", "Invalid Customer Type");
            }
    }


        // ComboxBox selection changes available fields and changes label names based on type of customer that is chosen.
        private void customerTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerTypeComboBox.SelectedItem.ToString() == "Residential" || customerTypeComboBox.SelectedItem.ToString() == "Commercial")
            {
                offPeakKwhUsedLabel.Visible = false;
                offPeakKwhUsedText.Visible = false;
                kWhUsageLabel.Text = "Overall kWh Used:";
                kwhUsedText.Text = "";
                offPeakKwhUsedText.Text = "";
                billText.Text = "";
                this.ActiveControl = kwhUsedText;
            }
            else if (customerTypeComboBox.SelectedItem.ToString() == "Industrial")
            {
                offPeakKwhUsedLabel.Visible = true;
                offPeakKwhUsedText.Visible = true;
                kWhUsageLabel.Text = "Peak kWh Used:";
                kwhUsedText.Text = "";
                offPeakKwhUsedText.Text = "";
                billText.Text = "";
                this.ActiveControl = kwhUsedText;
            }
        }

        /// <summary>
        /// Calculate the residential customers bill based on overall kWh usage.
        /// </summary>
        /// <param name="kwhUsed"> Overal kWh used by the commercial customer </param>
        /// <returns> Calculated residential customers bill amount </returns>
        private decimal calculateResidentialBill(int kwhUsed)
        {
            int residentialKwhUsage = int.Parse(kwhUsedText.Text); // overall residential kWh used
            decimal bill; // residential bill for electricity use

            bill = 6.00m + (0.052m * residentialKwhUsage);
            return bill;
        }

        /// <summary>
        /// Calculate the commercial customers bill based on overall kWh usage.
        /// </summary>
        /// <param name="kwhUsed"> Overal kWh used by the commercial customer </param>
        /// <returns> Calculated commercial customers bill amount </returns>
        private decimal calculateCommercialBill(int kwhUsed)
        {
            int commercialKwhUsage = int.Parse(kwhUsedText.Text); // overall commercial kWh used
            decimal bill; // commercial bill for electricity use

            if (commercialKwhUsage <= 1000)
            {
                bill = 60.00m;
            }
            else
            {
                bill = 60.00m + (0.045m * (commercialKwhUsage - 1000));
            }
            return bill;
        }

        /// <summary>
        /// Calculate the industrial customers bill based on peak and off-peak kWh usage.
        /// </summary>
        /// <param name="peakKwhUsed"> Peak period kWh usage </param>
        /// <param name="offPeakKwhUsed"> Off-peak period kWh usage </param>
        /// <returns> Calculated total bill for industrial customer based of calculated peak and off-peak charges </returns>
        private decimal calculateIndustrialBill(int peakKwhUsed, int offPeakKwhUsed)
        {
            int peakKwhUsage = int.Parse(kwhUsedText.Text); // peak kWh used
            int offPeakKwhUsage = int.Parse(offPeakKwhUsedText.Text); // off-peak kWh used

            decimal peakCharge; // bill for peak period electricity use
            decimal offPeakCharge; // bill off-peak period electricity use
            decimal bill; // total bill for electricity use

            if (peakKwhUsage <= 1000)
            {
                peakCharge = 76.00m;
            }
            else
            {
                peakCharge = 76.00m + (0.065m * (peakKwhUsage - 1000));
            }

            if (offPeakKwhUsage <= 1000)
            {
                offPeakCharge = 40.00m;
            }
            else
            {
                offPeakCharge = 40.00m + (0.028m * (offPeakKwhUsage - 1000));
            }
            return bill = peakCharge + offPeakCharge;
        }

        /// <summary>
        /// Validates that peak and off-peak kWh used values inputted are non-zero integer values or throws an error for industrial customers.
        /// </summary>
        /// <returns> Validates input values or displays an error message in a message box </returns>
        private bool industrialCustomerValidation()
        {
            if (customerTypeComboBox.SelectedItem.ToString() == "Industrial")
            {
                try
                {
                    int peakKwhUsage = int.Parse(kwhUsedText.Text);
                    int offPeakKwhUsage = int.Parse(offPeakKwhUsedText.Text);
                    if (peakKwhUsage < 0 || offPeakKwhUsage < 0)
                    {
                        throw new Exception();
                    }
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Please make sure you have only entered non-negative integer values in the input fields!", "Invalid Input");
                    return false;
                }
            }
            MessageBox.Show("You have selected an invalid customer type, please choose a valid customer type!", "Invalid Customer Type");
            return false;
        }

        /// <summary>
        /// Validates that overall kWh used input value is a non-negative integer values or throws an error for commercial customers.
        /// </summary>
        /// <returns> Validates input value or displays an error message in a message box </returns>
        private bool commercialCustomerValidation()
        {
            if (customerTypeComboBox.SelectedItem.ToString() == "Commercial")
            {
                try
                {
                    int commercialKwhUsage = int.Parse(kwhUsedText.Text);
                    if (commercialKwhUsage < 0)
                    {
                        throw new Exception();
                    }
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Please make sure you have only entered a non-negative integer value in the input field!", "Invalid Input");
                    return false;
                }
            }
            MessageBox.Show("You have selected an invalid customer type, please choose a valid customer type!", "Invalid Customer Type");
            return false;
        }

        /// <summary>
        /// Validates that overall kWh used input value is a non-negative integer values or throws an error for commercial customers.
        /// </summary>
        /// <returns> Validates input value or displays an error message in a message box </returns>
        private bool residentialCustomerValidation()
        {
            if (customerTypeComboBox.SelectedItem.ToString() == "Residential")
            {
                try
                {
                    int residentialKwhUsage = int.Parse(kwhUsedText.Text);
                    if (residentialKwhUsage < 0)
                    {
                        throw new Exception();
                    }
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Please make sure you have only entered a non-negative integer value in the input field!", "Invalid Input");
                    return false;
                }
            }
            MessageBox.Show("You have selected an invalid customer type, please choose a valid customer type!", "Invalid Customer Type");
            return false;
        }

        // Sets default customer type to residential and focuses on the Overall kWh Used input text box when form is loaded. 
        private void PowerBillForm_Load(object sender, EventArgs e)
        {
            customerTypeComboBox.SelectedItem = "Residential";
            this.ActiveControl = kwhUsedText;
        }
    }
}
