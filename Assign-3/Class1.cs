using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assign_3
{
    class BankAccount
    {
        public int accounNumber;
        public string HolderName;
        int balance=0;

        public void deposit(int amt)
        {
            balance += amt;
            Console.WriteLine("Amount deposited :" + amt);
            Console.WriteLine("Your current balance is :" + balance);
        }
        public void withdraw(int amt)
        {
            balance -= amt;
            Console.WriteLine("Amount Withdrawed :" + amt);
            Console.WriteLine("Your current balance is :" + balance);
        }
        public void showInfo()
        {
            Console.WriteLine("Account Number is :" + accounNumber);
            Console.WriteLine("User Name is :" + HolderName);
            Console.WriteLine("Your current balance is :" + balance);
        }
    }
    internal class Class1
    {
        static void Main(string[] args)
        {
            //Emoloyee empOb = new Emoloyee();
            //empOb.Name = "Say My Name";
            //empOb.age = 23;
            //empOb.salary = 40000;
            //empOb.getoinfo();

            //BankAccount ob1=new BankAccount();
            //ob1.accounNumber= 1;
            //ob1.HolderName = "Say My Name";
            //ob1.showInfo();
            //ob1.deposit(1000);
            //ob1.withdraw(100);
            //ob1.showInfo();

            //q3MathHelper ob = new q3MathHelper();
            int[] arr = { 2, 3, 43, 5, 65, 6, 4 };
            q3MathHelper.Avg(arr);

        }
    }
    class Emoloyee
    {
        string name;
        public int age;
        public int salary;

        public string Name {
            get{
                return name;
            }
            set
            {
                if (value.Length > 5)
                    name = value;
                else
                    name="error: length must be greater than 5";
            }
        }
        public void getoinfo()
        {
            Console.WriteLine("Employee Name is :" + name);
            Console.WriteLine("Employee Age is :" + age);
            Console.WriteLine("Employee Salary is :" + salary + "rs.");
        }
    }
    //class BankAccount

    static class q3MathHelper
    {
        public static void Avg(int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum+= item;
            }
            float avg=sum/arr.Length;
            Console.WriteLine("The Average is :"+avg);
        }
    }




}
