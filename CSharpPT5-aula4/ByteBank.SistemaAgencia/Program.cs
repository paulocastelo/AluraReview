using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra = "moedaDestino=real";
            int indice = palavra.IndexOf("real");
            Console.WriteLine(indice);


            
            
            string url = "pagina?argumentos";
            Console.WriteLine(url);
            string argumentos = url.Substring(7);
            int indiceInterrogacao = url.IndexOf('?') + 1;
            Console.WriteLine(argumentos);
            Console.WriteLine("Substring com ? dinâmico: " + url.Substring(indiceInterrogacao));
            Console.ReadLine();
        }
    }
}
