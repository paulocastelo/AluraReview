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
            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");
            Console.WriteLine("Teste 01:");
            if (indiceByteBank == 0)
            {
                Console.WriteLine("Você está no BytBank");
                Console.WriteLine(urlTeste);
            }
            else
            {
                Console.WriteLine("Você não está no BytBank");
                Console.WriteLine(urlTeste);
            }
            
            Console.WriteLine("Teste 02:");
            bool check = urlTeste.StartsWith("https://www.bytebank.com/");
            if (check)
            {
                Console.WriteLine("Você está no BytBank");
                Console.WriteLine(urlTeste);
            }
            else
            {
                Console.WriteLine("Você não está no BytBank");
                Console.WriteLine(urlTeste);
            }

            //string urlParametros = "https://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            //ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(urlParametros);

            //Console.WriteLine("Execuçao 01:");
            //string valor = extrator.GetValor("moedaOrigem");
            //Console.WriteLine("MoedaOrigem: " + valor);
            //Console.ReadLine();

            //Console.WriteLine("Execuçao 02:");
            //valor = extrator.GetValor("moedaDestino");
            //Console.WriteLine("MoedaDestino: " + valor);
            //Console.ReadLine();

            //Console.WriteLine("Execuçao 03:");
            //valor = extrator.GetValor("valor");
            //Console.WriteLine("Valor: " + valor);
            //Console.ReadLine();

            //Console.WriteLine("Execuçao 04:");
            //valor = extrator.GetValor("MOEDAORIGEM");
            //Console.WriteLine("MoedaOrigem: " + valor);
            //Console.ReadLine();

            //string palavra = "moedaOrigem=moedaDestino&moedaDestino=dolar";
            //string nomeArgumento = "moedaDestino=";

            //int indice = palavra.IndexOf(nomeArgumento);
            //Console.WriteLine(indice);

            //Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            //Console.WriteLine(palavra);
            //Console.WriteLine(palavra.Substring(indice));
            //Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
            //Console.ReadLine();



            //// Testando o IsNullOrEmpty
            //string textoVazio = "";
            //string textoNulo = null;
            //string textoQualquer = "kjhfsdjhgsdfjksdf";
            //Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            //Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            //Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            //Console.ReadLine();


            ////ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            //string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            //int indiceInterrogacao = url.IndexOf('?');

            //Console.WriteLine(indiceInterrogacao);

            //Console.WriteLine(url);
            //string argumentos = url.Substring(indiceInterrogacao + 1);
            //Console.WriteLine(argumentos);


            Console.ReadLine();
        }
    }


}
