using System;
using System.Collections.Generic;
using System.Text;

namespace DataType
{
    class LinearEquation
    {
        public Coefficient coefficient;

        public LinearEquation(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                Console.WriteLine("Any number is the roof of this eqution!");
            }
            if (a == 0 && b != 0)
            {
                Console.WriteLine("The original eqution has no roots!");
                throw new ArgumentException(nameof(b));
            }

            coefficient.A = a;
            coefficient.B = b;
        }

        public static void Parce(LinearEquation l)
        {
            string a = $"{l.coefficient.A} * {l.coefficient.B} + {l.coefficient.B} * Y = 0";

            char[] charSeparators = new char[] { ',' };

            string[] result;

            result = a.Split(charSeparators, StringSplitOptions.None);
            Show(result);
        }

        public static void Show(string[] s)
        {
            foreach (string en in s)
            {
                Console.WriteLine(en);
            }
        }
    }
}
