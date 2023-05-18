using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopZadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A1 = ");
            int A1 = int.Parse(Console.ReadLine());
            Console.Write("B1 = ");
            int B1 = int.Parse(Console.ReadLine());
            Console.Write("C1 = ");
            int C1 = int.Parse(Console.ReadLine());
            Console.Write("A2 = ");
            int A2 = int.Parse(Console.ReadLine());
            Console.Write("B2 = ");
            int B2 = int.Parse(Console.ReadLine());
            Console.Write("C2 = ");
            int C2 = int.Parse(Console.ReadLine());

            int D = A1 * B2 - A2 * B1;
            double x = (C1 * B2 - C2 * B1) / D;
            double y = (A1 * C2 - A2 * C1) / D;
            Console.WriteLine($"x = {x}\ny = {y}\nD = {D}");
        }
    }
}
