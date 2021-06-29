using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula02.Exercicio01.Models
{
    class Aviao
    {
        //Propriedades
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Comprimento { get; set; }
        public Cor Cor { get; set; }
        public string Prefixo { get; set; }
        public decimal Valor { get; set; }
        public double HorasVoo { get; set; }
    }
}
