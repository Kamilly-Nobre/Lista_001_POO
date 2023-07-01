using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_001_POO
{
    public class Questao8
    {
        public void Q8()
        {
            Console.WriteLine("Digite o primeiro valor:");
            int P = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            int S = int.Parse(Console.ReadLine());

            while (P == S)
            {
                Console.WriteLine("Os números devem ser diferentes. Digite outro número!");
                S = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite o terceiro valor:");
            int T = int.Parse(Console.ReadLine());

            while (T == P || T == S)
            {

                Console.WriteLine("Os números devem ser diferentes. Digite outro número!");
                T = int.Parse(Console.ReadLine());
            }

            int[] R = { P, S, T };
            Array.Sort(R);
            Array.Reverse(R);

            if (P != S && P != T)
            {
                Console.WriteLine($"{R[0]} {R[1]} {R[2]}");
            }

            else
            {

                Console.WriteLine("Foram digitados valores iguais!");
            }


            Console.ReadKey();

        }
    }
}