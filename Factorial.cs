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

            Console.WriteLine("\t\t\t======== Calculation Of Sum And Avergae ======== ");
            Program p1 = new Program();
            double a, b;
            Console.Write("\nEnter First Value : ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\nEnter Second Value : ");
            b = double.Parse(Console.ReadLine());
           double c = p1.sum(a, b);
 
            Console.WriteLine("\nThe Sum  = {0} ",c );
            Console.WriteLine("\nThe Average = {0} ", c/2);




    Console.ReadLine();
        }
        
        public double sum(double a,double b)
        {

            double c = a + b;
            return c;

        }
    }
}
