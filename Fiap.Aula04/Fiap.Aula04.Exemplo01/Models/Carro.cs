using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula04.Exemplo01.Models
{
    class Carro
    {
        //Propriedades prop tab tab
        public string Modelo { get; set; }
        public int Ano { get; set; }

        //Construtores -> Sem retorno e mesmo nome da classe
        public Carro(string modelo)
        {            
            Modelo = modelo;            
        }

        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
        }

    }
}
