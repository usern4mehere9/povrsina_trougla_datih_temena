using System;

namespace Povrsina_trougla_datih_temena
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3, a, b, c, s, P;

            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            x3 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());

            a = Math.Sqrt(((y3 - y2) * (y3 - y2)) + ((x3 - x2) * (x3 - x2)));
            b = Math.Sqrt(((y3 - y1) * (y3 - y1)) + ((x3 - x1) * (x3 - x1)));
            c = Math.Sqrt(((y2 - y1) * (y2 - y1)) + ((x2 - x1) * (x2 - x1)));

            s = (a + b + c) / 2;

            P = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine(Math.Round(P, 2));

        }
    }
}
