using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _2LinaerEquations
{
    //Разработать метод для решения системы 2 линейных уравнений:
    //A1 * X + B1 * Y = 0
    //A2 * X + B2 * Y = 0
    //Метод с помощью выходных параметров должен возвращать найденное
    //решение или ошибку, если решение не существует.
    public class SolvinEquations
    {
        private float A1;
        private float B1;
        private float A2;
        private float B2;
        private float C1;
        private float C2;
        private float X;
        private float Y;
        private float delta;

        public SolvinEquations(float a1, float b1, float a2, float b2, float c1, float c2)
        {
            if ((a1 == 0 && b1 == 0) || (a2 == 0 && b2 == 0))
            {
                Console.WriteLine("One of the coeficients must not be equal to zero!");
                throw new ArgumentNullException(nameof(a1));
            }

            A1 = a1;
            B1 = b1;
            A2 = a2;
            B2 = b2;
            C1 = c1;
            C2 = c2;
        }

        public  void Decision(SolvinEquations s)
        {
            Console.WriteLine(s);

            if (s.C1 == 0 && s.C2 == 0)
            {
                Console.WriteLine("X = 0\nY = 0");
                return;
            }

            delta = s.A1 * s.B2 - s.B1 * s.A2;
            X = (s.C1 * s.B2 - s.C2 * s.B1) / delta;
            Y = (s.C2 * s.A1 - s.C1 * s.A2) / delta;

            Console.WriteLine("Delta = " + delta);
            Console.WriteLine("X = " + X);
            Console.WriteLine("Y = " + Y);
        }

        public override string ToString()
        {
            return $"{A1} * X + {B1} * Y = {C1} \n" +
                   $"{A2} * X + {B2} * Y = {C2} \n";
        }


    }
}
