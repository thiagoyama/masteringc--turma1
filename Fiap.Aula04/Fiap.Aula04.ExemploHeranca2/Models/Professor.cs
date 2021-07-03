using Fiap.Aula04.ExemploHeranca.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula04.ExemploHeranca2.Models
{
    public class Professor : Pessoa
    {
        //Propriedade
        public string MateriaLecionada { get; set; }

        //Construtor
        public Professor(string nome) : base(nome)
        {

        }

        //Método
        public void FazerChamada()
        {
            Console.WriteLine($"{Nome} está fazendo chamada");
        }

    }
}
