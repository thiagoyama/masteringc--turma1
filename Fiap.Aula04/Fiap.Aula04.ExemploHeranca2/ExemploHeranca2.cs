using Fiap.Aula04.ExemploHeranca.Models;
using System;

namespace Fiap.Aula04.ExemploHeranca2
{
    class ExemploHeranca2
    {
        static void Main(string[] args)
        {
            //Instanciar um Aluno
            var aluno = new Aluno(matricula: 123, nome: "Felipe");

            //Atribuir um nome ao aluno
            //Nome com protected internal não é visível aqui
            //aluno.Nome = "José";
            aluno.Idade = 10;            
        }
    }
}
