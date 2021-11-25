using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(234, 2345);
            conta.Depositar(100);
            new ContaCorrente(123, 98734);

            //string nome = "";
            Console.WriteLine(conta.Saldo);
            Console.ReadLine();
        }
    }
}
