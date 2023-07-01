using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_001_POO
{
    public class Questao7
    {
        public void Q7()
        {
            int R;

            Console.WriteLine("Digite um número:");
            int N = int.Parse(Console.ReadLine());

            if (N % 2 == 0)
            {
                R = N + 5;
                Console.WriteLine($"O número é par e a soma é: {R}");
            }

            else
            {
                R = N + 8;
                Console.WriteLine($"O número é ímpar e a soma é: {R}");
            }


            Console.ReadKey();

        }
    }
}