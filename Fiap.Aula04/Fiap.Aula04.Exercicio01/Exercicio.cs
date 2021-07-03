using Fiap.Aula04.Exercicio01.Models;
using System;

namespace Fiap.Aula04.Exercicio01
{
    class Exercicio
    {
        static void Main(string[] args)
        {
            //Instanciar um Produto, Eletronico, Livro e Perecivel
            var produto = new Produto(1 , "Camiseta");
            
            var eletronico = new Eletronico(2, "Notebook") 
            { 
                Garantia = true,
                Preco = 2500
            };
            
            var livro = new Livro(3, "O poder do Habito", "Charles Duhigg") 
            { 
                Preco = 40
            };
            
            //DateTime -> Utiliza o construtor com ano, mes, dia
            var arroz = new Perecivel(4, "Arroz", new DateTime(2022, 12, 25) );

            //Chamar o método para calcular o desconto e exibir o resultado
            //CTRL + D -> duplica a linha
            Console.WriteLine($"O valor com desconto de 10% é {livro.CalcularDesconto(10)}");
            Console.WriteLine($"O valor com desconto padrão é {livro.CalcularDesconto()}");
            Console.WriteLine($"O valor com cupom é {livro.CalcularDesconto("FIAPBOOK")}");

            //Chamar o método para calcular o valor da garantia e exibir o resultado
            Console.WriteLine($"O valor da garantia é de {eletronico.CalcularGarantiaEstendida()}");
            Console.WriteLine($"O valor da garantia de 2 anos é de {eletronico.CalcularGarantiaEstendida(2)}");

        }
    }
}
