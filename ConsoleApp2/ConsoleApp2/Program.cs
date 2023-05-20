using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите х: ");
            int x = int.Parse(Console.ReadLine());
            double y = 3 * Pow(x, 6) - 6 * Pow(x, 2) - 7;
            Console.WriteLine($"y = {y}");
            Console.ReadKey();
        }
    }
}
