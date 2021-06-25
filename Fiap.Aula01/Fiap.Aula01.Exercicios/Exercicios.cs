using System;

namespace Fiap.Aula01.Exercicios
{
    class Exercicios
    {
        static void Main(string[] args)
        {
            //Exercício 01
            //Ler o valor do veículo
            Console.WriteLine("Digite o valor:");
            double custoFabrica = double.Parse(Console.ReadLine());

            //Realizar o cálculo
            double porcentagemDistribuidor = custoFabrica * 0.29;
            double impostos = custoFabrica * 0.46;
            double valorFinal = custoFabrica + porcentagemDistribuidor + impostos;

            //Exibir o valor obtido
            Console.WriteLine($"O valor final é {valorFinal}");

            //Exercício 02
            //Ler o salario fixo e o total de vendas
            Console.WriteLine("Digite o salário");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de vendas");
            double vendas = double.Parse(Console.ReadLine());

            double totalReceber;
            //Verificar se o total de vendas é maior que 1500
            if (vendas > 1500)
            {
                totalReceber = salario + (vendas - 1500) * 0.1 + 75;
            }
            else
            {
                totalReceber = salario + vendas * 0.05;
            }

            //Exibir o salário total
            Console.WriteLine($"Total a receber:  {totalReceber}");

            //Exercício 03
            //Ler a quantidade de alunos
            Console.WriteLine("Digite a quantidade de alunos");
            int qtd = int.Parse(Console.ReadLine());

            //Declarar as variáveis total de alunos da turma a e b, total de notas turma a e b
            float totalNotasA = 0;
            float totalNotasB = 0;
            int totalAlunosA = 0;
            int totalAlunosB = 0;

            //Laço de repetição com a qtd lida
            for (int i = 0; i < qtd; i++) 
            {
                //Ler a turma (a ou b)
                Console.WriteLine("Digite a turma (a ou b)");
                string turma = Console.ReadLine();
                //Ler a nota
                Console.WriteLine("Digite a nota");
                //Parse -> converte uma String para o tipo float
                float nota = float.Parse(Console.ReadLine());

                //Somar a nota no total de notas da turma
                //Adicionar mais um no contator de alunos da turma
                switch (turma)
                {
                    case "a":
                        totalAlunosA++;
                        totalNotasA += nota;
                        break;
                    case "b":
                        totalAlunosB++;
                        totalNotasB += nota;
                        break;
                    default:
                        Console.WriteLine("Curso inválido");
                        i--; //decrementa em um o contador do laço
                        break;
                } //switch
            }//for
            //Fora do laço de repetição
            //Calcular as médias e exibir o resultado
            Console.WriteLine($"A média da turma A é {totalNotasA/totalAlunosA}");
            Console.WriteLine($"A média da turma B é {totalNotasB/totalAlunosB}");
            Console.WriteLine($"A média do curso é {(totalNotasA + totalNotasB)/(totalAlunosA+totalAlunosB)}");
        }
    }
}
