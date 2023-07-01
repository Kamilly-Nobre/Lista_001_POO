using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_001_POO
{
    public class Questao11
    {
        public void Q11()
        {
            Console.Write("Digite o preço do produto: ");
            double Preco =
            double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Escolha a forma de pagamento:");
            Console.WriteLine();
            Console.WriteLine("1 - À vista em dinheiro ou cheque, recebe 10% de desconto");
            Console.WriteLine("2 - À vista no cartão de crédito, recebe 15% de desconto");
            Console.WriteLine("3 - Em duas vezes, preço normal de etiqueta sem juros");
            Console.WriteLine("4 - Em quatro vezes, preço normal de etiqueta mais juros de 10%");
            int FP = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double Total;

            switch (FP)
            {
                case 1:

                    Total = Preco * 0.9;
                    Console.WriteLine("Valor a ser pago: R$ " + Total);

                    break;

                case 2:

                    Total = Preco * 0.85;
                    Console.WriteLine("Valor a ser pago: R$ " + Total);

                    break;

                case 3:

                    Total = Preco;
                    Console.WriteLine("Valor da primeira parcela: R$ " + (Total / 2));
                    Console.WriteLine("Valor da segunda parcela: R$ " + (Total / 2));

                    break;

                case 4:

                    Total = Preco * 1.1;
                    Console.WriteLine("Valor da primeira parcela (com juros): R$ " + (Total / 4));
                    Console.WriteLine("Valor da segunda parcela (com juros): R$ " + (Total / 4));
                    Console.WriteLine("Valor da terceira parcela (com juros): R$ " + (Total / 4));
                    Console.WriteLine("Valor da quarta parcela (com juros): R$ " + (Total / 4));

                    break;

                default:

                    Console.WriteLine("Código de condição de pagamento inválido.");

                    break;
            }


            Console.ReadKey();

        }
    }
}