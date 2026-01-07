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
                Console.WriteLine("Seja bem vindo ao CALC");
                Console.WriteLine("1 - Adicao\n2 - Subtracao\n3 - Mutiplicacao\n4 - Divisao\n" +
                                  "5 - Potencia\n6 - Raiz\n7 - Sair");
                Console.Write("Selecione um das opçoes: ");

                // para fins didaticos oque esta acontecendo aqui 
                //nos estamos recebendo o valor que vai ser escrito no console que vem em string
                //vaos converter para int que vai buscar em menu e atribuir a opção que virou uma variavel.
                Menu opcao = (Menu)Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(opcao);



            } while (EscolherSair != 's' && EscolherSair != 'S');
           
            Console.ReadKey();
        }

    }
}
