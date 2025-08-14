using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3ConsoleApp1
{ 
    internal class Program
    {
        private string Username;
        private string Password;
        private string Email;

        public void set()
        {
            Console.WriteLine("Please enter username");
            this.Username= Console.ReadLine();
            Console.WriteLine("Enter your password");
            this.Password= Console.ReadLine();
            while (this.Password.Length < 6)
            {
                Console.WriteLine("enter at leas password of size 6 0r above");
                this.Password = Console.ReadLine();
            }
            Console.WriteLine("Enter your email");
            this.Email= Console.ReadLine();
            while (!this.Email.Contains("@")){
                Console.WriteLine("please enter a valid email");
                this.Email= Console.ReadLine();
            }
        }

        public void get()
        {
            Console.WriteLine($"Your username is : {this.Username}");
            Console.WriteLine($"Your Password is : {this.Password}");
            Console.WriteLine($"Your email is : {this.Email}");

        }

        static void Main(string[] args)
        {
            Program ob1= new Program();
            ob1.set();
            ob1.get();
        }
    }
}
