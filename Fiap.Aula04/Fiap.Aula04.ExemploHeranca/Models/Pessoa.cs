using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula04.ExemploHeranca.Models
{
    public class Pessoa
    {
        //Propriedades
        //protected internal -> classes filhas e classes do mesmo projeto
        //protected private -> classes filhas dentro do mesmo projeto
        public string Nome { get; set; }
        public int Idade { get; set; }

        //Construtor de pessoa com o nome
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        //Método
        public string RetornarDados()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }
}
