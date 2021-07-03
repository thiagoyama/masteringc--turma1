using Fiap.Aula03.Exercicio01.Models;
using System;

namespace Fiap.Aula03.Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler os dados do cliente (Nome, cpf, telefone)
            Console.WriteLine("Digite o nome do cliente");
            string nome = Console.ReadLine();

            //var -> define uma variável do tipo do valor atribuido a ela
            Console.WriteLine("Digite o cpf");
            var cpf = Console.ReadLine();

            Console.WriteLine("Digite o telefone");
            var telefone = Console.ReadLine();

            //Ler os dados da conta poupança (número)
            Console.WriteLine("Digite o número da conta poupança");
            var numeroPoupanca = double.Parse(Console.ReadLine());

            //Ler os dados da conta corrente (número, especial (se sim, juros e limite))
            Console.WriteLine("Digite o número da conta corrente");
            var numeroCc = double.Parse(Console.ReadLine());

            Console.WriteLine("A conta corrente é especial?");
            var especial = bool.Parse(Console.ReadLine());

            //Instanciar os objetos e atribuir os valores aos seus atributos (propriedades)
            //Passa o nome do parâmetro e o valor no método
            var cliente = new Cliente(nome: nome, telefone: telefone, cpf: cpf);
            //var cliente = new Cliente(nome, cpf, telefone);

            //ctr + K + C -> comenta o bloco selecionado
            //cliente.Nome = nome;
            //cliente.Telefone = telefone;
            //cliente.Cpf = cpf;

            var cp = new ContaPoupanca(numeroPoupanca);
            //cp.Numero = numeroPoupanca;

            var cc = new ContaCorrente(cliente, cp, numeroCc, especial);
            //cc.Cliente = cliente;
            //cc.ContaPoupanca = cp;
            //cc.Numero = numeroCc;
            //cc.Especial = especial;
            
            if (especial)
            {
                Console.WriteLine("Digite o limite");
                var limite = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite os Juros");
                var juros = double.Parse(Console.ReadLine());

                cc.Limite = limite;
                cc.Juros = juros;
            }

            //variável que armazena a opção do menu
            int opcao;

            do
            {
                //Menu
                Console.WriteLine("1 - Depositar \n2 - Retirar \n3 - Transferir \n4 - " +
                                             "Calcular o valor da taxa de Juros \n0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o valor para depósito");
                        var valor = decimal.Parse(Console.ReadLine());
                        cc.Depositar(valor);
                        Console.WriteLine($"O saldo é {cc.Saldo} e o saldo total é {cc.RetornarSaldoTotal()}");
                        break;
                    case 2:
                        Console.WriteLine("Digite o valor para saque");
                        valor = decimal.Parse(Console.ReadLine());
                        cc.Retirar(valor);
                        Console.WriteLine($"O saldo é {cc.Saldo} e o saldo total é {cc.RetornarSaldoTotal()}");
                        break;
                    case 3:
                        Console.WriteLine("Digite o valor para transferência");
                        valor = decimal.Parse(Console.ReadLine());
                        cc.TransferirParaPoupanca(valor);
                        Console.WriteLine($"O saldo é {cc.Saldo} e o saldo total é {cc.RetornarSaldoTotal()}");
                        Console.WriteLine($"O saldo da poupança é {cc.ContaPoupanca.Saldo}");
                        break;
                    case 4:
                        Console.WriteLine("Digite a quantidade de dias");
                        var dias = int.Parse(Console.ReadLine());
                        Console.WriteLine($"O valor dos juros será de {cc.CalcularTaxaJuros(dias)}");
                        break;
                    case 0:
                        Console.WriteLine("Finalizando o sistema");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (opcao != 0);

        }//main
    }//classe
}//namespace
