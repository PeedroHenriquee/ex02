using System;

namespace Mult
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o numero: ");

           

            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            
            if(a%b == 0 || b%a == 0)
            {
                Console.WriteLine("sao multiplos");
            }
            else
            {
                Console.WriteLine("nao sao multiplos");
            }
            

        }
    }
}
