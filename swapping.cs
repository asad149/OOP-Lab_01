using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wasiq_Sir
{
    class vowels
    {
       public char[] a = new char[100];
       public int i, count;
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t\t\t======== Finding Vowels of Given Name ======== ");
            vowels v = new vowels();
            
            
            for (v.i = 0; v.i <= 10; v.i++)
            {

                v.a[v.i] = Console.ReadKey().KeyChar;
                

                if (v.a[v.i] == 'a' || v.a[v.i] == 'e' || v.a[v.i] == 'i' || v.a[v.i] == 'o' || v.a[v.i] == 'u')
                {
                    v.count++;
                }
            }
            Console.WriteLine("Vowels Present in Given Name" +v.count);


          
    Console.ReadLine();

        }
        
        
    }
}
