using System;

namespace Comparacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("que horas sao: ");
            int hora = int.Parse(Console.ReadLine());

            if (hora<12)
            {
                Console.WriteLine("bom dia");
            }
            else if (hora < 18)
            {
                Console.WriteLine("boa tade");
            }
            else
            {
                Console.WriteLine("boa noite");
            }
        }
    }
}
