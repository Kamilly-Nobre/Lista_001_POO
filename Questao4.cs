using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_001_POO
{
    public class Questao4
    {
        public void Q4()
        {
            int C;

            Console.WriteLine("Digite o valor de A:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            int B = int.Parse(Console.ReadLine());

            if (A == B)
            {
                C = A + B;
                Console.WriteLine($"A e B são iguais e a soma dos dois é: {C}");
            }

            else
            {
                C = A * B;
                Console.WriteLine($"A e B são diferentes e a multiplicação é: {C}");
            }


            Console.ReadKey();

        }
    }
}