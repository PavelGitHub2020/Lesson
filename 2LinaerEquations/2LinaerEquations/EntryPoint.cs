using System;

namespace _2LinaerEquations
{
    class EntryPoint
    {
        //Разработать метод для решения системы 2 линейных уравнений:
        //A1 * X + B1 * Y = 0
        //A2 * X + B2 * Y = 0
        //Метод с помощью выходных параметров должен возвращать найденное
        //решение или ошибку, если решение не существует.
        static void Main(string[] args)
        {
            SolvinEquations solvinEquations = new SolvinEquations(2, 7, 7, 4, 9, 13);
            solvinEquations.Decision(solvinEquations);
        }
    }
}
