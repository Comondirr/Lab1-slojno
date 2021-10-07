using System;

namespace Lab2_slojno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            double c = double.Parse(Console.ReadLine());
            double z = 1 / (b + c) * Math.Sqrt(b * c * (a + b + c) * (b + c - a));
            Console.WriteLine("z={0:F2}", z);
            double x = 1 / (a + c) * Math.Sqrt(a * c * (a + b + c) * (a + c - b));
            Console.WriteLine("x={0:F2}", x);
            double y = 1 / (a + b) * Math.Sqrt(a * b * (a + b + c) * (a + b - c));
            Console.WriteLine("y={0:F2}", y);


        }
    }
}
