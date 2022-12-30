using System;
namespace For1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значение х=");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение n=");
            byte n = byte.Parse(Console.ReadLine());
            double s = 0;
            for (int k = 1; k <= n; k++)
                s += Math.Pow(x, k) * Math.Sin(k * (Math.PI / 4));
            Console.WriteLine("s = {0}", s);
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}