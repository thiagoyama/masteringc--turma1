using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula03.Exercicio01.Models
{
    class ContaPoupanca
    {
        //Propriedades
        public decimal Saldo { get; private set; }
        public double Numero { get; set; }
        public decimal Rendimentos { get; set; }

        //Construtor
        public ContaPoupanca(double numero)
        {
            Numero = numero;
        }

        //Métodos
        public bool Depositar(decimal valor)
        {
            //valida se o valor de depósito é positivo            
            if (valor > 0)
            {
                Saldo += valor;
                return true;
            }
            return false;
        }
        
        public bool Retirar(decimal valor)
        {
            //valida se o saldo é suficiente
            if (Saldo >= valor)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }
    }
}
