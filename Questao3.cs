using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_001_POO
{
    public class Questao3
    {
        public void Q3()
        {
            Console.WriteLine("Digite um número:");
            int N = int.Parse(Console.ReadLine());

            if (N % 2 == 0)
            {
                Console.WriteLine($"O número {N} é par!");
            }
            else
            {
                Console.WriteLine($"O número {N} é ímpar!");
            }


            Console.ReadKey();

        }
    }
}