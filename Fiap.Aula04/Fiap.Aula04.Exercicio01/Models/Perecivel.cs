using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula04.Exercicio01.Models
{
    class Perecivel : Produto
    {
        //Propriedade
        public DateTime DataValidade { get; set; }

        //Construtor
        public Perecivel(int id, string nome, DateTime dataValidade) : base(id, nome)
        {
            DataValidade = dataValidade;
        }

    }
}
