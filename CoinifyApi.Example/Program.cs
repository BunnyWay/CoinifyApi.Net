using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinifyApi;
using System.IO;

namespace CoinifyApi.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var coinify = new Coinify(
                "1wCeblZxlWGryO7WrXLnkfUU1XJMFhphiw7d1jG8ykj92AC+ZgzoqCjgYpqJzDKd",
                "EmefRmd9d4vw4xCgSXPWGIjBWWbAoak9HXxcDTvrUaz9L0nsspztN77eXytFF5r3",
                "https://api.sandbox.coinify.com/v3/");

            Console.ReadLine();
        }
    }
}
