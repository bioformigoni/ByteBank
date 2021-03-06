using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";
            Console.WriteLine(contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(50);
            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);

            resultadoSaque = contaDoBruno.Sacar(500);
            Console.WriteLine(resultadoSaque);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            bool resultadoTransferecia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(resultadoTransferecia);

            Console.ReadLine();
        }
    }
}
