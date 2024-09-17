//Write a program to Add the sum of the Array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit;
            Console.WriteLine("Enter Limit");
            limit=Convert.ToInt32(Console.ReadLine());
            int[] intArray2 = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                intArray2[i]=int.Parse(Console.ReadLine());
            }
            int intInput;
            Console.WriteLine("Enter the Input");
            intInput=int.Parse(Console.ReadLine());
            for (int j = 0;j < limit; j++)
            {
                if (intArray2[j]==intInput)
                {
                    Console.WriteLine("Input is Found");
                    break;
                }
                if (intArray2[j] != intInput)
                {
                    Console.WriteLine(" Input NOT Found");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
