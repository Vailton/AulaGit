using System;
using System.Globalization;

namespace AulaLogicaProgramacao
{
    class Program
    {
        static void Main(string[] args)


        {
            double pontoFlutuante = 5.12345;

            Console.Write(pontoFlutuante.ToString("F2",CultureInfo.InvariantCulture));

            //Console.WriteLine(texto);

            //Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
