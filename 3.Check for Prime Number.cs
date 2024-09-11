using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CheckforPrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int n = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            for (int i = 2; i <= n; i++)
            {
                if (n % 2 == 0)
                {
                    flag = true;
                    Console.WriteLine($"{n} is not Prime");
                    break;
                }
            }
            if (flag = false)
            {
                Console.WriteLine($"{n} is PRIME");
            }
            else
            {
                Console.WriteLine($"{n} is not prime");
            }
            Console.ReadKey();
        }
    }
}
