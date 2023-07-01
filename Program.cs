namespace Lista_001_POO
{
    class Lista
    {
        static void Main(string[] args)
        {
            do
            {

                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("1) Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.");
                Console.WriteLine();
                Console.WriteLine("2) Faça um algoritmo que leia o nome, o sexo e o estado civil de uma pessoa. Caso sexo seja “F” e estado civil seja “CASADA”, solicitar o tempo de casada (anos).");
                Console.WriteLine();
                Console.WriteLine("3) Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.");
                Console.WriteLine();
                Console.WriteLine("4) Faça um algoritmo que leia dois valores inteiros A e B se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.");
                Console.WriteLine();
                Console.WriteLine("5) Encontrar o dobro de um número caso ele seja positivo e o seu triplo caso seja negativo, imprimindo o resultado.");
                Console.WriteLine();
                Console.WriteLine("6) Escreva um algoritmo que lê dois valores booleanos (lógicos) e então determina se ambos são VERDADEIROS ou FALSOS.");
                Console.WriteLine();
                Console.WriteLine("7) Faça um algoritmo que leia uma variável e some 5, caso seja par ou some 8, caso seja ímpar, imprimir o resultado desta operação.");
                Console.WriteLine();
                Console.WriteLine("8) Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.");
                Console.WriteLine();
                Console.WriteLine("9) Tendo como dados de entrada a altura e o sexo de uma pessoa, construa um algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas:\r\n● para homens: (72.7 * h) – 58;\r\n● para mulheres: (62.1 * h) – 44.7.");
                Console.WriteLine();
                Console.WriteLine("10) O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre a condição de peso de uma pessoa adulta.\r\nA fórmula é: IMC = peso / ( altura )2\r\nElabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de acordo com a tabela abaixo.\r\nIMC em adultos Condição\r\nAbaixo de 18,5 Abaixo do peso\r\nEntre 18,5 e 25 Peso normal\r\nEntre 25 e 30 Acima do peso\r\nAcima de 30 obeso");
                Console.WriteLine();
                Console.WriteLine("11) Elabore um algoritmo que calcule o que deve ser pago por um produto, considerando o preço normal de etiqueta e a escolha da condição de pagamento.\r\nUtilize os códigos da tabela a seguir para ler qual a condição de pagamento escolhida e efetuar o cálculo adequado.\r\nCódigo Condição de pagamento\r\n1 À vista em dinheiro ou cheque, recebe 10% de desconto\r\n2 À vista no cartão de crédito, recebe 15% de desconto\r\n3 Em duas vezes, preço normal de etiqueta sem juros\r\n4 Em quatro vezes, preço normal de etiqueta mais juros de 10%");
                Console.WriteLine();
                Console.WriteLine("12) Escreva um algoritmo que leia o número de identificação, as 3 notas obtidas por um aluno nas 3 verificações e a média dos exercícios que fazem parte da avaliação, e calcule a média de aproveitamento, usando a fórmula: MA = (nota1 + nota 2 * 2 + nota 3 * 3 + ME)/7\r\nA atribuição dos conceitos obedece a tabela abaixo. O algoritmo deve escrever o número do aluno, suas notas, a média dos exercícios, a média de aproveitamento, o conceito correspondente e a mensagem 'Aprovado' se o conceito for A, B ou C, e 'Reprovado' se o conceito for D ou E.\r\nMédia de aproveitamento Conceito\r\n>= 90 A\r\n>= 75 e < 90 B\r\n>= 60 e < 75 C\r\n>= 40 e < 60 D\r\n< 40 E");
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.Write("Escolha a questão que você quer responder: ");

                int Opcao;
                Opcao = int.Parse(Console.ReadLine());

                switch (Opcao)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine();
                        Questao1 Quest1 = new Questao1();
                        Quest1.Q1();

                        break;

                    case 2:

                        Console.Clear();
                        Console.WriteLine();
                        Questao2 Quest2 = new Questao2();
                        Quest2.Q2();

                        break;

                    case 3:

                        Console.Clear();
                        Console.WriteLine();
                        Questao3 Quest3 = new Questao3();
                        Quest3.Q3();

                        break;

                    case 4:

                        Console.Clear();
                        Console.WriteLine();
                        Questao4 Quest4 = new Questao4();
                        Quest4.Q4();

                        break;

                    case 5:

                        Console.Clear();
                        Console.WriteLine();
                        Questao5 Quest5 = new Questao5();
                        Quest5.Q5();

                        break;

                    case 6:

                        Console.Clear();
                        Console.WriteLine();
                        Questao6 Quest6 = new Questao6();
                        Quest6.Q6();

                        break;

                    case 7:

                        Console.Clear();
                        Console.WriteLine();
                        Questao7 Quest7 = new Questao7();
                        Quest7.Q7();

                        break;

                    case 8:

                        Console.Clear();
                        Console.WriteLine();
                        Questao8 Quest8 = new Questao8();
                        Quest8.Q8();

                        break;

                    case 9:

                        Console.Clear();
                        Console.WriteLine();
                        Questao9 Quest9 = new Questao9();
                        Quest9.Q9();

                        break;

                    case 10:

                        Console.Clear();
                        Console.WriteLine();
                        Questao10 Quest10 = new Questao10();
                        Quest10.Q10();

                        break;

                    case 11:

                        Console.Clear();
                        Console.WriteLine();
                        Questao11 Quest11 = new Questao11();
                        Quest11.Q11();

                        break;

                    case 12:

                        Console.Clear();
                        Console.WriteLine();
                        Questao12 Quest12 = new Questao12();
                        Quest12.Q12();

                        break;

                    default:

                        Console.WriteLine();
                        Console.WriteLine("Código inválido!");

                        return;
                }

            } while (true);
        }
    }
} 
        