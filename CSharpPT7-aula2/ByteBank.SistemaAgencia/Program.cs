using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeContas = new List<ContaCorrente>() {
                new ContaCorrente(898,99759),
                new ContaCorrente(242,23424),
                new ContaCorrente(677,23424),
                new ContaCorrente(242,23423),
                new ContaCorrente(242,23423),
                new ContaCorrente(777,24234)
            };
            listaDeContas.Sort();
            foreach (ContaCorrente conta in listaDeContas)
            {
                Console.WriteLine(conta.Agencia + " - " + conta.Numero);
            }
            Console.ReadLine();

        }
        static void TestaSort()
        {
            //var teste = 17; //EVITAR ESTE TIPO DE PROCEDIMENTO
            //var conta = new ContaCorrente(213, 34535);
            //var gerenciador = new GerenciadorBonificacao();
            //var gerenciadores = new List<GerenciadorBonificacao>();
            var listaDeNomes = new List<string>(){
                "Jimmy", "Eric", "Yngwie", "Kiko", "Steve", "Joe"
            };
            listaDeNomes.Sort();
            foreach (var nome in listaDeNomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine();
            Console.WriteLine("-+=================================+-");
            var idades = new List<int>();
            idades.Add(5);
            idades.Add(2);
            idades.Add(1);
            idades.Add(4);
            idades.Add(56);
            idades.AdicionarVarios(5, 10, 50);
            idades.Sort();

            //ListExtensoes.AdicionarVarios(idades, 12, 1231, 31, 41);
            //idades.AdicionarVarios<int>(234, 099, 898, 87);


            int idadeSoma = 0;
            for (int i = 0; i < idades.Count; i++)
            {
                int idadeAtual = idades[i];
                Console.WriteLine(idadeAtual);
            }
            Console.ReadLine();
        }
        static void TestaListaDeArray()
        {
            Lista<int> idades = new Lista<int>();
            idades.Adicionar(5);
            idades.AdicionarVarios(5, 10, 50);
            int idadeSoma = 0;
            for (int i = 0; i < idades.Tamanho; i++)
            {
                int idadeAtual = idades[i];
            }
        }
        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();
            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(34);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(78);
            listaDeIdades.AdicionarVarios(16, 7, 8);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no índice {i}: {idade}");
            }

            Console.WriteLine(SomarVarios(1, 2, 3, 45, 6, 7, 788, 10));
            //ListaDeContaCorrente lista = new ListaDeContaCorrente();
            Console.ReadLine();
        }
        static void TestarListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(666, 666666666);

            ContaCorrente[] contas = new ContaCorrente[]
            {
            contaDoGui
            ,new ContaCorrente(874, 5679787)
            ,new ContaCorrente(874, 5679754)
            ,new ContaCorrente(874, 5679445)
            ,new ContaCorrente(874, 5679445)
            ,new ContaCorrente(874, 5679445)
            ,new ContaCorrente(874, 5679445)
            };
            lista.AdicionarVarios(contas);

            lista.AdicionarVarios(
            new ContaCorrente(874, 5679445)
            , new ContaCorrente(874, 5679445)
            , new ContaCorrente(874, 5679445)
            , new ContaCorrente(874, 5679445)
            , new ContaCorrente(874, 5679445)
            , new ContaCorrente(874, 5679445)
            , new ContaCorrente(874, 5679445)
            , new ContaCorrente(874, 5679445)
            );

            lista.EscreverListaNaTela();
            lista.Remover(contaDoGui);
            lista.EscreverListaNaTela();

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista.GetItemNoIndice(i);
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }

            Console.ReadLine();
        }
        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }
        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
                {
                    new ContaCorrente(874, 5679787),
                    new ContaCorrente(874, 4456668),
                    new ContaCorrente(874, 7781438)
                };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }
        static void TestaArrayInt()
        {
            // ARRAY de inteiros, com 5 posições!
            int[] idades = null;
            idades = new int[3];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");
        }

    }
}
