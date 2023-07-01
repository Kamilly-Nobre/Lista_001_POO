using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_001_POO
{
    public class Questao6
    {
        public void Q6()
        {
            Console.WriteLine("------------------ Verificação de valores ------------------");
            Console.WriteLine();
            Console.WriteLine("Será verdadeiro se o primeiro valor for maior que o segundo.");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Digite o primeiro valor: ");
            int P = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            int S = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(P > S ? "Verdadeiro" : "Falso");


            Console.ReadKey();

        }
    }
}