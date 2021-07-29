using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Assignment1
    {
            double total = 0;
            int units;
        
        public double calculateTotalPrice(int x)
        {
            //Console.WriteLine("Enter Number of Units: ");
            //units = Convert.ToInt32(Console.ReadLine());
            units = x;
            if (units <= 100)
            {
                total = units * 1.2;
            }
            else if (units > 100 && units <= 300)
            {
                units = units - 100;
                total = ((units * 2) + (100 * 1.2));
            }
            else if (units > 300)
            {
                units = units - 300;
                total = ((units * 3) + (200 * 2) + (100 * 1.2));
            }
            else
            {
                Console.WriteLine("Enter correct value");
            }

            Console.WriteLine("Total price for units is: " + total);
            System.Threading.Thread.Sleep(2000);
            return total;
        }
        

        static void Main(string[] args)
        {

            //Assignment1 a1 = new Assignment1();
            //a1.calculateTotalPrice();
            Console.WriteLine("HEllo User conflict!!");
            Console.WriteLine("Git done Change!!");
            Console.WriteLine("HEllo User!!");
            Console.WriteLine("Git Conflict!!");
            //Assignment2_3 a = new Assignment2_3();
            //a.calculateAverage();
            //a.displayTotal();
            //System.Threading.Thread.Sleep(5000);
        }

    }
}
