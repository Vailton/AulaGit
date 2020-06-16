using System;
using System.Globalization;

namespace PROJETO_TECNOLOGIA_UNICA
{
    class Program
    {
        static void Main(string[] args)
        {
           double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double soma = n1 + n2;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
