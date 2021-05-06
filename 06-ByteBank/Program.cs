﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Guilherme";
            cliente.CPF = "434.564.879-20";
            cliente.Profissao = "Desenvolvedor";

            conta.Saldo = - 10;
            Console.WriteLine(conta.Saldo);

            conta.Saldo = 10;
            Console.WriteLine(conta.Saldo);

            conta.Titular = cliente;
            Console.WriteLine(conta.Titular.Nome);

            Console.ReadLine();
        }
    }
}
