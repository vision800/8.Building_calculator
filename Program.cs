using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Building_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //convert string to int
            int num = Convert.ToInt32("45");
            Console.WriteLine(num+5);

            // ADD TWO INT NUMBERS
             int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1+num2);

            //add two double numbers
            double num3 = Convert.ToDouble(Console.ReadLine());
            double num4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num3 + num4);
        }
    }
}
