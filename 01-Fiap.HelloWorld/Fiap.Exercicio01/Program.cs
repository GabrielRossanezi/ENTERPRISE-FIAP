using Fiap.Banco.Model;
using System;

namespace Fiap.Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar as contas
            var cc = new ContaCorrente()
            {
                Agencia = 1,
                Numero = 1,
                Saldo = 1000,
                Tipo = Model.TipoConta.Comum,
                DataAbertura = DateTime.Now
            };

            var cp = new ContaPoupanca(0.03m)
            {
                Agencia = 1,
                Numero = 2,
                Saldo = 500,
                Taxa = 1,
                DataAbertura = new DateTime(2019, 1, 19)
            };

            cc.Retirar(1500);

        }
    }
}
