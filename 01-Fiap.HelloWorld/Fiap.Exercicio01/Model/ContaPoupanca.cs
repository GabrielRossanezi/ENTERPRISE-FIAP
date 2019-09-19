using Fiap.Exercicio01.Exception;
using Fiap.Exercicio01.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        //Propriedade
        public decimal Taxa { get; set; }

        //Atributos
        private readonly decimal _rendimento;

        //Construtor
        public ContaPoupanca(decimal rendimento)
        {
            _rendimento = rendimento;
        }

        public decimal CalculaRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }

        public override decimal Depositar(decimal valor)
        {
            Saldo += valor;
            return Saldo;
        }

        public override decimal Retirar(decimal valor)
        {
            if (Saldo < valor)
            {
                throw new SaldoInsuficienteException();
            }
            Saldo -= valor + Taxa;
            return Saldo;
        }
    }
}
