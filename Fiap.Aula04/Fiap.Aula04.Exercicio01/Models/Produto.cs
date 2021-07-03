using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula04.Exercicio01.Models
{
    class Produto
    {
        //Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public Fornecedor Fornecedor { get; set; }

        //Construtor
        public Produto(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        //Método
        public decimal CalcularDesconto(decimal porcentagem)
        {
            return Preco - (Preco * porcentagem )/ 100;
        }

        //Sobrecarga de método: método com mesmo nome e parâmetros diferentes
        //virtual -> permite que o método seja sobrescrito na classe filha
        public virtual decimal CalcularDesconto() 
        {
            //Exemplo: desconto padrão de 5%
            //return Preco - Preco * 0.05m;
            return CalcularDesconto(5);
        }

        public virtual decimal CalcularDesconto(string cupom)
        {
            //Exemplo: FIAP10 dá 10% de desconto
            return cupom == "FIAP10" ? CalcularDesconto(10) : Preco;
        }
    }
}
