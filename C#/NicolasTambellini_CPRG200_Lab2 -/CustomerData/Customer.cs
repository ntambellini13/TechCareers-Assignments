using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomerData
{
    public class Customer
    {
        //public properties
        public int AccountNo // Inputted Account Number for the Customer
        {
            get
            {
                return accountNo;
            }
        }
        public string CustomerName // Inputted Customer Name
        {
            get
            {
                return customerName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Please make sure you have typed the customer name into the Customer Name field!");
                }
                customerName = value;
            }
        }
        public string CustomerType // Residential = R, Commercial = C, Industrial = I
        {
            get
            {
                return customerType;
            }
            set
            {
                if (!(value == "R" || value == "C" || value == "I"))
                {
                    throw new ArgumentOutOfRangeException("Please make sure you selected a valid customer type!");
                }
                customerType = value;
            }
        }
        public decimal ChargeAmount // Calculated Bill Amount for the Customer
        {
            get
            {
                return chargeAmount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Charge Amount cannot be less than zero");
                }
                else if (value > decimal.MaxValue)
                {
                    throw new ArgumentOutOfRangeException($"Charge Amount cannot be greater than {decimal.MaxValue}");
                }
                else if (value.GetType().Equals(typeof(decimal)) != true)
                {
                    throw new FormatException("Charge Amount is not in the correct format of a decimal");
                }
                chargeAmount = value;
            }
        }

        //private properties
        private int accountNo;
        private string customerName;
        private string customerType;
        private decimal chargeAmount;

        /// <summary>
        /// Initializes a new instance of the Customer class.
        /// </summary>
        /// <param name="AccountNo"> Customer Account Number as a postive integer </param>
        /// <param name="CustomerName"> Customer Name as a non-empty string </param>
        /// <param name="CustomerType"> Customer Type as Residential = R, Commercial = C, Industrial = I </param>
        /// <param name="ChargeAmount"> Calculated Bill amount based on customer type </param>
        public Customer(int AccountNo, string CustomerName, string CustomerType, decimal ChargeAmount = 0)
        {
            if (AccountNo <= 0)
            {
                throw new ArgumentOutOfRangeException("Please enter a positive integer value in the Account Number field!");
            }
            else
            {
                this.accountNo = AccountNo;
            }

            this.CustomerName = CustomerName;
            this.CustomerType = CustomerType;
            this.ChargeAmount = ChargeAmount;
        }

        /// <summary>
        /// Calculates Bill for a Residential or Commercial Customer or throws error exception
        /// </summary>
        /// <param name="kwhUsed"> Overal kWh used by the commercial customer </param>
        /// <returns> Calculated commercial customers bill amount or error exception </returns>
        public decimal CalculateCharge(int kwhUsed)
        {
            if (kwhUsed < 0)
            {
                throw new ArgumentOutOfRangeException("Please make sure kwhUsed is a non-negative integer value!");
            }
            else if (CustomerType == "R")
            {
                return this.ChargeAmount = 6.00m + (0.052m * kwhUsed);
            }
            else if (CustomerType == "C")
            {
                if (kwhUsed <= 1000)
                {
                    return this.ChargeAmount = 60.00m;
                }
                else
                {
                    return this.ChargeAmount = 60.00m + (0.045m * (kwhUsed - 1000));
                }
            }
            else
            {
                throw new InvalidOperationException("A valid customer type has not been assigned and the calculate charge method could not be executed");
            }
        }

        /// <summary>
        /// Calculate the industrial customers bill based on peak and off-peak kWh usage or throws error exception
        /// </summary>
        /// <param name="peakKwhUsed"> Peak period kWh usage </param>
        /// <param name="offPeakKwhUsed"> Off-peak period kWh usage </param>
        /// <returns> Calculated total bill for industrial customer based of calculated peak and off-peak charges or error exception </returns>
        public decimal CalculateCharge(int peakKwhUsed, int offPeakKwhUsed)
        {
            if (CustomerType == "I" && (peakKwhUsed < 0 || offPeakKwhUsed < 0))
            {
                throw new ArgumentOutOfRangeException("Please make peakKwhUsed and offPeakKwhUsed are non-negative integer values!");
            }
            else if (CustomerType == "I" && (peakKwhUsed <= 1000 && offPeakKwhUsed <= 1000))
            {
                ChargeAmount = 76.00m + 40.00m;
            }
            else if (CustomerType == "I" && (peakKwhUsed <= 1000 && offPeakKwhUsed > 1000))
            {
                ChargeAmount = 76.00m + (40.00m + (0.028m * (offPeakKwhUsed - 1000)));
            }
            else if (CustomerType == "I" && (peakKwhUsed > 1000 && offPeakKwhUsed <= 1000))
            {
                ChargeAmount = (76.00m + (0.065m * (peakKwhUsed - 1000))) + 40.00m;
            }
            else if (CustomerType == "I" && (peakKwhUsed > 1000 && offPeakKwhUsed > 1000))
            {
                ChargeAmount = (76.00m + (0.065m * (peakKwhUsed - 1000))) + (40.00m + (0.028m * (offPeakKwhUsed - 1000)));
            }
            else
            {
                throw new InvalidOperationException("A valid customer type has not been assigned and the calculate charge method could not be executed");
            }
            return ChargeAmount;
        }

        /// <summary>
        /// Converts customer data to desired string format
        /// </summary>
        /// <returns> Displays customer data in a short string </returns>
        public override string ToString()
        {
            return ($"Account# {accountNo.ToString()}, {customerName}, {customerType}, {chargeAmount.ToString("c2")}");
        }

        /// <summary>
        /// Converts customer data to desired string format for customerDataListBox
        /// </summary>
        /// <returns> Displays customer data in customerDataListBox </returns>
        public string ToListBox()
        {
            return ($"{accountNo.ToString(),-8}  {customerName,-20}  {customerType,-1}    {chargeAmount.ToString("c2"),-10}");
        }

        /// <summary>
        /// Converts customer data to desired format for writing to Customer.txt file
        /// </summary>
        /// <returns> Customer data with </returns>
        public string ToFileLine()
        {
            return ($"{accountNo},{customerName},{customerType},{Math.Round(chargeAmount, 2)}");
        }
    }
}
