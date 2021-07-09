using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula03.Exercicio01.Models
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        //Propriedades
        public decimal Rendimentos { get; set; }

        //Construtor
        public ContaPoupanca(double numero)
        {
            Numero = numero;
        }

        //Métodos
        public bool Retirar(decimal valor)
        {
            //valida se o saldo é suficiente
            if (Saldo >= valor)
            {
                Saldo -= valor;
                return true;
            }
            throw new Exception("Saldo insuficiente");
        }

        public decimal CalcularRetornoInvestimento(decimal taxa)
        {
            return Saldo * taxa;
        }
    }
}
