using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_001_POO
{
    public class Questao2
    {
        public void Q2()
        {
            Console.WriteLine("Digite o seu nome:");
            string Nome = Console.ReadLine();
            Console.WriteLine("Digite o seu sexo considerando F para Feminino e M para masculino:");
            string Sexo = Console.ReadLine();

            while (Sexo != "F" && Sexo != "M" && Sexo != "f" && Sexo != "m")
            {
                Console.WriteLine("Por favor digite o seu sexo considerando F para Feminino e M para masculino!");
                Sexo = Console.ReadLine();
            }

            Console.WriteLine("Digite o seu estado civil(Solteiro, Casado, Divorciado, Viuvo):");
            string EC = Console.ReadLine();

            while (EC != "Solteiro" && EC != "Casado" && EC != "Divorciado" && EC != "Viuvo")
            {
                Console.WriteLine("Por favor digite um estado civil válido!");
                EC =
                Console.ReadLine();
            }

            if (Sexo == "F" && EC == "Casado")
            {
                Console.WriteLine("Digite quantos anos você está casada:");
                int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine($"{Nome}, {Sexo}, {EC}");


            Console.ReadKey();

        }
    }
}