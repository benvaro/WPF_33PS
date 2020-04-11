using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SP_Async01
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DoWorkAsync();
            Console.WriteLine("Main works");

            //Task<string> result = DoWorkStringAsync();
            //Console.WriteLine("Result = " + result.Result); // зупиняє викликаючий потік, поки таск не завершить роботу

            string result = await DoWorkStringAsync();
            Console.WriteLine("Result = " + result);
            Console.ReadLine();
        }

        static void DoWork()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Work in do work...");
        }

        // void == Task
        static async Task DoWorkAsync()
        {
            //Task
            Console.WriteLine("Some code in async method");
        //    await Task.Run(DoWork);
            await Task.Run(() => DoWork());
            Console.WriteLine("DoWorkAsync finished work...");
        }

        static async Task<string> DoWorkStringAsync()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(2000);
                return "Do work finished";
            });
        }
    }
}
