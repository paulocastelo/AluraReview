using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentoURL
    {
        private readonly string _argumentos;
        public string URL { get; }
        public ExtratorValorDeArgumentoURL(string url)
        {
            string.IsNullOrEmpty(url);
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento URL não por ser uma string nula ou vazia!", nameof(url));
            }
            URL = url;
            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);
        }

        public string GetValor(string nomeDoParametro)
        {
            int indiceParametro = _argumentos.IndexOf
        }
    }
}
