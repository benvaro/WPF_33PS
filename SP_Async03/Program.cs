using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SP_Async03
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId); // 1
            Task task = new Task(PrintHello, "task1");
            task.Start();
            task.Wait();
            Task task2 = new Task(() => PrintHello("task2"));
            task2.Start();

            Task task3 = new Task(delegate (object state)
            {
                PrintHello("Task3");
            }, "task3");
            task3.Start();

            Task task4 = Task.Factory.StartNew(PrintHello, "task4");

            Task<int> taskSum = new Task<int>((object obj) =>
            {
                int sum = 0;
                for (int i = 1; i <= (int)obj; i++)
                {
                    sum += i;
                }
                Console.WriteLine("Res = " + sum); // 1
                return sum;
            }, 10);
            taskSum.Start();

            Console.WriteLine("Suma = {0}", taskSum.Result); //2
            int obj2 = 10;
            int result = await Task<int>.Run(delegate
            {
                int sum = 0;
                for (int i = 1; i <= obj2; i++)
                {
                    sum += i;
                }
                Console.WriteLine("Res = " + sum); // 1
                return sum;
            });

            Console.WriteLine("Result = " + result);

            

            task2.Wait();
            Task.WaitAll(task3, task4);
            Console.WriteLine("Main finished work"); //3
            Console.ReadLine();
        }

        static void PrintHello(object state)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Hello task!!! " + state);
        }
    }
}
