using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_001_POO
{
    public class Questao1
    {
        public void Q1()
        {
            Console.WriteLine("Digite o valor de A:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C:");
            int C = int.Parse(Console.ReadLine());

            int Soma = A + B;

            if (Soma < C)
            {
                Console.WriteLine("A soma de A e B é menor que C!");
            }

            else
            {
                Console.WriteLine("A soma de A e B NÃO é menor que C!");
            }


            Console.ReadKey();

        }
    }
}

