using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        static void LidandoComOFileStreamDiretamente()
        {
            var enderecoArquivo = "contas.txt";

            var fluxoDoArquivo = new FileStream(enderecoArquivo, FileMode.Open);

            var buffer = new byte[1024];

            var numeroDeBytesLidos = -1;

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);

            }

            fluxoDoArquivo.Close();

            Console.ReadLine();
        }
        static void EscreverBuffer(byte[] buffer)
        {
            var utf8 = new UTF8Encoding();

            var texto = utf8.GetString(buffer);
            Console.WriteLine(texto);

            foreach (var meuByte in buffer)
            {
                Console.Write(meuByte);
                Console.Write(" ");
            }
        }
    }
}
