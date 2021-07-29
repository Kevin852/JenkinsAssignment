using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{

    class Assingnment4
    {
        int accountNo;
        double accountBalance;
        string accountPassword;
        static string bankName;

        public int AccountNo { get => accountNo; set => accountNo = value; }
        public double AccountBalance { get => accountBalance; set => accountBalance = value; }
        public string AccountPassword { get => accountPassword; set => accountPassword = value; }
        public static string BankName { get => bankName; set => bankName = value; }
        
        static Assingnment4()
        {
            bankName = "ABC Bank";
        }
        public Assingnment4()
        {
            accountNo = 0;
            accountBalance = 0.0;
            accountPassword = null;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountNo"></param>
        /// <param name="accountBalance"></param>
        /// <param name="accountPassword"></param>
        public Assingnment4(int accountNo, double accountBalance, string accountPassword)
        {
            AccountNo = accountNo;
            AccountBalance = accountBalance;
            AccountPassword = accountPassword;
        }

        public void displayAccount()
        {
            Console.WriteLine("Bank Name: "+BankName+"\nAccount Number: "+AccountNo+"\nAccount Balance: "+AccountBalance+"\nAccount Password: "+AccountPassword);
        }
        /*static void Main(string[] args)
        {
            Assingnment4 a = new Assingnment4(101,50000,"asd");
            a.displayAccount();
            System.Threading.Thread.Sleep(5000);
        }
        */
    }
}
