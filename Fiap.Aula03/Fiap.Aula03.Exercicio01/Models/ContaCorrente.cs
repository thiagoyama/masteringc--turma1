using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula03.Exercicio01.Models
{
    class ContaCorrente
    {
        //Propriedades prop -> tab tab
        public decimal Saldo { get; private set; }
        public double Numero { get; set; }
        public bool Especial { get; set; }
        public decimal Limite { get; set; }
        public Cliente Cliente { get; set; }
        public ContaPoupanca ContaPoupanca { get; set; }
        public double Juros { get; set; }

        //Construtor
        public ContaCorrente(Cliente cliente, ContaPoupanca poupanca, double numero, bool especial)
        {
            Cliente = cliente;
            ContaPoupanca = poupanca;
            Numero = numero;
            Especial = especial;
        }

        //Métodos
        public bool Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                return true;
            }
            return false;
        }

        public bool Retirar(decimal valor)
        {
            /*
            //Valida se a conta é especial
            if (Especial)
            {
                if (valor <= Saldo + Limite)
                {
                    Saldo -= valor;                    
                    return true;
                }
            }
            else
            {
                if (valor <= Saldo)
                {
                    Saldo -= valor;
                    return true;
                }
            }
            */
            if ((Especial && valor <= Saldo + Limite) || (valor <= Saldo))
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }

        public decimal RetornarSaldoTotal()
        {            
            //Ternário (Condição ? Se verdadeiro : Se falso)
            return Especial ? Saldo + Limite : Saldo;
            /*
            if (Especial)
                return Saldo + Limite;
            else
                return Saldo;
            */
        }

        public bool TransferirParaPoupanca(decimal valor)
        {
            //Retira da conta corrente, se conseguir adiciona na conta poupança
            //Chama o método retirar da cc e valida se foi possível
            if (Retirar(valor))
            {
                //Depositar na conta poupança
                ContaPoupanca.Depositar(valor);
                return true;
            }
            return false;
        }

        public decimal CalcularTaxaJuros(int dias)
        {
            //return Saldo < 0 ? dias * Convert.ToDecimal(Juros) * Saldo * -1 : 0;
            //valida se a conta está negativa
            //Converter um double em decimal, para ser possível a multipliacação por decimal
            if (Saldo < 0)
                return dias * Convert.ToDecimal(Juros) * Saldo * -1;
            return 0;
        }
    }
}
