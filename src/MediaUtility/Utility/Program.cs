using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary;

namespace Utility
{
    class Program
    {
        static void Main(string[] args)
        {
            var adder = new Adder();
            var a = 2;
            var b = 4;
            Console.WriteLine($"{a} + {b} = {adder.Sum(a, b)}");

        }
    }
}
