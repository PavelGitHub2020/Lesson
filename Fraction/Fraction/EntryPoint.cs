using System;

namespace Fractions
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(3, 4);
            int a = 10;
            Fraction f1 = f * a;
            Fraction f2 = a * f;
            double d = 1.5;
            Fraction f3 = f + d;

            Console.WriteLine("f1: " +f1);

            Console.WriteLine("f2: " + f2);

            Console.WriteLine("f3: " + f3);

            Console.WriteLine($"f > f1 {f > f1}");
            Console.WriteLine($"f < f1 {f < f1}");
            Console.WriteLine($"f == f1 {f == f1}");
            Console.WriteLine($"f != f1 {f != f1}");
            Console.WriteLine($"f + f1 = {f + f1}");
            Console.WriteLine($"f - f1 = {f - f1}");
            Console.WriteLine($"f * f1 = {f * f1}");
            Console.WriteLine($"f / f1 = {f / f1}");

            Fraction[] fractions = { f, f2, f3 };

            for(int i = 0; i < fractions.Length; i++)
            {
                if(fractions[i])
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
