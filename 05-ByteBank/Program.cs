using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
           //Cliente gabriela = new Cliente();

            // Populando o objeto gabriela
            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Desenvolvedora C#";
            //gabriela.cpf = "434.562.878-20";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = gabriela;

            // Populando o objeto conta
            // conta.titular = new Cliente();
            // Com a referencia para o titular comentada dará o seguinte erro
            // System.NullReferenceException: 'Referência de objeto não definida para uma instância de um objeto.'
            // Não é possivel acessar o valor de um tipo de referencia não atruido
            if (conta.titular == null)
            {
                Console.WriteLine("Ops, a referência em conta.titular é NULL");
                Console.ReadLine();
            }
            conta.titular.nome = "Gabriela Costa";
            conta.titular.profissao = "Desenvolvedora C#";
            conta.titular.cpf = "434.562.878-20";

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);

            conta.titular.nome = "Gabriela Costa";

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}
