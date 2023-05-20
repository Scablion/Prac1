using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp1
{
    class Program
    {
        static double Gipotenuza(int a, int b)
        {
            double c = Sqrt(Pow(a,2)+ Pow(b,2));
            return c;
        }

        static double Pirimetr(int a, int b, double c)
        {
            double p = a + b + c;
            return p;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите первый катет треугольника:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второй катет треугольника:");
            int b = int.Parse(Console.ReadLine());
            double c = Gipotenuza(a, b);
            double p = Pirimetr(a, b, c);
            Console.WriteLine($"Пириметр = {p:f3} \nГипотенуза = {c:f3}");
            Console.ReadKey();
        }
    }
}
