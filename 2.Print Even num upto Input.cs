//Print even numbers upto user input
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Print_Even_Numbers_Upto_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Enter Upto Which Even Numbers are Needed:");
            input = Convert.ToInt32(Console.ReadLine());
            int a;
            Console.WriteLine($"Even Numbers upto {input} is:");
            for (int i = 1;i<=input;i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
            Console.ReadKey();
        }
    }
}
