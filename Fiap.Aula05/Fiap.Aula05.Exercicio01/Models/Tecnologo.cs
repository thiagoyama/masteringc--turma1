using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula05.Exercicio01.Models
{
    class Tecnologo : Formacao
    {
        //Propriedade
        public bool PlanoEstendido { get; set; }

        //Construtor
        public Tecnologo(string nome) : base(nome) { }

        //Método
        public override decimal CalcularMensalidade()
        {
            return Mensalidade = 500 * Duracao;
        }

        protected override void DefinirDuracao()
        {
            Duracao = 24;
        }

    }
}
