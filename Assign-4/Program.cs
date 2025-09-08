using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account= new BankAccount();
            account.Deposit(1000);
            Console.ReadLine();

        }

    }
    class BankAccount
    {
        int balance;
        
        public void Deposit(int amount) {
            this.balance += amount;
            Console.WriteLine("this amount has been deposited : "+ amount);
            Console.WriteLine("so the current balance in your account is : " + balance);
        }

    }
}