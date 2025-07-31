using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_2
{   class prgms
    {
       public void p1()
        {
            Console.WriteLine("This is the 1st program :");
            Console.Write("Please enter Number of Transactions :");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Please enter Transactions amount : ");
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine("this is the total amount : " + sum);
        }
        public void p2()
        {
            Console.WriteLine("This is the 2nd program :");
            Console.Write("Please enter Number of Transactions :");
            int n = int.Parse(Console.ReadLine());
            float[] arr = new float[n];
            Console.WriteLine("Please enter Transactions amount : ");
            float sum = 0;
            for (int i = 0; i<n; i++)
            {
                arr[i] = float.Parse(Console.ReadLine());
                sum += arr[i];
            }
            float avg = sum / n;
            Console.WriteLine($"this is the average : {avg}");
        }
        public void p3()
        {
            Console.WriteLine("This is the 3rd program to find max value in array:");
            Console.Write("Please enter Number of Transactions :");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Please enter Transactions amounts : ");
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                max = max > arr[i] ? max : arr[i];
            }
            Console.WriteLine($"this is the maximum amount : {max}");
        }
        public void p4()
        {
            Console.WriteLine("This is the 4th program to find max value in array:");
            Console.Write("Please enter Number of Transactions :");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Please enter Transactions amounts : ");
            int male = 0;
            int female = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                male = arr[i] % 2 == 0 ? male++ : female++;
            }
            Console.WriteLine($"this is the male count : {male}");
            Console.WriteLine($"this is the feale count : {female}");
        }
        public void p5()
        {
            Console.WriteLine("This is the 5th program to find max value in array:");
            Console.Write("Please enter Number of Transactions :");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Please enter history in integer : ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("these is the recent search history :");
            for (int i = n-1; i >= 0; i--)
            {
                Console.WriteLine($"{arr[i]}");
            }
        }
        public void p6()
        {
            Console.WriteLine("This is the 6th program which multiply emelents with a given factor.");
            Console.Write("Please enter the factor :");
            int factor = int.Parse(Console.ReadLine());
            Console.Write("Please enter Number of Transactions :");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Please enter the records : ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()) *factor;
            }
            Console.WriteLine("these is the recent search history :");
            for (int i = 0; i<n; i++)
            {
                Console.WriteLine($"{arr[i]}");
            }
        }
        public void p7()
        {
            Console.WriteLine("This is the 7th program which find the index of a element.");
            Console.Write("Please enter Number of Transactions :");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Please enter the records : ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Please enter the factor :");
            int element = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == element) { Console.WriteLine($"the index of the element is {i}"); break; }
            }
        }
        public void p8()
        {
            Console.WriteLine("This is the 7th program which find the index of a element.");
            Console.Write("Please enter Number of Transactions :");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Please enter the records : ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Please enter the factor :");
            int element = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == element) { Console.WriteLine($"the index of the element is {i}"); break; }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            prgms ob1 = new prgms();
            //ob1.p1();
            ob1.p7();
        }
    }
}
