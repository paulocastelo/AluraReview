using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {


            Cliente cliente1 = new Cliente();
            cliente1.Nome = "Jonas";
            cliente1.CPF = "789.098.345-01";
            cliente1.Profissao = "Advogado";


            Cliente cliente2 = new Cliente();
            cliente2.Nome = "Jonas";
            cliente2.CPF = "789.098.345-01";
            cliente2.Profissao = "Advogado";

            if (cliente1.Equals(cliente2))
            {
                Console.WriteLine("Clientes iguais.");
            }
            else
            {
                Console.WriteLine("Clientes diferentes.");
            }
            Console.WriteLine();
            Console.ReadLine();

            ContaCorrente conta = new ContaCorrente(234, 5436);
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.ReadLine();
            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "Meu nome é Paulo Castelo, me ligue em 12346-1234";
            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));
            Match resultado = Regex.Match(textoDeTeste, padrao);
            Console.WriteLine(resultado);
            // pagina?argumentos
            // 012345678


            //moedaOrigem=real&moedaDestino=dolar
            //          |
            //  -------´

            //string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            //ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            //string valor = extratorDeValores.GetValor("moedaDestino");
            //Console.WriteLine("Valor de moedaDestino: " + valor);

            //string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            //Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

            //Console.WriteLine(extratorDeValores.GetValor("VALOR"));

            //Console.ReadLine();



            //Testando ToLower
            //string mensagemOrigem = "PALAVRA";
            //string termoBusca = "ra";

            //Console.WriteLine(mensagemOrigem.ToLower());


            // Testando Replace
            //termoBusca = termoBusca.Replace('r', 'R');
            //Console.WriteLine(termoBusca);

            //termoBusca = termoBusca.Replace('a', 'A');
            //Console.WriteLine(termoBusca);

            //Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            //Console.ReadLine();

            // Testando o método Remove
            //string testeRemocao = "primeiraParte&123456789";
            //int indiceEComercial = testeRemocao.IndexOf('&');
            //Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));
            //Console.ReadLine();


            // <nome>=<valor>
            //string palavra = "moedaOrigem=moedaDestino&moedaDestino=dolar";
            //string nomeArgumento = "moedaDestino=";

            //int indice = palavra.IndexOf(nomeArgumento);
            //Console.WriteLine(indice);

            //Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            //Console.WriteLine(palavra);
            //Console.WriteLine(palavra.Substring(indice));
            //Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
            //Console.ReadLine();





            // Testando o IsNullOrEmpty
            //string textoVazio = "";
            //string textoNulo = null;
            //string textoQualquer = "kjhfsdjhgsdfjksdf";
            //Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            //Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            //Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            //Console.ReadLine();

            //ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

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
