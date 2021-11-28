using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer2
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux1 = 0, aux2 = 1, n = 0, seq = aux1 + aux2;

            Console.Write("Digite um número: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("\nSequência:\n" + aux1 + " -> " + aux2 + " -> " + seq);


            for (int i = 0; i < 1000; i++)
            {
                aux1 = aux2;

                aux2 = seq;

                seq = aux1 + aux2;

                Console.Write(" -> " + seq);

                if (seq == n)
                {
                    Console.WriteLine("\n\nO número " + n + " existe na sequência!");
                    break;
                }
                if (seq > n)
                {
                    Console.WriteLine("\n\nO número " + n + " não existe na sequência!");
                    break;
                }

            }

            Console.ReadLine();
        }
    }
}
