using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A:");
            int A = int.Parse(Console.ReadLine());
            for(int i = 2; i <= 8; i *= 2)
            {
                Console.WriteLine($"А в {i} степени = {Pow(A,i)}");
            }
        }
    }
}
