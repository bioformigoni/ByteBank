using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Gabriela";
           
            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.agencia);  // Valor pardrão  será 0
            Console.WriteLine(conta.numero); // Valor pardrão  será 0
            Console.WriteLine(conta.saldo); // Valor pardrão  será 100 pois foi atribuido na classe

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = "Bruno";
            conta2.saldo = 200;

            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.agencia);  // Valor pardrão  será 0
            Console.WriteLine(conta.numero); // Valor pardrão  será 0
            Console.WriteLine(conta.saldo); // Valor será 200 pois a atribuição sobreescreve o valor padrão
            Console.ReadLine();
        }
    }
}
