using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_001_POO
{
    public class Questao9
    {
        public void Q9()
        {
            double CalculoF;
            double CalculoM;

            Console.WriteLine("Digite a sua altura:");
            double Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu sexo(Feminino, Masculino):");
            string Sexo = Console.ReadLine();

            while (Sexo != "Feminino" && Sexo != "Masculino")
            {
                Console.WriteLine("Digite o seu sexo(Feminino, Masculino):");
                Console.ReadLine();
            }

            if (Sexo == "Feminino")
            {
                CalculoF = (62.1 * Altura) - 44.7;
                Console.WriteLine($"Seu peso ideal é {CalculoF}");
            }

            else
            {
                CalculoM = (72.7 * Altura) - 58.0;
                Console.WriteLine($"Seu peso ideal é {CalculoM}");
            }


            Console.ReadKey();

        }
    }
}