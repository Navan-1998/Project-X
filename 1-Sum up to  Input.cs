//1.Sum of Numbers upto User Input
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            int sum = 0;
            Console.WriteLine("Enter a Number Upto which addition is needed:");
            input=Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<=input;i++)
            {
                sum=sum+i;
            }
            Console.WriteLine($"Sum upto the Number{input} is:{sum}");
            Console.ReadKey();
        }
    }
}
