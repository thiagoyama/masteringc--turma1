using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula04.Exercicio01.Models
{
    class Fornecedor
    {
        //Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        //Construtor
        public Fornecedor(int id, string nome, string telefone)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
        }
    }
}
