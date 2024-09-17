//Reading and Printing
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array initialization
            int[] array1 = new int[5];
            //user input
            Console.WriteLine("Enter 5 Numbers");
            for (int i=0; i<array1.Length;i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            //Printing Numbers
            Console.WriteLine("Array Carries Numbers:");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
            Console.ReadKey();
        }
    }
}
