﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class LeitorDeArquivos : IDisposable
    {
        public string Arquivo { get; }
        public LeitorDeArquivos(string arquivo)
        {
            Arquivo = Arquivo;
            //throw new FileNotFoundException();
            Console.WriteLine("Abrindo o arquivo: " + arquivo);
        }
        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha. . .");

            //throw new IOException();
            return "Linha do arquivo";
        }
        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}
