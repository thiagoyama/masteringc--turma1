using Fiap.Aula04.Exemplo01.Models;
using System;

namespace Fiap.Aula04.Exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um carro utilizando o construtor com o modelo
            var celta = new Carro("Celta 1.0");

            //Instanciar um carro utilizando o construtor com dois argumentos 
            var gol = new Carro("Gol", 2010);

            //Exibir os valores dos objetos
            Console.WriteLine($"Modelo: {celta.Modelo}, Ano: {celta.Ano}");
            Console.WriteLine($"Modelo: {gol.Modelo}, Ano: {gol.Ano}");

            //Instanciar a moto com o construtor padrão, informando os valores para as propriedades
            var honda = new Moto()
            { 
                Cilindrada = 100,
                Passageiros = 2
            };

            //Exibir os dados da moto
            Console.WriteLine($"Cilindrada: {honda.Cilindrada}, Passageiros: {honda.Passageiros}");
        }
    }
}
 