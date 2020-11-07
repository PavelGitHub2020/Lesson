using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ComplexNumbers
{
    class Complex
    {
        private int realUnit;
        private int imaginaryUnit;

        public Complex(int real, int imaginary)
        {
            if (real == 0)
            {
                throw new ArgumentException("Real cannot be zero", nameof(real));
            }
            if (imaginary == 0)
            {
                throw new ArgumentException("Imaginary cannot be zero", nameof(imaginary));
            }

            realUnit = real;
            imaginaryUnit = imaginary;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Complex c, Complex c1)
        {
            return (c.realUnit == c1.realUnit) && (c.imaginaryUnit == c1.imaginaryUnit);
        }

        public static bool operator !=(Complex c, Complex c1)
        {
            return (c.realUnit != c1.realUnit) && (c.imaginaryUnit != c1.imaginaryUnit);
        }

        public static Complex operator +(Complex c, Complex c1)
        {
            return new Complex(( c.realUnit + c1.realUnit),(c.imaginaryUnit + c1.imaginaryUnit));
        }

        public static Complex operator -(Complex c, Complex c1)
        {
            return new Complex((c.realUnit - c1.realUnit), (c.imaginaryUnit - c1.imaginaryUnit));
        }

        public static Complex operator *(Complex c, Complex c1)
        {
            return new Complex(((c.realUnit * c1.realUnit) - (c.imaginaryUnit * c1.imaginaryUnit)) ,
                   ((c.imaginaryUnit * c1.realUnit) + (c.realUnit * c1.imaginaryUnit)));
        }

        public static Complex operator /(Complex c, Complex c1)
        {
            if (c1.realUnit == 0 || c1.imaginaryUnit == 0)
            {
                throw new DivideByZeroException();
            }

            return new Complex(((c.realUnit * c1.realUnit) + (c.imaginaryUnit * c1.imaginaryUnit)) / 
                               ((c1.realUnit * c1.realUnit) + (c1.imaginaryUnit * c1.imaginaryUnit)) , 
                               ((c.imaginaryUnit * c1.realUnit) - (c.realUnit * c1.imaginaryUnit)) /
                               (c1.realUnit * c1.realUnit) + (c1.imaginaryUnit * c1.imaginaryUnit));
        }

        public static Complex operator -(Complex c, int number)
        {
            return new Complex(c.realUnit - number, c.imaginaryUnit - number);
        }

        public static Complex operator *(int number, Complex c)
        {
            return new Complex(number * c.realUnit, number * c.imaginaryUnit);
        }

        public override string ToString()
        {
            return $"{realUnit} + {imaginaryUnit}i";
        }
    }
}
