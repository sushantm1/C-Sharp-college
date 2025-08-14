using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3ConsoleApp1
{
    internal class vehicle
    {
        public string maker;
        public string model;
        public int year;
        vehicle(string maker, string model,int year)
        {
            this.maker = maker;
            this.model = model;
            this.year = year;
        }
    }
    internal class truck : vehicle
    {
        public void DisplayDetails()
        {
            Console.WriteLine($"the maker of the truck is : {maker}");
        }
    }
    internal class Class1
    {
    }
}
