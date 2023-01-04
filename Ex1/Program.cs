using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero");
            int numero = int.Parse(Console.ReadLine());
            if(numero>=1)
            {
                Console.WriteLine("numero positivo");
            }
            else if(numero == 0)
            {
                Console.WriteLine("numero nao negativo");
            }
            else
            {
                Console.WriteLine("numero negativo");
            }
        }
    }
}
