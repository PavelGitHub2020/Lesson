using System;

namespace DataType
{
    class EntryPoint
    {
        //Разработать собственный структурный тип данных для хранения
        //целочисленных коэффициентов A и B линейного уравнения 
        //A * B + B * Y = 0. В классе реализовать статический метод 
        //Parce() , который принимает строку со значениями коэффициентов,
        //разделенных запятой или пробелом.
        static void Main(string[] args)
        {
            LinearEquation linearEquation = new LinearEquation(7, 5);
            LinearEquation linearEquation1 = new LinearEquation(4, 78);

            LinearEquation.Parce(linearEquation);
            LinearEquation.Parce(linearEquation1);
        }
    }
}
