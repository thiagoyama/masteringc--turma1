using Fiap.Aula02.Exemplo.Models;
using System;

namespace Fiap.Aula02.Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um produto
            // CTRL + . ou ALT + enter
            //Variáveis não são inicializadas com o valor padrão
            Produto notebook = new Produto();

            //Atribuir valores para os atributos
            notebook.Id = 10;
            notebook.Nome = "Dell XPS";
            notebook.Valor = 1000;

            //Instanciar um fabricante
            Fabricante fabricante = new Fabricante();
            fabricante.Nome = "Dell";

            //Atribuir o objeto fabricante no atributo do objeto produto
            notebook.Fabricante = fabricante;

            //Recuperar e exibir os valores dos atributos
            Console.WriteLine(notebook.Id);
            //Exibir o nome do fabricante e se está ativo ou não
            Console.WriteLine($"{notebook.Fabricante.Nome} está ativo: {notebook.Fabricante.Ativo}");

            //Calcular e exibir o valor do notebook com 15% de desconto
            decimal valor = notebook.CalcularDesconto(15);
            Console.WriteLine($"O produto com desconto é {valor}");

            //Instanciar um outro objeto Produto com outros valores nos atributos
            Produto mouse = new Produto();
            mouse.Nome = "Multilase";
        }
    }
}
