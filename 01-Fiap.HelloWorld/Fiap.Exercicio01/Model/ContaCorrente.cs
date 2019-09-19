using Fiap.Exercicio01.Exception;
using Fiap.Exercicio01.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Banco.Model
{
    //sealed -> classe não poderá ser herdada
    sealed class ContaCorrente : Conta
    {
        //Propriedades
        public TipoConta Tipo { get; set; }

        //Métodos
        public override decimal Depositar(decimal valor)
        {
            Saldo += valor;
            return Saldo;
        }

        public override decimal Retirar(decimal valor)
        {
            if (Tipo == TipoConta.Comum && Saldo < valor)
            {
                throw new SaldoInsuficienteException();
            }
            Saldo -= valor;
            return Saldo;
        }
    }
}
