using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_001_POO
{
    public class Questao10
    {
        public void Q10()
        {
            double IMC;

            Console.WriteLine("Digite o seu peso:");
            double Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua altura:");
            double Altura = double.Parse(Console.ReadLine());

            double A2 = Math.Pow(Altura, 2);
            IMC = Peso / A2;

            Console.WriteLine($"{IMC}");

            if (IMC < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso!");
            }

            else if (IMC >= 18.5 && IMC <= 25)
            {
                Console.WriteLine("Você está no peso ideal!");
            }

            else if (IMC > 25 && IMC < 30)
            {
                Console.WriteLine("Você está acima do peso!");
            }

            else
            {
                Console.WriteLine("Você está com obesidade!");
            }


            Console.ReadKey();

        }
    }
}