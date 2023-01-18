using System;
using System.Globalization;

namespace MediaNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((nota1 * 3.5) + (nota2 * 7.5)) / 11;

            Console.WriteLine("MEDIA DAS NOTAS = " + media.ToString("F5", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
