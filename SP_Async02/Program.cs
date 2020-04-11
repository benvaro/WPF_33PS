using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SP_Async02
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Int32.Parse(Console.ReadLine());
            FactorialAsync(num);
            Console.WriteLine("Some work in main...");

            Console.WriteLine("number = " + num * 100);
            Console.ReadLine();
        }

        static void Factorial(int param)
        {// factorial 5! = 1 * 2 * 3 * 4 * 5 
            int fact = 1;
            for (int i = 2; i <= param; i++)
            {
                fact *= i;
            }
            Thread.Sleep(3000);
            Console.WriteLine("Factorial = " + fact);
        }

        static async Task FactorialAsync(int param)
        {
            await Task.Run(() => Factorial(param));
        }
    }
}
