using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wasiq_Sir
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t\t\t======== Swapping of Numbers ======== ");

            Program p1 = new Program();

            p1.swap();
    Console.ReadLine();
        }
        
        public void swap()
        {
            double a, b;
            Console.Write("\nEnter First Value : ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\nEnter Second Value : ");
            b = double.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("\n\t\t\t======== Values After Swapping ======== ");


            Console.WriteLine("\nFirst Value : {0}",a);
            Console.WriteLine("\nSecond Value : {0} ", b);

            
        }
    }
}
