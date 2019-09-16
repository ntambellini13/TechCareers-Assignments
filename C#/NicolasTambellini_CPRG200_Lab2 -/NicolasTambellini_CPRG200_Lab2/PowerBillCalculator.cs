using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerData;
using System.IO;


/*
 * Application to calculate the power bill for residential, commercial and industrial customers
 * based on their unique rates and kWh usage. Additionally it stores customer information including 
 * account number, customer came, customer type, and charge amount and displays the information
 * for customers that have been added in a data list box. Also calculates a sum of all 
 * charges for residential, commercial and industrial customer types and the overall sum of 
 * all charges in additionl to the total number of customers entered.
 * 
 * Date Created: August 20th, 2019
 * Author: Nicolas Tambellini
*/

namespace NicolasTambellini_CPRG200_Lab2
{
    public partial class PowerBillForm : Form
    {
        List<Customer> customerList = new List<Customer>(); // empty customer list
        const string PATH = "Customers.txt"; // path to read and write customer data from

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
            customerTypeComboBox.SelectedItem = "Residential";
            resetTextBoxes();
        }

        // Click button event that calculates the power bill based on customer type
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerTypeComboBox.SelectedItem.ToString() == "Residential")
                {
                    if (residentialCustomerValidation())
                    {
                        Customer residentialCustomer = new Customer(1, "Unknown", "R");
                        decimal bill = residentialCustomer.CalculateCharge(int.Parse(kwhUsedTextBox.Text));
                        billTextBox.Text = bill.ToString("c2");
                    }
                }
                else if (customerTypeComboBox.SelectedItem.ToString() == "Commercial")
                {
                    if (commercialCustomerValidation())
                    {
                        Customer commercialCustomer = new Customer(1, "Unknown", "C");
                        decimal bill = commercialCustomer.CalculateCharge(int.Parse(kwhUsedTextBox.Text));
                        billTextBox.Text = bill.ToString("c2");
                    }
                }
                else if (customerTypeComboBox.SelectedItem.ToString() == "Industrial")
                {
                    if (industrialCustomerValidation())
                    {
                        Customer industrialCustomer = new Customer(1, "Unknown", "I");
                        decimal bill = industrialCustomer.CalculateCharge(int.Parse(kwhUsedTextBox.Text), int.Parse(offPeakKwhUsedTextBox.Text));
                        billTextBox.Text = bill.ToString("c2");
                    }
                }
                else
                {
                    MessageBox.Show("You have selected an invalid customer type, please choose a valid customer type!", "Invalid Customer Type");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nPlease contact Nico with your error message!", "Program Crashed");
            }
        }


        // ComboxBox selection changes available fields and changes label names based on type of customer that is chosen.
        private void customerTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerTypeComboBox.SelectedItem.ToString() == "Residential" || customerTypeComboBox.SelectedItem.ToString() == "Commercial")
            {
                offPeakKwhUsedLabel.Visible = false;
                offPeakKwhUsedTextBox.Visible = false;
                kWhUsageLabel.Text = "Overall kWh Used:";
                resetTextBoxes();
            }
            else if (customerTypeComboBox.SelectedItem.ToString() == "Industrial")
            {
                offPeakKwhUsedLabel.Visible = true;
                offPeakKwhUsedTextBox.Visible = true;
                kWhUsageLabel.Text = "Peak kWh Used:";
                resetTextBoxes();
            }
        }

        /// <summary>
        /// Resets the text boxes to empty and focuses on the Account Number TextBox.
        /// </summary>
        /// <returns> Empty strings in all text boxes focus on Account Number TextBox</returns>
        private void resetTextBoxes()
        {
            kwhUsedTextBox.Text = "";
            offPeakKwhUsedTextBox.Text = "";
            billTextBox.Text = "";
            accountNumberTextBox.Text = "";
            customerNameTextBox.Text = "";
            this.ActiveControl = accountNumberTextBox;
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
                    int peakKwhUsage = int.Parse(kwhUsedTextBox.Text);
                    int offPeakKwhUsage = int.Parse(offPeakKwhUsedTextBox.Text);
                    if (peakKwhUsage < 0 || offPeakKwhUsage < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Please make sure you have only entered non-negative integer values in the Peak kWh Used and Off-Peak kWh Used fields and it they are not greater than {int.MaxValue}!!", "Invalid Input");
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
                    int commercialKwhUsage = int.Parse(kwhUsedTextBox.Text);
                    if (commercialKwhUsage < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Please make sure you have only entered a non-negative integer value in the Overal kWh Used field and it is not greater than {int.MaxValue}!", "Invalid Input");
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
                    int residentialKwhUsage = int.Parse(kwhUsedTextBox.Text);
                    if (residentialKwhUsage < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    return true;
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Please make sure you have only entered a non-negative integer value in the Overal kWh Used field and it is not greater than {int.MaxValue}!", "Invalid Input");
                    return false;
                }
            }
            MessageBox.Show("You have selected an invalid customer type, please choose a valid customer type!", "Invalid Customer Type");
            return false;
        }

        /// <summary>
        /// Validates that the account number entered is a positive integer value or throws and error.
        /// </summary>
        /// <returns> Validates the input value or displays an error message in a message box </returns>
        private bool accountNoValidation()
        {
            try
            {
                int accountNum = int.Parse(accountNumberTextBox.Text);
                if (accountNum <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Please make sure you have only entered a positive integer value in the Account Number field!", "Invalid Input");
                return false;
            }
        }

        /// <summary>
        /// Validates that the customer name entered is not an empty string or throws and error.
        /// </summary>
        /// <returns> Validates the input value or displays an error message in a message box </returns>
        private bool customerNameValidation()
        {
            try
            {
                string customerName = customerNameTextBox.Text;
                if (customerName == "")
                {
                    throw new Exception();
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Please make sure you have entered a name in the input field", "Invalid Input");
                return false;
            }
            MessageBox.Show("There has been an error, please contact Nico", "Input Value Error");
            return false;
        }

        // Sets default customer type to residential and focuses on the Overall kWh Used input text box when form is loaded. 
        private void PowerBillForm_Load(object sender, EventArgs e)
        {
            customerTypeComboBox.SelectedItem = "Residential";
            this.ActiveControl = accountNumberTextBox;
            GetCustomers();
            calculateStatistics();
        }

        // Click button event that adds a new customer and writes it to the Customer.txt file and calculates the bill for that customer
        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerTypeComboBox.SelectedItem.ToString() == "Residential")
                {
                    if (accountNoValidation() && customerNameValidation() && residentialCustomerValidation())
                    {
                        Customer residentialCustomer = new Customer(
                            int.Parse(accountNumberTextBox.Text),
                            customerNameTextBox.Text,
                            "R");
                        decimal bill = residentialCustomer.CalculateCharge(int.Parse(kwhUsedTextBox.Text));
                        residentialCustomer.ChargeAmount = bill;
                        billTextBox.Text = bill.ToString("c2");
                        writeCustomer(residentialCustomer);
                    }
                }
                else if (customerTypeComboBox.SelectedItem.ToString() == "Commercial")
                {
                    if (accountNoValidation() && customerNameValidation() && commercialCustomerValidation())
                    {
                        Customer commercialCustomer = new Customer(
                            int.Parse(accountNumberTextBox.Text),
                            customerNameTextBox.Text,
                            "C");
                        decimal bill = commercialCustomer.CalculateCharge(int.Parse(kwhUsedTextBox.Text));
                        commercialCustomer.ChargeAmount = bill;
                        billTextBox.Text = bill.ToString("c2");
                        writeCustomer(commercialCustomer);
                    }
                }
                else if (customerTypeComboBox.SelectedItem.ToString() == "Industrial")
                {
                    if (accountNoValidation() && customerNameValidation() && industrialCustomerValidation())
                    {
                        Customer industrialCustomer = new Customer(
                            int.Parse(accountNumberTextBox.Text),
                            customerNameTextBox.Text,
                            "I");
                        decimal bill = industrialCustomer.CalculateCharge(int.Parse(kwhUsedTextBox.Text), int.Parse(offPeakKwhUsedTextBox.Text));
                        industrialCustomer.ChargeAmount = bill;
                        billTextBox.Text = bill.ToString("c2");
                        writeCustomer(industrialCustomer);
                    }
                }
                else
                {
                    MessageBox.Show("Oops there has been an error, Please contact Nico!", "Invalid Entry");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Please contact Nico with your error message!", "Program Crashed");
            }
        }

        /// <summary>
        /// Writes new customer data to Customer.txt file
        /// </summary>
        /// <param name="newCustomer"> New Customer object that was created </param>
        /// <returns> Customer data written into Customer.txt file </returns>
        private void writeCustomer(Customer newCustomer)
        {
            try
            {
                StreamWriter sr = new StreamWriter(PATH, true);
                sr.WriteLine(newCustomer.ToFileLine());
                customerList.Add(newCustomer);
                customerDataListBox.Items.Add(newCustomer.ToListBox());
                calculateStatistics();
                sr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "Please contact Nico with your error message!", "Opening or Writing Error");
            }
        }

        /// <summary>
        /// Gets customer data from Customer.txt file to display in the customerDataListBox.
        /// </summary>
        /// <returns> Customer data displayed in customerDataListBox </returns>
        private List<Customer> GetCustomers()
        {
            try
            {
                Customer c; // rename customer for reading
                string line; // line from the file
                string[] fields; // fields from the current line
                using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate,
                                                    FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            line = sr.ReadLine();
                            fields = line.Split(',');
                            c = new Customer(
                               int.Parse(fields[0]),
                               fields[1],
                               fields[2],
                               decimal.Parse(fields[3]));
                            customerList.Add(c);
                            customerDataListBox.Items.Add(c.ToListBox());
                        }
                        sr.Close();
                    }
                }
                return customerList;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "Please contact Nico with your error message!", "Opening or Reading Error");
                return customerList;
            }
        }


        /// <summary>
        /// Calculates total charges for residential, commercial and industrial customers and the total charges for all customers
        /// as well as the total number of customers based on the customer data that has been entered.
        /// </summary>
        /// <returns> Total values for Residential, Customer, Industrial and Overall Charges for all customers, 
        /// as well as the total number of customers based on the entered customer data</returns>
        private void calculateStatistics()
        {
            decimal residentialCharges = 0; // sum of residential customer charges
            decimal commercialCharges = 0; // sum of commercial customer charges
            decimal industrialCharges = 0; // sum or industrial customer charges

            foreach (Customer c in customerList)
            {
                Console.WriteLine(c.CustomerType);
                if (c.CustomerType == "R")
                {
                    residentialCharges += c.ChargeAmount;
                }
                else if (c.CustomerType == "C")
                {
                    commercialCharges += c.ChargeAmount;
                }
                else if (c.CustomerType == "I")
                {
                    industrialCharges += c.ChargeAmount;
                }
                else
                {
                    MessageBox.Show("There was an error calculating the total charges for the different customer classes, Please Contact Nico!", "Calculation Error");
                }
            }

            totalResidentialChargesTextBox.Text = residentialCharges.ToString("c2");
            totalCommercialChargesTextBox.Text = commercialCharges.ToString("c2");
            totalIndustrialChargesTextBox.Text = industrialCharges.ToString("c2");
            totalChargesTextBox.Text = (residentialCharges + commercialCharges + industrialCharges).ToString("c2");
            totalCustomersTextBox.Text = customerList.Count().ToString();
        }
    }
}
