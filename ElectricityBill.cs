using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class ElectricityBill
    {
        public void printElectricityBill()
        {
            Console.WriteLine("Enter customer id:");
            int id=int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter customer name:");
            String name = Console.ReadLine();

            Console.WriteLine("Enter customer unit :");
            int unit = int.Parse(Console.ReadLine());

            double charge = 0;
            double surcharge = 0;
            double NetAmount = 0;

            if (unit <= 199)
            {
                charge = 1.20*unit;
             

            }
            else if(unit>=200 && unit<400)
            {
                charge = 1.50 * unit;
              
            }
            else if(unit>=400 && unit < 600)
            {
                charge = 1.80 * unit;
               
            }
            else if (unit >= 600)
            {
                charge = 2.00 * unit;
               
            }

            if (charge > 400)
            {
                surcharge = (charge * 15) / 100;
            }
           

            NetAmount = charge + surcharge;

            if (NetAmount < 100)
            {
                NetAmount = 100;
            }
            Console.WriteLine($"Customer IDNO : {id}");
            Console.WriteLine($"Customer Name :{name}");
            Console.WriteLine($"Unit Consumed : { unit}");
            Console.WriteLine($"Amount Charges @Rs. {unit} per unit : {charge}");
            Console.WriteLine($"Surchage Amount : {surcharge}");
            Console.WriteLine($"Net Amount Paid By the Customer : {NetAmount}");



        }
    }
}
