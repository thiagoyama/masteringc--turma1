using Fiap.Aula05.Exemplo.Models;
using System;

namespace Fiap.Aula05.Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar uma Pessoa Fisica e atribuir um valor para o Sexo
            var pf = new PessoaFisica()
            {
                Nome = "Ricardo",
                Sexo = Genero.Masculino
            };

            //Validar se o sexo é feminino
            if (pf.Sexo == Genero.Feminino)
                Console.WriteLine("O genero é feminino");
            else
                Console.WriteLine("O genero não é feminino");

            //Exibir o valor do sexo
            Console.WriteLine(pf.Sexo);
            Console.WriteLine( (int) pf.Sexo); //Exibe o valor da constante

        }
    }
}
