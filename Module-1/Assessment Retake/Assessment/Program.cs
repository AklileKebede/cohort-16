using System;
using System.Collections.Generic;
using System.IO;
using Assessment.Models;

namespace Assessment
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            // TODO: Create instances of your object here and call methods.
           
            TellerMachine teller1 = new TellerMachine("Manufacturer1", 100.00, 50.00);
            TellerMachine teller2 = new TellerMachine("Manufacturer2", 70.00, 100.00);
            TellerMachine teller3 = new TellerMachine("Manufacturer3", 50.00, 50.00);
            List<TellerMachine> list = new List<TellerMachine>();
            list.Add(teller1);
            list.Add(teller2);
            list.Add(teller3);
            
            foreach (TellerMachine teller in list) 
            {
                Console.WriteLine(teller.ToString());

            }
        }
    }
}
