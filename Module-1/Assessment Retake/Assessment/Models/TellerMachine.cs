using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Models
{
    public class TellerMachine
    {
        public string Manufacturer { get; set; }
        public double Deposits { get; set; }
        public double Withdrawals { get; set; }
        public double Balance { get; set; }

        public TellerMachine(string manufacturer, double deposits, double withdrawals)
        {
            this.Manufacturer = manufacturer;
            this.Deposits = deposits;
            this.Withdrawals = withdrawals;
            this.Balance = deposits - withdrawals;
        }
        public TellerMachine()
        {

        }
        public override string ToString()
        {
            return $"ATM - {this.Manufacturer} - {this.Balance}";
        }
        public bool IsValid(string carNumber)
        {
            int length = carNumber.Length;

            string[] array = new string[] { carNumber };
        
            
            if (carNumber.StartsWith("5") && length==16)
            {
                return true;
            }
            else if (carNumber.StartsWith("4") && (length == 13 || length==16))
            {
                return true;
            }
            else if (carNumber.StartsWith("34") || carNumber.StartsWith("37"))
            {
                return true;
            }
            else
            
                return false;
            
        }
    }
}
