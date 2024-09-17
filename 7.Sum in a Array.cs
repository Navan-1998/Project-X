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
            int[] intArray1 = new int[5];
            int sum = 0;
            Console.WriteLine("Enter 5 intergers");
            for (int i=0;i<intArray1.Length;i++)
            {
                Console.WriteLine($"Enter Integer {i}");
                intArray1 [i] =int.Parse(Console.ReadLine());
                sum = sum + intArray1[i];
            }
            Console.WriteLine($"Sum is= {sum}");
            Console.ReadKey();
        }
    }
}
