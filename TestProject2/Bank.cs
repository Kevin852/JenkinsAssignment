using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    
    public class Bank
    {
        static int accNo=101;
        double balance=5000;
        string name="Kevin";

        public static int AccNo { get => accNo; set => accNo = value; }
        public double Balance { get => balance; set => balance = value; }
        public string Name { get => name; set => name = value; }
        public double deposit(double amt)
        {
            balance = balance + amt;
            return balance;
        }
        public double withdraw(double amt)
        {
            balance = balance - amt;
            return balance;
        }
    }
    
}
