using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace Fractions
{
    //Разработать класс Fraction, представляющий простую дробь, в классе предусмотреть два поля:
    //числитель и знаменатель дроби. Выполнить перегрузку следующих операторов: 
    //+, -, *, /, ==, !=, <, >, true, false.  Арифметические действия и сравнения 
    //выполняются в соответсвии с правилами работы с дробями. Оператор true 
    //возвращает true если дробь правильная(числитель меньше знаменателя), 
    //оператор false возвращает true если дробь неправильная(числитель больше знаменателя).
    //Выполнить перегрузку операторов, необходимых для успешной компиляции 
    //следующего фрагмента кода:
    //Fraction f = new Fraction(3, 4);
    //int a = 10;
    //Fraction f1 = f * a;
    //Fraction f2 = a * f;
    //double d = 1.5;
    //Fraction f3 =f + d;

    class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int num, int denom)
        {
            if (denom == 0)
            {
                throw new ArgumentException("Denom cannot be zero", nameof(denom));
            }

            numerator = num;
            denominator = denom;
        }

        public static Fraction operator +(Fraction c, Fraction c1)
        {
            return new Fraction(c.numerator * c1.denominator + c1.numerator * c.denominator, 
                                c.denominator * c1.denominator);
        }

        public static Fraction operator -(Fraction c, Fraction c1)
        {
            return new Fraction(c.numerator * c1.denominator - c.denominator * c1.numerator,
                                c.denominator * c1.denominator);
        }

        public static Fraction operator *(Fraction c, Fraction c1)
        {
            return new Fraction(c.numerator * c1.numerator, c.denominator * c1.denominator);
        }

        public static Fraction operator /(Fraction c, Fraction c1)
        {
            if (c1.numerator == 0)
            {
                throw new DivideByZeroException();
            }

            return new Fraction(c.numerator * c1.denominator, c.denominator * c1.numerator);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            return IsEqual((Fraction) obj);
        }

        public bool Equals(Fraction fraction)
        {
            if (Object.ReferenceEquals(null,fraction))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, fraction))
            {
                return true;
            }

            return IsEqual(fraction);
        }

        private bool IsEqual(Fraction fraction)
        {
            return (fraction != null)
                && (numerator == fraction.numerator)
                && (denominator == fraction.denominator);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                const int HashingBase = (int)2166136261;
                const int HashingMultiplier = 16777619;

                int hash = HashingBase;
                hash = (hash * HashingMultiplier) ^ (!Object.ReferenceEquals(null, numerator) ? numerator.GetHashCode() : 0);
                hash = (hash * HashingMultiplier) ^ (!Object.ReferenceEquals(null, denominator) ? denominator.GetHashCode() : 0);
                return hash;
            }
        }

        public static bool operator ==(Fraction c, Fraction c1)
        {
            return (Object.ReferenceEquals(c, c1) || c.Equals(c1));
        }

        public static bool operator !=(Fraction c, Fraction c1)
        {
            return !(Object.ReferenceEquals(c, c1) || c.Equals(c1));
        }

        public static bool operator >(Fraction c, Fraction c1)
        {
            return ((c.numerator > c1.numerator) && (c.denominator > c1.denominator)) ||
                   ((c.numerator > c1.numerator) && (c.denominator == c1.denominator)) ||
                   ((c.numerator == c1.numerator) && (c.denominator > c1.denominator));
        }

        public static bool operator <(Fraction c, Fraction c1)
        {
            return ((c.numerator < c1.numerator) && (c.denominator < c1.denominator)) ||
                   ((c.numerator < c1.numerator) && (c.denominator == c1.denominator)) ||
                   ((c.numerator == c1.numerator) && (c.denominator < c1.denominator));
        }

        public static bool operator true(Fraction c)
        {
            if (c.numerator < c.denominator)
            {
                return true;
            }

            return false;
        }

        public static bool operator false(Fraction c)
        {
            if (c.numerator > c.denominator)
            {
                return true;
            }

            return false;
        }

        public static Fraction operator *(Fraction c, int number)
        {
            return new Fraction(c.numerator * number, c.denominator);
        }

        public static Fraction operator *(int number, Fraction c)
        {
            return new Fraction(c.numerator * number, c.denominator);
        }

        public static Fraction operator +(Fraction c, double number)
        {
            double w = number * 10;
            int q = (int)w;
            return new Fraction(c.numerator + (int)number, c.denominator + q);
        }

        public override string ToString()
        {
            return $"Numerator = {numerator}, Denominator = {denominator}";
        }
    }
}
