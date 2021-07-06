using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula05.Exercicio01.Models
{
    class Instituicao
    {
        //propriedade
        public string Nome { get; set; }

        //Construtor
        public Instituicao(string nome)
        {
            Nome = nome;
        }
    }
}
