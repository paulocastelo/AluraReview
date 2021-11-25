using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ContaCorrente> listaDeContas = new List<ContaCorrente>();
            int qtdeContas;

            Console.WriteLine("Deseja cadastrar quantas contas?");
            qtdeContas = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdeContas; i++)
            {
                int agencia, numero;
                ContaCorrente conta;
                Console.WriteLine();
                Console.WriteLine($"Favor informa o número da agencia {i + 1}");
                agencia = int.Parse(Console.ReadLine());
                Console.WriteLine($"Favor informa o número da conta {i + 1}");
                numero = int.Parse(Console.ReadLine());
                conta = new ContaCorrente(agencia, numero);
                listaDeContas.Add(conta);
            }

            //Console.WriteLine("Tamanho da lista: " + listaDeContas.Count);

            foreach (ContaCorrente contaCorrente in listaDeContas)
            {
                Console.WriteLine(contaCorrente);
            }

            Console.ReadLine();
        }
        static void TestaArrayDeContaCorrente()
        {
            Console.WriteLine("Informe a quantidade de contas para criar: ");
            int numContas = int.Parse(Console.ReadLine());
            ContaCorrente[] arrayContas = new ContaCorrente[numContas];
            if (numContas > 0)
            {
                for (int i = 0; i < arrayContas.Length; i++)
                {
                    Console.WriteLine();
                    ContaCorrente novaConta;
                    int agencia, numero;
                    Console.WriteLine($"Criando conta nº{i + 1}");
                    Console.WriteLine("Informe a agência da conta:");
                    agencia = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o número da conta:");
                    numero = int.Parse(Console.ReadLine());
                    arrayContas[i] = new ContaCorrente(agencia, numero);
                }

                for (int i = 0; i < arrayContas.Length; i++)
                {
                    Console.WriteLine(arrayContas[i]);
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("Número inválido!");
            }
            Console.ReadLine();
        }
        static void TestaArrayInt()
        {
            Console.WriteLine("Informe a quantidade de idades deseja informar: ");
            int qtdeIdades = int.Parse(Console.ReadLine());
            int[] listaIdades = new int[qtdeIdades];
            int somaDasIdades = 0;
            int counter = 0;
            for (int i = 0; i < qtdeIdades; i++)
            {
                int insereIdade;
                Console.WriteLine($"Informe a idade {i + 1}: ");
                listaIdades[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < listaIdades.Length; i++)
            {
                somaDasIdades += listaIdades[i];
                Console.WriteLine($"Somando a idade na posição {i}.");
            }

            Console.WriteLine("A média das idades é " + (somaDasIdades / listaIdades.Length));
            Console.ReadLine();
        }
    }
}
