using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula04.Exercicio01.Models
{
    class Livro : Produto
    {
        //Propriedades
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }
        public int AnoPublicacao { get; set; }

        //Construtor
        public Livro(int id, string nome, string autor) : base(id, nome)
        {
            Autor = autor;
        }

        //Sobrescrever o método definido no pai (override), modificar o comportamento do método na classe filha
        public override decimal CalcularDesconto()
        {
            return CalcularDesconto(50);
        }

        //Sobrescrever o método desconto com cupom, adicionando o cupom FIAPBOOK com 30%
        public override decimal CalcularDesconto(string cupom)
        {
            //base para referenciar o método calcularDesconto(string cupom) do pai
            return cupom == "FIAPBOOK" ? CalcularDesconto(30) : base.CalcularDesconto(cupom);
        }

    }
}
