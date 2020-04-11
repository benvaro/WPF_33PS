using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SP_Async04
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string address = "http://www.gutenberg.org/cache/epub/16668/pg16668.txt";
            using (WebClient client = new WebClient())
            {
                byte[] book = await client.DownloadDataTaskAsync(address);
                using (FileStream stream = new FileStream("book.txt", FileMode.Create, FileAccess.Write))
                {
                    await stream.WriteAsync(book, 0, book.Length);
                }
            }
            Console.WriteLine("Write completed!");
            Console.ReadLine();
        }
    }
}
