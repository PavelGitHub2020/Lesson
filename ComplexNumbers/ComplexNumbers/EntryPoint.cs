using System;

namespace ComplexNumbers
{
    class EntryPoint
    {
        //Реализовать класс для хранения комплексного числа.
        //Выполнить в нем перегрузку всех необходимых операторов
        //для успешной компиляции следующего фрагмента кода:
        //Complex z = new Complex(1, 1);
        //Complex z1;
        //z1 = z - (z * z * z - 1) / (3 * z* z);

        static void Main(string[] args)
        {
            Complex z = new Complex(4, 8);
            Complex z1;
            z1 = z - (((z * z * z) - 1) / (3 * z * z));

            Console.WriteLine(z1 == z);
            Console.WriteLine(z1 != z);

            Console.WriteLine(z1);
        }
    }
}
