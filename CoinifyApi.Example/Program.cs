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
                "JcAAmbTH6ZLU4cO4Tlp1ZSZ5fggx3s8+lvPSj/lZeLHqY8p6u881onEINJ2DtNtv", 
                "mgql917MO1Jej7nQ2cijcYPgSdHeaYQMAvfzXcHyfDmoVhd/tqugDoUpT5Mj0ztl");

            Console.ReadLine();
        }
    }
}
