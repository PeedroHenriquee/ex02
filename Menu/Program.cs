using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU");
            Console.WriteLine("CODIGO     ESPECIFICAÇÃO    PRECO");
            Console.WriteLine(" 1           X-SALADA       R$4.00");
            Console.WriteLine(" 2         CACHORRO QUENTE  R$4.50");
            Console.WriteLine(" 3            X-BACON       R$5.00");
            Console.WriteLine(" 4         TORRADA SIMPLES  R$2.00");
            Console.WriteLine(" 5         REFRIGERANTE     R$1.50");
            Console.WriteLine("DIGITE O CODIGO DO QUE DESEJA: ");

            string[] pedido = Console.ReadLine().Split(' ');
            int codigo = int.Parse(pedido[0]);
            int quantidade = int.Parse(pedido[1]);

           

            if (codigo == 1)
            {
                double final = quantidade * 4;
                Console.WriteLine($"Total {final}");
            }
            else if (codigo == 2)
            {
                double final = quantidade * 4.50;
                Console.WriteLine($"Total {final}");
            }
            else if (codigo == 3)
            {
                double final = quantidade * 5.00;
                Console.WriteLine($"Total {final}");

            }
            else if (codigo == 4)
            {
                double final = quantidade * 2.00;
                Console.WriteLine($"Total {final}");
            }
            else if(codigo== 5)
            {
                double final = quantidade * 1.50;
                Console.WriteLine($"Total {final}");
            }
            else
            {
                Console.WriteLine("NUMERO INVALIDO.");
            }
        }
    }
}
