using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        enum Menu {Adicao = 1, Subtracao, Mutiplicacao, Divisao, Potencia, Raiz, Sair }
        static void Main(string[] args)
        {
            char EscolherSair = 'n';
            do
            {
                Console.Clear();

                Console.WriteLine("Seja bem vindo ao CALC");
                Console.WriteLine("1 - Adicao\n2 - Subtracao\n3 - Mutiplicacao\n4 - Divisao\n" +
                                  "5 - Potencia\n6 - Raiz\n7 - Sair");
                Console.Write("Selecione um das opçoes: ");

                // para fins didaticos oque esta acontecendo aqui 
                //nos estamos recebendo o valor que vai ser escrito no console que vem em string
                //vaos converter para int que vai buscar em menu e atribuir a opção que virou uma variavel.
                Menu opcao = (Menu)Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case Menu.Adicao:
                        Adicao();
                        break;

                    case Menu.Subtracao:
                        Subtracao();
                        break;

                    case Menu.Mutiplicacao:
                        Mutiplicacao();
                        break;

                    case Menu.Divisao:
                        Divisao();
                        break;

                    case Menu.Potencia:
                        Potencia();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        Console.Write("Deseja sair do programa s/n: ");
                        EscolherSair = Convert.ToChar(Console.ReadLine());
                        break;
                }

            } while (EscolherSair != 's' && EscolherSair != 'S');
           
            Console.ReadKey();
        }

        public static void Adicao()
        {
            Console.WriteLine("Soma de dois numeros");
            Console.Write("Digite o primeiro numero: ");
            int N1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            int N2 = Convert.ToInt32(Console.ReadLine());

            int Resultado = N1 + N2;
            Console.WriteLine($"O resultado é: {Resultado}");
            Console.WriteLine("Precione ENTER para voltar para o menu");
            Console.ReadKey();
        }

        public static void Subtracao()
        {
            Console.WriteLine("Subtração de dois numeros");
            Console.Write("Digite o primeiro numero: ");
            int N1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            int N2 = Convert.ToInt32(Console.ReadLine());

            int Resultado = N1 - N2;
            Console.WriteLine($"O resultado é: {Resultado}");
            Console.WriteLine("Precione ENTER para voltar para o menu");
            Console.ReadKey();
        }

        public static void Mutiplicacao()
        {
            Console.WriteLine("Mutiplicação de dois numeros");
            Console.Write("Digite o primeiro numero: ");
            int N1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            int N2 = Convert.ToInt32(Console.ReadLine());

            int Resultado = N1 * N2;
            Console.WriteLine($"O resultado é: {Resultado}");
            Console.WriteLine("Precione ENTER para voltar para o menu");
            Console.ReadKey();
        }

        public static void Divisao()
        {
            Console.WriteLine("Divisão de dois numeros");
            Console.Write("Digite o primeiro numero: ");
            int N1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            int N2 = Convert.ToInt32(Console.ReadLine());
            if (N2 == 0)
            {
                Console.WriteLine("Não é possivel dividir por 0");
            }
            else
            {
                double Resultado = (double)N1 / (double)N2;
                Console.WriteLine($"O resultado é: {Resultado}");
                Console.WriteLine("Precione ENTER para voltar para o menu");
                Console.ReadKey();
            }
        
        }

        public static void Potencia()
        {
            Console.WriteLine("Potencia de dois numeros");
            Console.Write("Digite o numero Base: ");
            int BaseNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Expoente: ");
            int Expo = Convert.ToInt32(Console.ReadLine());

            double Resultado = Math.Pow(BaseNum,Expo);
            Console.WriteLine($"O resultado é: {Resultado}");
            Console.WriteLine("Precione ENTER para voltar para o menu");
            Console.ReadKey();
        }
        public static void Raiz()
        {
            Console.WriteLine("Raiz de um numeros");
            Console.Write("Digite o numero: ");
            int N1 = Convert.ToInt32(Console.ReadLine());

            double Resultado = Math.Sqrt(N1);
            Console.WriteLine($"O resultado é: {Resultado}");
            Console.WriteLine("Precione ENTER para voltar para o menu");
            Console.ReadKey();
        }
    }
}
