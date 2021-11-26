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
