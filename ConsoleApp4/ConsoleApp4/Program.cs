using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            int x = a / 12;
            double b = Exp(-a * x);
            double y = 1 - Exp(-a * x) * Sin(a * x + b);
            Console.WriteLine($"y = {y:f3}");
            Console.ReadKey();
        }
    }
}
