using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_001_POO
{
    public class Questao5
    {
        public void Q5()
        {
            int R;

            Console.WriteLine("Digite um número:");
            int N = int.Parse(Console.ReadLine());

            if (N > 0)
            {
                R = N * 2;
                Console.WriteLine($"O dobro do valor positivo é: {R}");
            }

            else
            {
                R = N * 3;
                Console.WriteLine($"O triplo do valor negativo é: {R}");
            }


            Console.ReadKey();

        }
    }
}