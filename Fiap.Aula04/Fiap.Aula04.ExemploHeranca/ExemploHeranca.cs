using Fiap.Aula04.ExemploHeranca.Models;
using System;

namespace Fiap.Aula04.ExemploHeranca
{
    class ExemploHeranca
    {
        static void Main(string[] args)
        {
            //Instanciar um Aluno 
            var aluno = new Aluno(nome: "Thalita", matricula: 123);

            //Atribuir o nome ao aluno
            //aluno.Nome = "Thalita";
            //aluno.Matricula = 123;

            //Instanciar uma Pessoa
            var pessoa = new Pessoa("Ricardo");

            pessoa.Nome = "Ricardo";

            //Chamar o método retornar dados e exibir o resultado
            Console.WriteLine(aluno.RetornarDados());
            Console.WriteLine(pessoa.RetornarDados());

            aluno.ObterPresenca();
            //pessoa.ObterPresenca(); pessoa não possui o método
        }
    }
}
