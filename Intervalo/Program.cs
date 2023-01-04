using System;
using System.Globalization;

namespace Intervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero");
           double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero >= 00.00 && numero <=25.00 )
            {
                Console.WriteLine("intervalo 0,25");
            }
            else if(numero >= 25.01 && numero <= 50.00 )
            {
                Console.WriteLine("intervalo 25,50");
            }
            else if (numero >= 50.01 && numero <= 75.00)
            {
                Console.WriteLine("intervalo 50,75");
            }
            else if (numero >= 75.01 && numero <=100)
            {
                Console.WriteLine("intervalo 75,100");
            }
            else
            {
                Console.WriteLine(  "fora de intervalo");
            }
        }
    }
}
