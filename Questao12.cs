using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_001_POO
{
    public class Questao12
    {
        public void Q12()
        {
            double ME;
            double MA;
            double SN2;
            double TN3;

            Console.WriteLine("Digite o seu código de identificação:");
            int COD = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite sua nota referente a primeira prova:");
            double PN = double.Parse(Console.ReadLine());

            while (PN < 0 && PN > 100)
            {
                Console.WriteLine("Nota Inválida, por favor corrija!");
                PN = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite sua nota referente a segunda prova:");
            double SN = double.Parse(Console.ReadLine());

            while (SN < 0 && SN > 100)
            {
                Console.WriteLine("Nota Inválida, por favor corrija!");
                SN = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite sua nota referente a terceira prova:");
            double TN = double.Parse(Console.ReadLine());

            while (TN < 0 && TN > 100)
            {
                Console.WriteLine("Nota Inválida, por favor corrija!");
                TN = double.Parse(Console.ReadLine());
            }

            ME = PN + SN + TN / 3;
            SN2 = Math.Pow(SN, 2);
            TN3 = Math.Pow(TN, 3);
            MA = (PN + SN2 + TN3 + ME) / 7;

            Console.WriteLine();

            if (MA >= 90)
            {
                Console.WriteLine($"Código do aluno: {COD}");
                Console.WriteLine($"Nota da primeira Prova: {PN}");
                Console.WriteLine($"Nota da segunda prova: {SN}");
                Console.WriteLine($"Nota da terceira prova: {TN}");
                Console.WriteLine($"Média dos exercícios: {ME}");
                Console.WriteLine($"Média de aproveitamento: {MA}");
                Console.WriteLine("Conceito corresponente: A");
                Console.WriteLine("Situação: APROVADO");
            }

            else if (MA < 90 && MA >= 75)
            {
                Console.WriteLine($"Código do aluno: {COD}");
                Console.WriteLine($"Nota da primeira Prova: {PN}");
                Console.WriteLine($"Nota da segunda prova: {SN}");
                Console.WriteLine($"Nota da terceira prova: {TN}");
                Console.WriteLine($"Média dos exercícios: {ME}");
                Console.WriteLine($"Média de aproveitamento: {MA}");
                Console.WriteLine("Conceito corresponente: B");
                Console.WriteLine("Situação: APROVADO");
            }

            else if (MA < 75 && MA >= 60)
            {
                Console.WriteLine($"Código do aluno: {COD}");
                Console.WriteLine($"Nota da primeira Prova: {PN}");
                Console.WriteLine($"Nota da segunda prova: {SN}");
                Console.WriteLine($"Nota da terceira prova: {TN}");
                Console.WriteLine($"Média dos exercícios: {ME}");
                Console.WriteLine($"Média de aproveitamento: {MA}");
                Console.WriteLine("Conceito corresponente: C");
                Console.WriteLine("Situação: APROVADO");
            }

            else if (MA < 60 && MA >= 40)
            {
                Console.WriteLine($"Código do aluno: {COD}");
                Console.WriteLine($"Nota da primeira Prova: {PN}");
                Console.WriteLine($"Nota da segunda prova: {SN}");
                Console.WriteLine($"Nota da terceira prova: {TN}");
                Console.WriteLine($"Média dos exercícios: {ME}");
                Console.WriteLine($"Média de aproveitamento: {MA}");
                Console.WriteLine("Conceito corresponente: D");
                Console.WriteLine("Situação: REPROVADO");
            }

            else
            {
                Console.WriteLine($"Código do aluno: {COD}");
                Console.WriteLine($"Nota da primeira Prova: {PN}");
                Console.WriteLine($"Nota da segunda prova: {SN}");
                Console.WriteLine($"Nota da terceira prova: {TN}");
                Console.WriteLine($"Média dos exercícios: {ME}");
                Console.WriteLine($"Média de aproveitamento: {MA}");
                Console.WriteLine("Conceito corresponente: E");
                Console.WriteLine("Situação: REPROVADO");
            }


            Console.ReadKey();

        }
    }
}

